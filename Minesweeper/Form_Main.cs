using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Minesweeper
{
    public partial class Form_Main : Form
    {
        public int nWidth;     //雷区宽度
        public int nHeight;    //雷区高度
        public int nMineCnt;   //地雷的数目

        bool bMark;     //表示是否使用标记
        bool bAudio;    //表示是否使用音效

        const int MAX_WIDTH = 64;    //最大宽度
        const int MAX_HEIGHT = 32;   //最大高度

        int[,] pMine = new int[MAX_WIDTH, MAX_HEIGHT];   //第一类数据
        int[,] pState = new int[MAX_WIDTH, MAX_HEIGHT];   //第二类数据

        int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };  //x坐标偏移量
        int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 };  //y坐标偏移量

        Point MouseFocus;                                    //高亮点记录

        bool bMouseLeft;                                     //鼠标左键是否被按下
        bool bMouseRight;                                    //鼠标右键是否被按下

        int[] px = new int[] { 1, -1, 0, 0 };
        int[] py = new int[] { 0, 0, 1, -1 };

        bool bGame;                                          // 游戏是否结束

        System.Media.SoundPlayer soundTick;                  //计时声
        System.Media.SoundPlayer soundBomb;                  //爆炸声

        public Form_Main()
        {
            InitializeComponent();

            this.DoubleBuffered = true;      //开启双缓冲
            //初始化游戏参数
            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;

            //初始化
            bMark = Properties.Settings.Default.Mark;
            bAudio = Properties.Settings.Default.Audio;
            标记MToolStripMenuItem.Checked = bMark;
            音效AToolStripMenuItem.Checked = bAudio;

            //初始化音频信息
            soundTick = new System.Media.SoundPlayer(Properties.Resources.Tick);
            soundBomb = new System.Media.SoundPlayer(Properties.Resources.Bomb);

            UpdateSize();
            SelectLevel();
        }

        /// <summary>
        /// 游戏参数设置
        /// </summary>
        /// <param name="Width">雷区宽度</param>
        /// <param name="Height">雷区高度</param>
        /// <param name="MineCnt">地雷数目</param>
        private void SetGame(int Width, int Height, int MineCnt)
        {
            nWidth = Width;
            nHeight = Height;
            nMineCnt = MineCnt;
        }

        /// <summary>
        /// 设置游戏等级为初级
        /// </summary>
        private void SetGameBeginner()
        {
            SetGame(10, 10, 10);
        }

        /// <summary>
        /// 设置游戏等级为一般
        /// </summary>
        private void SetGameIntermediate()
        {
            SetGame(16, 16, 40);
        }

        /// <summary>
        /// 设置游戏等级为高级
        /// </summary>
        private void SetGameExpert()
        {
            SetGame(30, 16, 99);
        }

        /// <summary>
        /// 绘制雷区
        /// </summary>
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }

        /// <summary>
        /// 绘制游戏区
        /// </summary>
        private void PaintGame(Graphics g)
        {
            g.Clear(Color.White);       //清空绘图区
            //Graphics g = this.CreateGraphics();   //创建绘图句柄
            //g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
            //我们需要是雷区在用户显示的区域上下左右保持6px的偏移量，使得整体看起来更加协调
            int nOffsetX = 6;      //X方向偏移量
            int nOffsetY = 6 + MenuStrip_Main.Height;
            for (int i = 1; i <= nWidth; i++)     //绘制行
            {
                for (int j = 1; j <= nHeight; j++)//绘制列
                {
                    if (pState[i, j] != 1) //未点开
                    {
                        if (i == MouseFocus.X && j == MouseFocus.Y)   //是否为高亮
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));  //绘制雷区方块
                        }
                        //绘制背景
                        if (pState[i, j] == 2)
                        {
                            g.DrawImage(Properties.Resources.Flag, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);  //绘制红旗
                        }
                        if (pState[i, j] == 3)
                        {
                            g.DrawImage(Properties.Resources.Doubt, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2); //绘制问号
                        }
                    }
                    else if (pState[i, j] == 1)  //点开
                    {
                        //绘制背景
                        if (MouseFocus.X == i && MouseFocus.Y == j)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        //绘制数字
                        if (pMine[i, j] > 0)
                        {
                            Brush DrawBrush = new SolidBrush(Color.Blue);   //定义钢笔
                            //各个地雷数目的颜色
                            if (pMine[i, j] == 2)
                                DrawBrush = new SolidBrush(Color.Red);
                            if (pMine[i, j] == 3)
                                DrawBrush = new SolidBrush(Color.Green);
                            if (pMine[i, j] == 4)
                                DrawBrush = new SolidBrush(Color.DarkBlue);
                            if (pMine[i, j] == 5)
                                DrawBrush = new SolidBrush(Color.DarkGray);
                            if (pMine[i, j] == 6)
                                DrawBrush = new SolidBrush(Color.Purple);
                            if (pMine[i, j] == 7)
                                DrawBrush = new SolidBrush(Color.Black);
                            if (pMine[i, j] == 8)
                                DrawBrush = new SolidBrush(Color.DarkRed);
                            SizeF Size = g.MeasureString(pMine[i, j].ToString(), new Font("console", 16));
                            g.DrawString(pMine[i, j].ToString(), new Font("console", 16), DrawBrush, nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);
                         }
                        //绘制地雷
                        if (pMine[i, j] == -1)
                        {
                            g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);       //绘制地雷
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 自动更新窗口大小
        /// </summary>
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;                       //包含窗口标题栏以及上下边框的高度
            int nOffsetY = this.Height - this.ClientSize.Height;                     //包含左右边框的高度
            int nAdditionY = MenuStrip_Main.Height + TableLayoutPanel_Main.Height;   //包含菜单栏以及下方显示信息栏的高度
            this.Width = 12 + 34 * nWidth + nOffsetX;                                //设置窗口高度，34为每个雷区的高度，12为上下总空隙，再加偏移量
            this.Height = 12 + 34 * nHeight + nAdditionY + nOffsetY;                 //设置窗口宽度，同理
            //PaintGame();
            //this.Refresh();
            新游戏NToolStripMenuItem_Click(new object(), new EventArgs());            //调用新建游戏函数
        }

        /// <summary>
        /// 选择对应的游戏等级
        /// </summary>
        private void SelectLevel()
        {
            if (nWidth == 10 && nHeight == 10 && nMineCnt == 10)
            {
                新手BToolStripMenuItem.Checked = true;
                中等iToolStripMenuItem.Checked = false;
                专家EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 16 && nHeight == 16 && nMineCnt == 40)
            {
                新手BToolStripMenuItem.Checked = false;
                中等iToolStripMenuItem.Checked = true;
                专家EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 30 && nHeight == 16 && nMineCnt == 99)
            {
                新手BToolStripMenuItem.Checked = false;
                中等iToolStripMenuItem.Checked = false;
                专家EToolStripMenuItem.Checked = true;
                设置SToolStripMenuItem.Checked = false;
            }
            else
            {
                新手BToolStripMenuItem.Checked = false;
                中等iToolStripMenuItem.Checked = false;
                专家EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = true;
            }
        }

        private void 新手BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10;
            nHeight = 10;
            nMineCnt = 10;
            UpdateSize();
            SelectLevel();
        }

        private void 中等iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16;
            nHeight = 16;
            nMineCnt = 40;
            UpdateSize();
            SelectLevel();
        }

        private void 专家EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 30;
            nHeight = 16;
            nMineCnt = 99;
            UpdateSize();
            SelectLevel();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出游戏？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 系统关于对话框（Win32 API）
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="szApp">标题文本</param>
        /// <param name="szOtherStuff">内容文本</param>
        /// <param name="hIcon">图标句柄</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        private void 关于AToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "Minesweeper", "A minesweeper game using C# language.", this.Icon.Handle);
        }

        private void 标记MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            标记MToolStripMenuItem.Checked = bMark = !bMark;
        }

        private void 音效AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            音效AToolStripMenuItem.Checked = bAudio = !bAudio;
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting Setting = new Form_Setting(this);
            Setting.ShowDialog();
            UpdateSize();
        }

        private void 排行RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Rank Rank = new Form_Rank();
            Rank.ShowDialog();
        }



        private void 新游戏NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清空数组
            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pState, 0, pState.Length);
            //初始化地雷数据
            Random Rand = new Random();
            for (int i = 1; i <= nMineCnt;)     //地雷总数
            {
                //随机地雷坐标
                int x = Rand.Next(nWidth) + 1;
                int y = Rand.Next(nHeight) + 1;
                if (pMine[x, y] != -1)
                {
                    pMine[x, y] = -1;
                    i++;
                }
                MouseFocus.X = 0;       //重置高亮点
                MouseFocus.Y = 0;
             }
            for (int i = 1; i <= nWidth; i++)                       //枚举宽度
            {
                for (int j = 1; j <= nHeight; j++)                  //枚举高度
                {
                    if (pMine[i, j] != -1)                          //不是地雷，显示周围地雷数
                    {
                        for (int k = 0; k < 8; k++)                 //8个方向拓展
                        {
                            if (pMine[i + dx[k], j + dy[k]] == -1)  //找到地雷
                            {
                                pMine[i, j]++;                      //地雷数自增
                            }
                        }
                    }
                }
            }
            Label_Mine.Text = nMineCnt.ToString();         //显示地雷数目
            Label_Timer.Text = "0";                        //计数器清零
            Timer_Main.Enabled = true;                     //启动计时器计时
            bGame = false;                                 //游戏暂未停止
        }

        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 6 || e.Y > 6 + nWidth * 34 || e.Y < 6 + MenuStrip_Main.Height || e.Y > 6 + MenuStrip_Main.Height + nHeight * 34)   //不在地雷区域
            {
                MouseFocus.X = 0;
                MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 + 1;   //获取x位置
                int y = (e.Y - MenuStrip_Main.Height - 6) / 34 + 1;  //获取y位置
                MouseFocus.X = x;             //设置当前高亮点
                MouseFocus.Y = y;
            }
            //PaintGame();                  //重绘雷区
            this.Refresh();
        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            if (bAudio)
            {
                soundTick.Play();        //播放
            }
            Label_Timer.Text = Convert.ToString(Convert.ToInt32(Label_Timer.Text) + 1);   //+1s
        }

        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                bMouseLeft = true;
            if (e.Button == MouseButtons.Right)
                bMouseRight = true;
        }

        private void Form_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseFocus.X == 0 && MouseFocus.Y == 0 || bGame)   //不在雷区或者游戏结束
            {
                return;                     //不作任何处理
            }
            if (bMouseLeft && bMouseRight)  //左右键同时按下
            {
                if (pState[MouseFocus.X, MouseFocus.Y] == 1 && pMine[MouseFocus.X, MouseFocus.Y] > 0)  //为数字区域
                {
                    int nFlagCnt = 0, nDoubtCnt = 0, nSysCnt = pMine[MouseFocus.X, MouseFocus.Y];  //记录红旗数目，问好数目，九宫格地雷数目
                    for (int i = 0; i < 8; i++)
                    {
                        //获取偏移量
                        int x = MouseFocus.X + dx[i];
                        int y = MouseFocus.Y + dy[i];
                        if (pState[x, y] == 2)  //红旗
                        {
                            nFlagCnt++;
                        }
                        if (pState[x, y] == 3)  //红旗
                        {
                            nDoubtCnt++;
                        }
                        if (nFlagCnt == nSysCnt || nFlagCnt + nDoubtCnt == nSysCnt)  //打开九宫格
                        {
                            bool bFlag = OpenMine(MouseFocus.X, MouseFocus.Y);
                            if (!bFlag)  //周围有雷
                            {
                                //结束游戏
                                GameLost();
                            }
                        }
                    }
                }
            }
            else if (bMouseLeft)
            {
                if (pMine[MouseFocus.X, MouseFocus.Y] != -1)
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)
                    {
                        //非地雷，自动打开周围非地雷区域
                        DFS(MouseFocus.X, MouseFocus.Y);
                    }
                }
                else
                {
                    //地雷，game over!
                    GameLost();
                }
            }
            else if (bMouseRight)
            {
                if (bMark)  //可以使用标记
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)  //未点开
                    {
                        if (Convert.ToInt32(Label_Mine.Text) > 0)
                        {
                            pState[MouseFocus.X, MouseFocus.Y] = 2;   //红旗
                            Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) - 1);  //剩余地雷数目-1
                        }
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 2)    //红旗
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 3;   //问号
                        Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) + 1);  //剩余地雷数目+1
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 3)  //问号
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 0;  //未点开
                    }
                }
            }
            this.Refresh();
            GameWin();
            bMouseLeft = bMouseRight = false;
        }

        private void DFS(int sx, int sy)
        {
            pState[sx, sy] = 1;   //访问该点
            for (int i = 0; i < 4; i++)
            {
                //获取相邻点的坐标
                int x = sx + px[i];
                int y = sy + py[i];
                if (x >= 1 && x <= nWidth && y >= 1 && y <= nHeight && pMine[x, y] != -1 && pMine[sx, sy] == 0 && (pState[x, y] == 0 || pState[x, y] == 3))  //不是地雷，处于地雷区域，且未点开，或者标记
                {
                    DFS(x, y);  //访问该点
                }
            }
        }

        private bool OpenMine(int sx, int sy)
        {
            bool bFlag = true;      //默认周围无雷
            for (int i = 0; i < 8; i++)
            {
                //获取偏移量
                int x = MouseFocus.X + dx[i];
                int y = MouseFocus.Y + dy[i];
                if (pState[x, y] == 0)   //问号
                {
                    pState[x, y] = 1;    //打开
                    if (pMine[x, y] != -1) //无雷
                    {
                        DFS(x, y);
                    }
                    if(pMine[x,y] == -1) //有雷
                    {
                        bFlag = false;
                        break;
                    }
                }
            }
            return bFlag;
        }

        private void GameLost()
        {
            for (int i = 1; i < nWidth; i++)
            {
                for (int j = 1; j < nHeight; j++)
                {
                    if (pMine[i, j] == -1 && (pState[i, j] == 0 || pState[i, j] == 3))    //未点开或者标记为问号的地雷
                    {
                        pState[i, j] = 1;    //点开该地雷
                    }
                }
            }
            if (bAudio)
            {
                soundBomb.Play();
            }
            Timer_Main.Enabled = false;     //停用计时器
            bGame = true;
        }

        private void GameWin()
        {
            int nCnt = 0;                   //用户标记红旗数目、问号数目、以及无标记未点开区域总数
            for (int i = 1; i <= nWidth; i++)
            {
                for (int j = 1; j <= nHeight; j++)
                {
                    // (pState[i, j] == 0 || pState[i, j] == 2 || pState[i, j] == 3)    //对应无标记未点开区域、红旗区域、问号区域
                    //存在BUG.仅剩一个格子时点开不管对错都会算胜利,修改如下
                    if (pState[i, j] == 2 && pMine[i, j] == -1)
                    {
                        nCnt++;
                    }
                }
            }
            if(nCnt == nMineCnt)                  //胜利条件
            {
                Timer_Main.Enabled = false;       //关闭计时器
                MessageBox.Show(String.Format("恭喜！你赢啦！ 耗时： {0} 秒", Label_Timer.Text), "提示", MessageBoxButtons.OK);
                //更新记录
                if (nWidth == 10 && nHeight == 10 && nMineCnt == 10)   //初级
                {
                    if (Properties.Settings.Default.Beginner > Convert.ToInt32(Label_Timer.Text))   //更新记录
                    {
                        Properties.Settings.Default.Beginner = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                if (nWidth == 16 && nHeight == 16 && nMineCnt == 40)   //初级
                {
                    if (Properties.Settings.Default.Intermediate > Convert.ToInt32(Label_Timer.Text))   //更新记录
                    {
                        Properties.Settings.Default.Intermediate = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                if (nWidth == 30 && nHeight == 16 && nMineCnt == 99)   //初级
                {
                    if (Properties.Settings.Default.Expert > Convert.ToInt32(Label_Timer.Text))   //更新记录
                    {
                        Properties.Settings.Default.Expert = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                bGame = true;
            }
        }
    }
}
