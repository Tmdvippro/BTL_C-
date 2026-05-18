namespace lab3
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênTốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnKhámRăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuChucNang
            // 
            this.menuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyênTốToolStripMenuItem,
            this.tiềnKhámRăngToolStripMenuItem});
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(113, 29);
            this.menuChucNang.Text = "Chức năng";
            this.menuChucNang.Click += new System.EventHandler(this.chứcToolStripMenuItem_Click);
            // 
            // nguyênTốToolStripMenuItem
            // 
            this.nguyênTốToolStripMenuItem.Name = "nguyênTốToolStripMenuItem";
            this.nguyênTốToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nguyênTốToolStripMenuItem.Text = "Nguyên Tố";
            this.nguyênTốToolStripMenuItem.Click += new System.EventHandler(this.nguyênTốToolStripMenuItem_Click);
            // 
            // tiềnKhámRăngToolStripMenuItem
            // 
            this.tiềnKhámRăngToolStripMenuItem.Name = "tiềnKhámRăngToolStripMenuItem";
            this.tiềnKhámRăngToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tiềnKhámRăngToolStripMenuItem.Text = "Tiền khám răng";
            this.tiềnKhámRăngToolStripMenuItem.Click += new System.EventHandler(this.tiềnKhámRăngToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 135);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem nguyênTốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnKhámRăngToolStripMenuItem;
    }
}

