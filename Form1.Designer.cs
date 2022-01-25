namespace Matrix_Grid
{
    partial class matrix_grid_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(matrix_grid_Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.start_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pause_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.resume_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.start_button,
            this.toolStripSeparator3,
            this.pause_button,
            this.toolStripSeparator4,
            this.resume_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x3ToolStripMenuItem1,
            this.x5ToolStripMenuItem,
            this.x6ToolStripMenuItem,
            this.x7ToolStripMenuItem,
            this.x8ToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 70);
            this.toolStripDropDownButton1.Text = "SIZE";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton1.ToolTipText = "SELECT SIZE";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.x3ToolStripMenuItem.Text = "3X3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem1
            // 
            this.x3ToolStripMenuItem1.Name = "x3ToolStripMenuItem1";
            this.x3ToolStripMenuItem1.Size = new System.Drawing.Size(119, 26);
            this.x3ToolStripMenuItem1.Text = "4X4";
            this.x3ToolStripMenuItem1.Click += new System.EventHandler(this.x3ToolStripMenuItem1_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.x5ToolStripMenuItem.Text = "5X5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.x6ToolStripMenuItem.Text = "6X6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            // 
            // x7ToolStripMenuItem
            // 
            this.x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
            this.x7ToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.x7ToolStripMenuItem.Text = "7X7";
            this.x7ToolStripMenuItem.Click += new System.EventHandler(this.x7ToolStripMenuItem_Click);
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.x8ToolStripMenuItem.Text = "8X8";
            this.x8ToolStripMenuItem.Click += new System.EventHandler(this.x8ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // start_button
            // 
            this.start_button.AutoSize = false;
            this.start_button.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Image = ((System.Drawing.Image)(resources.GetObject("start_button.Image")));
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(80, 70);
            this.start_button.Text = "START";
            this.start_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // pause_button
            // 
            this.pause_button.AutoSize = false;
            this.pause_button.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_button.Image = ((System.Drawing.Image)(resources.GetObject("pause_button.Image")));
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(80, 70);
            this.pause_button.Text = "PAUSE";
            this.pause_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.Gray;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 73);
            // 
            // resume_button
            // 
            this.resume_button.AutoSize = false;
            this.resume_button.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume_button.Image = ((System.Drawing.Image)(resources.GetObject("resume_button.Image")));
            this.resume_button.Name = "resume_button";
            this.resume_button.Size = new System.Drawing.Size(80, 70);
            this.resume_button.Text = "RESUME";
            this.resume_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resume_button.Click += new System.EventHandler(this.resume_button_Click);
            // 
            // matrix_grid_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 650);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "matrix_grid_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATRIX GRID ANIMATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.matrix_grid_Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton start_button;
        private System.Windows.Forms.ToolStripButton pause_button;
        private System.Windows.Forms.ToolStripButton resume_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

