namespace lab3
{
    partial class KR
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
            this.lbKH = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbBangGia = new System.Windows.Forms.Label();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.cbChupHinh = new System.Windows.Forms.CheckBox();
            this.cbLayCao = new System.Windows.Forms.CheckBox();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.lbHanRang = new System.Windows.Forms.Label();
            this.lbTienCV = new System.Windows.Forms.Label();
            this.lbTienTT = new System.Windows.Forms.Label();
            this.lbCH = new System.Windows.Forms.Label();
            this.lbLC = new System.Windows.Forms.Label();
            this.lbHR = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.Location = new System.Drawing.Point(22, 20);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(195, 30);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "Tên khách hàng";
            this.lbKH.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(232, 21);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(196, 26);
            this.txtTen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lbHR);
            this.panel1.Controls.Add(this.lbLC);
            this.panel1.Controls.Add(this.lbCH);
            this.panel1.Controls.Add(this.lbTienTT);
            this.panel1.Controls.Add(this.lbTienCV);
            this.panel1.Controls.Add(this.lbHanRang);
            this.panel1.Controls.Add(this.numHanRang);
            this.panel1.Controls.Add(this.cbLayCao);
            this.panel1.Controls.Add(this.cbChupHinh);
            this.panel1.Controls.Add(this.cbTayTrang);
            this.panel1.Controls.Add(this.cbCaoVoi);
            this.panel1.Controls.Add(this.lbBangGia);
            this.panel1.Location = new System.Drawing.Point(27, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 228);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(47, 359);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(148, 40);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(283, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbBangGia
            // 
            this.lbBangGia.AutoSize = true;
            this.lbBangGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangGia.Location = new System.Drawing.Point(5, 0);
            this.lbBangGia.Name = "lbBangGia";
            this.lbBangGia.Size = new System.Drawing.Size(108, 29);
            this.lbBangGia.TabIndex = 0;
            this.lbBangGia.Text = "Bảng giá";
            this.lbBangGia.Click += new System.EventHandler(this.lbBangGia_Click);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaoVoi.Location = new System.Drawing.Point(8, 44);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(112, 30);
            this.cbCaoVoi.TabIndex = 1;
            this.cbCaoVoi.Text = "Cạo vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTayTrang.Location = new System.Drawing.Point(8, 79);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(128, 30);
            this.cbTayTrang.TabIndex = 2;
            this.cbTayTrang.Text = "Tẩy trắng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            // 
            // cbChupHinh
            // 
            this.cbChupHinh.AutoSize = true;
            this.cbChupHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChupHinh.Location = new System.Drawing.Point(8, 114);
            this.cbChupHinh.Name = "cbChupHinh";
            this.cbChupHinh.Size = new System.Drawing.Size(137, 30);
            this.cbChupHinh.TabIndex = 3;
            this.cbChupHinh.Text = "Chụp hình";
            this.cbChupHinh.UseVisualStyleBackColor = true;
            this.cbChupHinh.CheckedChanged += new System.EventHandler(this.cbChupHinh_CheckedChanged);
            // 
            // cbLayCao
            // 
            this.cbLayCao.AutoSize = true;
            this.cbLayCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayCao.Location = new System.Drawing.Point(8, 149);
            this.cbLayCao.Name = "cbLayCao";
            this.cbLayCao.Size = new System.Drawing.Size(114, 30);
            this.cbLayCao.TabIndex = 4;
            this.cbLayCao.Text = "Lấy cao";
            this.cbLayCao.UseVisualStyleBackColor = true;
            this.cbLayCao.CheckedChanged += new System.EventHandler(this.cbLayCao_CheckedChanged);
            // 
            // numHanRang
            // 
            this.numHanRang.Location = new System.Drawing.Point(116, 181);
            this.numHanRang.Name = "numHanRang";
            this.numHanRang.Size = new System.Drawing.Size(52, 26);
            this.numHanRang.TabIndex = 5;
            this.numHanRang.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbHanRang
            // 
            this.lbHanRang.AutoSize = true;
            this.lbHanRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanRang.Location = new System.Drawing.Point(9, 181);
            this.lbHanRang.Name = "lbHanRang";
            this.lbHanRang.Size = new System.Drawing.Size(101, 26);
            this.lbHanRang.TabIndex = 6;
            this.lbHanRang.Text = "Hàn răng";
            this.lbHanRang.Click += new System.EventHandler(this.lbHanRang_Click);
            // 
            // lbTienCV
            // 
            this.lbTienCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienCV.Location = new System.Drawing.Point(255, 45);
            this.lbTienCV.Name = "lbTienCV";
            this.lbTienCV.Size = new System.Drawing.Size(143, 29);
            this.lbTienCV.TabIndex = 0;
            this.lbTienCV.Text = "100000 VNĐ";
            // 
            // lbTienTT
            // 
            this.lbTienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienTT.Location = new System.Drawing.Point(232, 80);
            this.lbTienTT.Name = "lbTienTT";
            this.lbTienTT.Size = new System.Drawing.Size(172, 32);
            this.lbTienTT.TabIndex = 7;
            this.lbTienTT.Text = "1 200 000 VNĐ";
            // 
            // lbCH
            // 
            this.lbCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCH.Location = new System.Drawing.Point(251, 115);
            this.lbCH.Name = "lbCH";
            this.lbCH.Size = new System.Drawing.Size(147, 31);
            this.lbCH.TabIndex = 8;
            this.lbCH.Text = "150 000 VNĐ";
            // 
            // lbLC
            // 
            this.lbLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLC.Location = new System.Drawing.Point(251, 150);
            this.lbLC.Name = "lbLC";
            this.lbLC.Size = new System.Drawing.Size(153, 31);
            this.lbLC.TabIndex = 9;
            this.lbLC.Text = "100 000 VNĐ";
            // 
            // lbHR
            // 
            this.lbHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHR.Location = new System.Drawing.Point(213, 181);
            this.lbHR.Name = "lbHR";
            this.lbHR.Size = new System.Drawing.Size(185, 29);
            this.lbHR.TabIndex = 10;
            this.lbHR.Text = "90 000 VNĐ / cái";
            this.lbHR.Click += new System.EventHandler(this.lbHR_Click);
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(196, 320);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(228, 26);
            this.txtTong.TabIndex = 7;
            this.txtTong.TextChanged += new System.EventHandler(this.txtTong_TextChanged);
            // 
            // KR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(456, 405);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbKH);
            this.Name = "KR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền khám răng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbBangGia;
        private System.Windows.Forms.CheckBox cbLayCao;
        private System.Windows.Forms.CheckBox cbChupHinh;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.Label lbHanRang;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.Label lbHR;
        private System.Windows.Forms.Label lbLC;
        private System.Windows.Forms.Label lbCH;
        private System.Windows.Forms.Label lbTienTT;
        private System.Windows.Forms.Label lbTienCV;
        private System.Windows.Forms.TextBox txtTong;
    }
}
