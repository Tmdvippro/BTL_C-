namespace lab3
{
    partial class SNT
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
            this.lbNhapSo = new System.Windows.Forms.Label();
            this.lbNT = new System.Windows.Forms.Label();
            this.lbCP = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lbHoanChinh = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhapSo
            // 
            this.lbNhapSo.AutoSize = true;
            this.lbNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapSo.ForeColor = System.Drawing.Color.Red;
            this.lbNhapSo.Location = new System.Drawing.Point(23, 39);
            this.lbNhapSo.Name = "lbNhapSo";
            this.lbNhapSo.Size = new System.Drawing.Size(117, 26);
            this.lbNhapSo.TabIndex = 0;
            this.lbNhapSo.Text = "Nhập số n ";
            this.lbNhapSo.Click += new System.EventHandler(this.lbNhapSo_Click);
            // 
            // lbNT
            // 
            this.lbNT.AutoSize = true;
            this.lbNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNT.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNT.Location = new System.Drawing.Point(24, 95);
            this.lbNT.Name = "lbNT";
            this.lbNT.Size = new System.Drawing.Size(240, 22);
            this.lbNT.TabIndex = 1;
            this.lbNT.Text = "Các số nguyên tố nhỏ hơn n:";
            this.lbNT.Click += new System.EventHandler(this.lbNT_Click);
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCP.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCP.Location = new System.Drawing.Point(24, 133);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(269, 22);
            this.lbCP.TabIndex = 2;
            this.lbCP.Text = "Các số chính phương nhỏ hơn n:";
            this.lbCP.Click += new System.EventHandler(this.lbCP_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(474, 39);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(94, 38);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lbHoanChinh
            // 
            this.lbHoanChinh.AutoSize = true;
            this.lbHoanChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoanChinh.ForeColor = System.Drawing.Color.DarkRed;
            this.lbHoanChinh.Location = new System.Drawing.Point(24, 171);
            this.lbHoanChinh.Name = "lbHoanChinh";
            this.lbHoanChinh.Size = new System.Drawing.Size(249, 22);
            this.lbHoanChinh.TabIndex = 4;
            this.lbHoanChinh.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            this.lbHoanChinh.Click += new System.EventHandler(this.lbHoanChinh_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(167, 39);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(204, 26);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged_1);
            // 
            // SNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 287);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lbHoanChinh);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lbCP);
            this.Controls.Add(this.lbNT);
            this.Controls.Add(this.lbNhapSo);
            this.Name = "SNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chuong trinh nhap so";
            this.Load += new System.EventHandler(this.SNT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapSo;
        private System.Windows.Forms.Label lbNT;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lbHoanChinh;
        private System.Windows.Forms.TextBox txtN;
    }
}
