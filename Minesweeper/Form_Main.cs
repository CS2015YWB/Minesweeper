using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form_Main : Form
    {
        int nWidth;     //雷区宽度
        int nHeight;    //雷区高度
        int nMineCnt;   //地雷的数目
        public Form_Main()
        {
            InitializeComponent();
        }

        private void SetGame(int Width, int Height, int MineCnt)
        {
            nWidth = Width;
            nHeight = Height;
            nMineCnt = MineCnt;
        }

        private void 中等iToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
