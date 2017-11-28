namespace Minesweeper
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.游戏GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新游戏NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.新手BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中等iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专家EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.标记MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.排行RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox_Mine = new System.Windows.Forms.PictureBox();
            this.PictureBox_Timer = new System.Windows.Forms.PictureBox();
            this.Label_Mine = new System.Windows.Forms.Label();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip_Main.SuspendLayout();
            this.TableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏GToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(527, 25);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // 游戏GToolStripMenuItem
            // 
            this.游戏GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新游戏NToolStripMenuItem,
            this.toolStripSeparator1,
            this.新手BToolStripMenuItem,
            this.中等iToolStripMenuItem,
            this.专家EToolStripMenuItem,
            this.toolStripSeparator2,
            this.设置SToolStripMenuItem,
            this.toolStripSeparator3,
            this.标记MToolStripMenuItem,
            this.音效AToolStripMenuItem,
            this.toolStripSeparator4,
            this.排行RToolStripMenuItem,
            this.toolStripSeparator5,
            this.退出XToolStripMenuItem});
            this.游戏GToolStripMenuItem.Name = "游戏GToolStripMenuItem";
            this.游戏GToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.游戏GToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 新游戏NToolStripMenuItem
            // 
            this.新游戏NToolStripMenuItem.Name = "新游戏NToolStripMenuItem";
            this.新游戏NToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.新游戏NToolStripMenuItem.Text = "新游戏(&N)";
            this.新游戏NToolStripMenuItem.Click += new System.EventHandler(this.新游戏NToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // 新手BToolStripMenuItem
            // 
            this.新手BToolStripMenuItem.Name = "新手BToolStripMenuItem";
            this.新手BToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.新手BToolStripMenuItem.Text = "新手(&B)";
            this.新手BToolStripMenuItem.Click += new System.EventHandler(this.新手BToolStripMenuItem_Click);
            // 
            // 中等iToolStripMenuItem
            // 
            this.中等iToolStripMenuItem.Name = "中等iToolStripMenuItem";
            this.中等iToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.中等iToolStripMenuItem.Text = "中等(&I)";
            this.中等iToolStripMenuItem.Click += new System.EventHandler(this.中等iToolStripMenuItem_Click);
            // 
            // 专家EToolStripMenuItem
            // 
            this.专家EToolStripMenuItem.Name = "专家EToolStripMenuItem";
            this.专家EToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.专家EToolStripMenuItem.Text = "专家(&E)";
            this.专家EToolStripMenuItem.Click += new System.EventHandler(this.专家EToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // 标记MToolStripMenuItem
            // 
            this.标记MToolStripMenuItem.Name = "标记MToolStripMenuItem";
            this.标记MToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.标记MToolStripMenuItem.Text = "标记(&M)";
            this.标记MToolStripMenuItem.Click += new System.EventHandler(this.标记MToolStripMenuItem_Click);
            // 
            // 音效AToolStripMenuItem
            // 
            this.音效AToolStripMenuItem.Name = "音效AToolStripMenuItem";
            this.音效AToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.音效AToolStripMenuItem.Text = "音效(&M)";
            this.音效AToolStripMenuItem.Click += new System.EventHandler(this.音效AToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // 排行RToolStripMenuItem
            // 
            this.排行RToolStripMenuItem.Name = "排行RToolStripMenuItem";
            this.排行RToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.排行RToolStripMenuItem.Text = "排行(&R)";
            this.排行RToolStripMenuItem.Click += new System.EventHandler(this.排行RToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.退出XToolStripMenuItem.Text = "退出(X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click_1);
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 9;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Mine, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Timer, 7, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Mine, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Timer, 5, 0);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 355);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 1;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(527, 48);
            this.TableLayoutPanel_Main.TabIndex = 1;
            // 
            // PictureBox_Mine
            // 
            this.PictureBox_Mine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Mine.BackgroundImage")));
            this.PictureBox_Mine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Mine.Location = new System.Drawing.Point(35, 3);
            this.PictureBox_Mine.Name = "PictureBox_Mine";
            this.PictureBox_Mine.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Mine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Mine.TabIndex = 0;
            this.PictureBox_Mine.TabStop = false;
            // 
            // PictureBox_Timer
            // 
            this.PictureBox_Timer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Timer.BackgroundImage")));
            this.PictureBox_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Timer.Location = new System.Drawing.Point(449, 3);
            this.PictureBox_Timer.Name = "PictureBox_Timer";
            this.PictureBox_Timer.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Timer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Timer.TabIndex = 1;
            this.PictureBox_Timer.TabStop = false;
            // 
            // Label_Mine
            // 
            this.Label_Mine.AutoSize = true;
            this.Label_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Mine.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mine.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Mine.Location = new System.Drawing.Point(99, 0);
            this.Label_Mine.Name = "Label_Mine";
            this.Label_Mine.Size = new System.Drawing.Size(145, 48);
            this.Label_Mine.TabIndex = 2;
            this.Label_Mine.Text = "Label_Mine";
            this.Label_Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Timer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Timer.Location = new System.Drawing.Point(282, 0);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(145, 48);
            this.Label_Timer.TabIndex = 3;
            this.Label_Timer.Text = "Label_Timer";
            this.Label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            this.Timer_Main.Tick += new System.EventHandler(this.Timer_Main_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 403);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扫雷";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseUp);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 游戏GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新游戏NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 新手BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中等iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专家EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 标记MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音效AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 排行RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.PictureBox PictureBox_Mine;
        private System.Windows.Forms.PictureBox PictureBox_Timer;
        private System.Windows.Forms.Label Label_Mine;
        private System.Windows.Forms.Label Label_Timer;
        private System.Windows.Forms.Timer Timer_Main;
        private object 音效MToolStripMenuItem;
    }
}

