namespace GUI_QuanLy
{
    partial class MHQuanLyMatHang
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
            this.dsMatHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongHangToiThieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnCapNhatMH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbNVBanHangQuanLyMH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTKTenMH = new System.Windows.Forms.TextBox();
            this.cbbTKTheoNV = new System.Windows.Forms.ComboBox();
            this.radioButtonTheoNV = new System.Windows.Forms.RadioButton();
            this.cbbTKTheoNCC = new System.Windows.Forms.ComboBox();
            this.radioButtonTKTheoNCC = new System.Windows.Forms.RadioButton();
            this.radioButtonLayTatCa = new System.Windows.Forms.RadioButton();
            this.radioButtonTKTheoTen = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsMatHang
            // 
            this.dsMatHang.AllowUserToAddRows = false;
            this.dsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMatHang.Location = new System.Drawing.Point(11, 313);
            this.dsMatHang.Name = "dsMatHang";
            this.dsMatHang.ReadOnly = true;
            this.dsMatHang.Size = new System.Drawing.Size(875, 244);
            this.dsMatHang.TabIndex = 0;
            this.dsMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMatHang_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên mặt hàng";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(105, 51);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(497, 20);
            this.txtTenMH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(105, 88);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(497, 21);
            this.cbbNCC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại mặt hàng";
            // 
            // txtLoaiMH
            // 
            this.txtLoaiMH.Location = new System.Drawing.Point(105, 121);
            this.txtLoaiMH.Multiline = true;
            this.txtLoaiMH.Name = "txtLoaiMH";
            this.txtLoaiMH.Size = new System.Drawing.Size(497, 20);
            this.txtLoaiMH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng tồn";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(105, 152);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuongTon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng hàng tối thiểu";
            // 
            // txtSoLuongHangToiThieu
            // 
            this.txtSoLuongHangToiThieu.Location = new System.Drawing.Point(443, 152);
            this.txtSoLuongHangToiThieu.Name = "txtSoLuongHangToiThieu";
            this.txtSoLuongHangToiThieu.Size = new System.Drawing.Size(159, 20);
            this.txtSoLuongHangToiThieu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(105, 182);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(168, 20);
            this.txtGiaTien.TabIndex = 13;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Location = new System.Drawing.Point(660, 92);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(95, 46);
            this.btnThemMH.TabIndex = 14;
            this.btnThemMH.Text = "THÊM";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(789, 92);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(95, 47);
            this.btnXoaMH.TabIndex = 15;
            this.btnXoaMH.Text = "XÓA";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnCapNhatMH
            // 
            this.btnCapNhatMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMH.Location = new System.Drawing.Point(660, 157);
            this.btnCapNhatMH.Name = "btnCapNhatMH";
            this.btnCapNhatMH.Size = new System.Drawing.Size(95, 46);
            this.btnCapNhatMH.TabIndex = 16;
            this.btnCapNhatMH.Text = "CẬP NHẬT";
            this.btnCapNhatMH.UseVisualStyleBackColor = true;
            this.btnCapNhatMH.Click += new System.EventHandler(this.btnCapNhatMH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(789, 157);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 46);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nhân viên quản lý";
            // 
            // cbbNVBanHangQuanLyMH
            // 
            this.cbbNVBanHangQuanLyMH.FormattingEnabled = true;
            this.cbbNVBanHangQuanLyMH.Location = new System.Drawing.Point(408, 182);
            this.cbbNVBanHangQuanLyMH.Name = "cbbNVBanHangQuanLyMH";
            this.cbbNVBanHangQuanLyMH.Size = new System.Drawing.Size(194, 21);
            this.cbbNVBanHangQuanLyMH.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(657, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã mặt hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(747, 51);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(137, 21);
            this.txtMaMH.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTKTenMH);
            this.groupBox2.Controls.Add(this.cbbTKTheoNV);
            this.groupBox2.Controls.Add(this.radioButtonTheoNV);
            this.groupBox2.Controls.Add(this.cbbTKTheoNCC);
            this.groupBox2.Controls.Add(this.radioButtonTKTheoNCC);
            this.groupBox2.Controls.Add(this.radioButtonLayTatCa);
            this.groupBox2.Controls.Add(this.radioButtonTKTheoTen);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 93);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTKTenMH
            // 
            this.txtTKTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKTenMH.Location = new System.Drawing.Point(157, 26);
            this.txtTKTenMH.Multiline = true;
            this.txtTKTenMH.Name = "txtTKTenMH";
            this.txtTKTenMH.Size = new System.Drawing.Size(208, 20);
            this.txtTKTenMH.TabIndex = 30;
            // 
            // cbbTKTheoNV
            // 
            this.cbbTKTheoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTKTheoNV.FormattingEnabled = true;
            this.cbbTKTheoNV.Location = new System.Drawing.Point(537, 57);
            this.cbbTKTheoNV.Name = "cbbTKTheoNV";
            this.cbbTKTheoNV.Size = new System.Drawing.Size(189, 21);
            this.cbbTKTheoNV.TabIndex = 29;
            // 
            // radioButtonTheoNV
            // 
            this.radioButtonTheoNV.AutoSize = true;
            this.radioButtonTheoNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTheoNV.Location = new System.Drawing.Point(405, 56);
            this.radioButtonTheoNV.Name = "radioButtonTheoNV";
            this.radioButtonTheoNV.Size = new System.Drawing.Size(122, 20);
            this.radioButtonTheoNV.TabIndex = 27;
            this.radioButtonTheoNV.TabStop = true;
            this.radioButtonTheoNV.Text = "Theo NV quản lý";
            this.radioButtonTheoNV.UseVisualStyleBackColor = true;
            // 
            // cbbTKTheoNCC
            // 
            this.cbbTKTheoNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTKTheoNCC.FormattingEnabled = true;
            this.cbbTKTheoNCC.Location = new System.Drawing.Point(537, 25);
            this.cbbTKTheoNCC.Name = "cbbTKTheoNCC";
            this.cbbTKTheoNCC.Size = new System.Drawing.Size(189, 21);
            this.cbbTKTheoNCC.TabIndex = 26;
            // 
            // radioButtonTKTheoNCC
            // 
            this.radioButtonTKTheoNCC.AutoSize = true;
            this.radioButtonTKTheoNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTKTheoNCC.Location = new System.Drawing.Point(405, 29);
            this.radioButtonTKTheoNCC.Name = "radioButtonTKTheoNCC";
            this.radioButtonTKTheoNCC.Size = new System.Drawing.Size(85, 20);
            this.radioButtonTKTheoNCC.TabIndex = 25;
            this.radioButtonTKTheoNCC.TabStop = true;
            this.radioButtonTKTheoNCC.Text = "Theo NCC";
            this.radioButtonTKTheoNCC.UseVisualStyleBackColor = true;
            // 
            // radioButtonLayTatCa
            // 
            this.radioButtonLayTatCa.AutoSize = true;
            this.radioButtonLayTatCa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLayTatCa.Location = new System.Drawing.Point(63, 56);
            this.radioButtonLayTatCa.Name = "radioButtonLayTatCa";
            this.radioButtonLayTatCa.Size = new System.Drawing.Size(84, 20);
            this.radioButtonLayTatCa.TabIndex = 23;
            this.radioButtonLayTatCa.TabStop = true;
            this.radioButtonLayTatCa.Text = "Lấy tất cả";
            this.radioButtonLayTatCa.UseVisualStyleBackColor = true;
            // 
            // radioButtonTKTheoTen
            // 
            this.radioButtonTKTheoTen.AutoSize = true;
            this.radioButtonTKTheoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTKTheoTen.Location = new System.Drawing.Point(63, 25);
            this.radioButtonTKTheoTen.Name = "radioButtonTKTheoTen";
            this.radioButtonTKTheoTen.Size = new System.Drawing.Size(76, 20);
            this.radioButtonTKTheoTen.TabIndex = 21;
            this.radioButtonTKTheoTen.TabStop = true;
            this.radioButtonTKTheoTen.Text = "Theo tên";
            this.radioButtonTKTheoTen.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(774, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 39);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // MHQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbNVBanHangQuanLyMH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhatMH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoLuongHangToiThieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoaiMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsMatHang);
            this.Name = "MHQuanLyMatHang";
            this.Text = "QUẢN LÝ MẶT HÀNG";
            this.Load += new System.EventHandler(this.MHQuanLyMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaiMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuongHangToiThieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnCapNhatMH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbNVBanHangQuanLyMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTKTenMH;
        private System.Windows.Forms.ComboBox cbbTKTheoNV;
        private System.Windows.Forms.RadioButton radioButtonTheoNV;
        private System.Windows.Forms.ComboBox cbbTKTheoNCC;
        private System.Windows.Forms.RadioButton radioButtonTKTheoNCC;
        private System.Windows.Forms.RadioButton radioButtonLayTatCa;
        private System.Windows.Forms.RadioButton radioButtonTKTheoTen;
        private System.Windows.Forms.Button btnTimKiem;
    }
}