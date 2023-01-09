namespace TicTacToeSimplified__ACT13_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.R3C3 = new System.Windows.Forms.PictureBox();
            this.R3C2 = new System.Windows.Forms.PictureBox();
            this.R3C1 = new System.Windows.Forms.PictureBox();
            this.R2C3 = new System.Windows.Forms.PictureBox();
            this.R2C2 = new System.Windows.Forms.PictureBox();
            this.R2C1 = new System.Windows.Forms.PictureBox();
            this.R1C3 = new System.Windows.Forms.PictureBox();
            this.R1C2 = new System.Windows.Forms.PictureBox();
            this.R1C1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R3C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // R3C3
            // 
            this.R3C3.Location = new System.Drawing.Point(283, 254);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(100, 92);
            this.R3C3.TabIndex = 9;
            this.R3C3.TabStop = false;
            this.R3C3.Click += new System.EventHandler(this.Mark);
            // 
            // R3C2
            // 
            this.R3C2.Location = new System.Drawing.Point(177, 254);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(100, 92);
            this.R3C2.TabIndex = 8;
            this.R3C2.TabStop = false;
            this.R3C2.Click += new System.EventHandler(this.Mark);
            // 
            // R3C1
            // 
            this.R3C1.Location = new System.Drawing.Point(71, 254);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(100, 92);
            this.R3C1.TabIndex = 7;
            this.R3C1.TabStop = false;
            this.R3C1.Click += new System.EventHandler(this.Mark);
            // 
            // R2C3
            // 
            this.R2C3.Location = new System.Drawing.Point(283, 156);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(100, 92);
            this.R2C3.TabIndex = 6;
            this.R2C3.TabStop = false;
            this.R2C3.Click += new System.EventHandler(this.Mark);
            // 
            // R2C2
            // 
            this.R2C2.Location = new System.Drawing.Point(177, 156);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(100, 92);
            this.R2C2.TabIndex = 5;
            this.R2C2.TabStop = false;
            this.R2C2.Click += new System.EventHandler(this.Mark);
            // 
            // R2C1
            // 
            this.R2C1.Location = new System.Drawing.Point(71, 156);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(100, 92);
            this.R2C1.TabIndex = 4;
            this.R2C1.TabStop = false;
            this.R2C1.Click += new System.EventHandler(this.Mark);
            // 
            // R1C3
            // 
            this.R1C3.Location = new System.Drawing.Point(283, 58);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(100, 92);
            this.R1C3.TabIndex = 3;
            this.R1C3.TabStop = false;
            this.R1C3.Click += new System.EventHandler(this.Mark);
            // 
            // R1C2
            // 
            this.R1C2.Location = new System.Drawing.Point(177, 58);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(100, 92);
            this.R1C2.TabIndex = 2;
            this.R1C2.TabStop = false;
            this.R1C2.Click += new System.EventHandler(this.Mark);
            // 
            // R1C1
            // 
            this.R1C1.Location = new System.Drawing.Point(71, 58);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(100, 92);
            this.R1C1.TabIndex = 1;
            this.R1C1.TabStop = false;
            this.R1C1.Click += new System.EventHandler(this.Mark);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::TicTacToeSimplified__ACT13_.Properties.Resources.Grid;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(71, 58);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(312, 288);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "x9.png");
            this.imageList1.Images.SetKeyName(1, "o7.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 405);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R3C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox R1C1;
        public System.Windows.Forms.PictureBox R1C2;
        public System.Windows.Forms.PictureBox R1C3;
        public System.Windows.Forms.PictureBox R2C1;
        public System.Windows.Forms.PictureBox R2C2;
        public System.Windows.Forms.PictureBox R2C3;
        public System.Windows.Forms.PictureBox R3C1;
        public System.Windows.Forms.PictureBox R3C2;
        public System.Windows.Forms.PictureBox R3C3;
    }
}

