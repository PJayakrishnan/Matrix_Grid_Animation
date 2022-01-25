using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Grid
{
    public partial class matrix_grid_Form1 : Form
    {
        public int noOfGrid;
        public const int StartPosX = 150;
        public const int StartPosY = 150;
        public const int gridSize = 40;
        public bool startButtonPressed = false;
        public bool pauseButtonPressed = false;
        public Thread thread;

        public matrix_grid_Form1()
        {
            InitializeComponent();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noOfGrid = 3;
            this.Invalidate();
        }

        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)//4x4 selection
        {
            noOfGrid = 4;
            this.Invalidate();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noOfGrid = 5;
            this.Invalidate();
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noOfGrid = 6;
            this.Invalidate();
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noOfGrid = 7;
            this.Invalidate();
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noOfGrid = 8;
            this.Invalidate();
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            startButtonPressed = true;
            pauseButtonPressed = false;
            thread.Start();
        }
        private void pause_button_Click(object sender, EventArgs e)
        {
            pauseButtonPressed = true;
            startButtonPressed = false;
        }

        private void resume_button_Click(object sender, EventArgs e)
        {
            startButtonPressed = true;
            pauseButtonPressed = false;
        }
        private void OnPaint(object sender, EventArgs e)
        {
                thread = new Thread(new ThreadStart(GridDrawing));
        }
        private void GridDrawing()
        {
            Graphics graphics = CreateGraphics();
            Pen patternPen = new Pen(Brushes.Black)
            {
                Width = 3
            };
            while (true)
            {
                while (startButtonPressed == true && pauseButtonPressed == false)
                {
                    graphics.Clear(Color.White);
                    for (int k = 2; k <= noOfGrid && startButtonPressed == true && pauseButtonPressed == false; k++)
                    {
                        int X = StartPosX;
                        int Y = StartPosY;
                        int x = StartPosX;
                        int y = StartPosY;
                        for (int i = 0; i <= k && startButtonPressed == true && pauseButtonPressed == false; i++)
                        {
                            graphics.DrawLine(patternPen, X, Y, X + (gridSize * k), Y);
                            Y += gridSize;
                            graphics.DrawLine(patternPen, x, y, x, y + (gridSize * k));
                            x += gridSize;
                        }
                        Thread.Sleep(1000);
                    }
                }
            }
        }   
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)//unwanted
        {

        }

        private void matrix_grid_Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (startButtonPressed == true)
            {
                thread.Abort();
            }
        }
    }
}
