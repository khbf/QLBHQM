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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiemMH = new System.Windows.Forms.Button();
            this.btnLapDonNH = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dsMatHang
            // 
            this.dsMatHang.AllowUserToAddRows = false;
            this.dsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMatHang.Location = new System.Drawing.Point(12, 246);
            this.dsMatHang.Name = "dsMatHang";
            this.dsMatHang.ReadOnly = true;
            this.dsMatHang.Size = new System.Drawing.Size(841, 253);
            this.dsMatHang.TabIndex = 0;
            this.dsMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMatHang_CellClick);
            this.dsMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMatHang_CellContentClick);
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
            this.txtTenMH.Size = new System.Drawing.Size(471, 20);
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
            this.cbbNCC.Size = new System.Drawing.Size(375, 21);
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
            this.txtLoaiMH.Size = new System.Drawing.Size(375, 20);
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
            this.txtSoLuongTon.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongTon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng hàng tối thiểu";
            // 
            // txtSoLuongHangToiThieu
            // 
            this.txtSoLuongHangToiThieu.Location = new System.Drawing.Point(380, 152);
            this.txtSoLuongHangToiThieu.Name = "txtSoLuongHangToiThieu";
            this.txtSoLuongHangToiThieu.Size = new System.Drawing.Size(100, 20);
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
            this.btnThemMH.Location = new System.Drawing.Point(622, 51);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(95, 46);
            this.btnThemMH.TabIndex = 14;
            this.btnThemMH.Text = "THÊM";
            this.btnThemMH.UseVisualStyleBackColor = true;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(622, 114);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(95, 47);
            this.btnXoaMH.TabIndex = 15;
            this.btnXoaMH.Text = "XÓA";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatMH
            // 
            this.btnCapNhatMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMH.Location = new System.Drawing.Point(732, 51);
            this.btnCapNhatMH.Name = "btnCapNhatMH";
            this.btnCapNhatMH.Size = new System.Drawing.Size(107, 46);
            this.btnCapNhatMH.TabIndex = 16;
            this.btnCapNhatMH.Text = "CẬP NHẬT";
            this.btnCapNhatMH.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnTimKiemMH
            // 
            this.btnTimKiemMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMH.Location = new System.Drawing.Point(327, 207);
            this.btnTimKiemMH.Name = "btnTimKiemMH";
            this.btnTimKiemMH.Size = new System.Drawing.Size(87, 33);
            this.btnTimKiemMH.TabIndex = 18;
            this.btnTimKiemMH.Text = "TÌM KIẾM";
            this.btnTimKiemMH.UseVisualStyleBackColor = true;
            // 
            // btnLapDonNH
            // 
            this.btnLapDonNH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapDonNH.Location = new System.Drawing.Point(735, 114);
            this.btnLapDonNH.Name = "btnLapDonNH";
            this.btnLapDonNH.Size = new System.Drawing.Size(104, 47);
            this.btnLapDonNH.TabIndex = 19;
            this.btnLapDonNH.Text = "LẬP ĐƠN NHẬP HÀNG";
            this.btnLapDonNH.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nhập từ khóa";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(766, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // MHQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 511);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLapDonNH);
            this.Controls.Add(this.btnTimKiemMH);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiemMH;
        private System.Windows.Forms.Button btnLapDonNH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
    }
}