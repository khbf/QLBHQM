namespace GUI_QuanLy
{
    partial class MHDonGiaoHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dsDonHang = new System.Windows.Forms.DataGridView();
            this.radioButtonTrangThai = new System.Windows.Forms.RadioButton();
            this.btnTimKiemDH = new System.Windows.Forms.Button();
            this.radioButtonDiaChi = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.groupBoxXemDon = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.radioButtonDSDH = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBoxCapNhat = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapNhatTT = new System.Windows.Forms.TextBox();
            this.txtMaDonCapNhat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsDonHang)).BeginInit();
            this.groupBoxXemDon.SuspendLayout();
            this.groupBoxCapNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // dsDonHang
            // 
            this.dsDonHang.AllowUserToAddRows = false;
            this.dsDonHang.AllowUserToDeleteRows = false;
            this.dsDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDonHang.Location = new System.Drawing.Point(41, 290);
            this.dsDonHang.Name = "dsDonHang";
            this.dsDonHang.ReadOnly = true;
            this.dsDonHang.Size = new System.Drawing.Size(721, 126);
            this.dsDonHang.TabIndex = 2;
            // 
            // radioButtonTrangThai
            // 
            this.radioButtonTrangThai.AutoSize = true;
            this.radioButtonTrangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrangThai.Location = new System.Drawing.Point(15, 34);
            this.radioButtonTrangThai.Name = "radioButtonTrangThai";
            this.radioButtonTrangThai.Size = new System.Drawing.Size(180, 25);
            this.radioButtonTrangThai.TabIndex = 3;
            this.radioButtonTrangThai.TabStop = true;
            this.radioButtonTrangThai.Text = "Trạng thái đơn hàng:";
            this.radioButtonTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemDH
            // 
            this.btnTimKiemDH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDH.Location = new System.Drawing.Point(277, 134);
            this.btnTimKiemDH.Name = "btnTimKiemDH";
            this.btnTimKiemDH.Size = new System.Drawing.Size(99, 47);
            this.btnTimKiemDH.TabIndex = 4;
            this.btnTimKiemDH.Text = "Tìm kiếm";
            this.btnTimKiemDH.UseVisualStyleBackColor = true;
            this.btnTimKiemDH.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonDiaChi
            // 
            this.radioButtonDiaChi.AutoSize = true;
            this.radioButtonDiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDiaChi.Location = new System.Drawing.Point(15, 67);
            this.radioButtonDiaChi.Name = "radioButtonDiaChi";
            this.radioButtonDiaChi.Size = new System.Drawing.Size(163, 25);
            this.radioButtonDiaChi.TabIndex = 6;
            this.radioButtonDiaChi.TabStop = true;
            this.radioButtonDiaChi.Text = "Địa chỉ giao hàng:";
            this.radioButtonDiaChi.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(196, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 29);
            this.txtDiaChi.TabIndex = 7;
            // 
            // groupBoxXemDon
            // 
            this.groupBoxXemDon.Controls.Add(this.txtTrangThai);
            this.groupBoxXemDon.Controls.Add(this.radioButtonDSDH);
            this.groupBoxXemDon.Controls.Add(this.txtDiaChi);
            this.groupBoxXemDon.Controls.Add(this.radioButtonDiaChi);
            this.groupBoxXemDon.Controls.Add(this.btnTimKiemDH);
            this.groupBoxXemDon.Controls.Add(this.radioButtonTrangThai);
            this.groupBoxXemDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemDon.Location = new System.Drawing.Point(41, 53);
            this.groupBoxXemDon.Name = "groupBoxXemDon";
            this.groupBoxXemDon.Size = new System.Drawing.Size(388, 193);
            this.groupBoxXemDon.TabIndex = 3;
            this.groupBoxXemDon.TabStop = false;
            this.groupBoxXemDon.Text = "Xem đơn hàng";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(196, 28);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(100, 29);
            this.txtTrangThai.TabIndex = 9;
            // 
            // radioButtonDSDH
            // 
            this.radioButtonDSDH.AutoSize = true;
            this.radioButtonDSDH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDSDH.Location = new System.Drawing.Point(15, 100);
            this.radioButtonDSDH.Name = "radioButtonDSDH";
            this.radioButtonDSDH.Size = new System.Drawing.Size(199, 25);
            this.radioButtonDSDH.TabIndex = 8;
            this.radioButtonDSDH.TabStop = true;
            this.radioButtonDSDH.Text = "Xuất toàn bộ đơn hàng";
            this.radioButtonDSDH.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(673, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(208, 112);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 47);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBoxCapNhat
            // 
            this.groupBoxCapNhat.Controls.Add(this.label4);
            this.groupBoxCapNhat.Controls.Add(this.txtCapNhatTT);
            this.groupBoxCapNhat.Controls.Add(this.txtMaDonCapNhat);
            this.groupBoxCapNhat.Controls.Add(this.label3);
            this.groupBoxCapNhat.Controls.Add(this.label2);
            this.groupBoxCapNhat.Controls.Add(this.btnCapNhat);
            this.groupBoxCapNhat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCapNhat.Location = new System.Drawing.Point(450, 53);
            this.groupBoxCapNhat.Name = "groupBoxCapNhat";
            this.groupBoxCapNhat.Size = new System.Drawing.Size(312, 170);
            this.groupBoxCapNhat.TabIndex = 10;
            this.groupBoxCapNhat.TabStop = false;
            this.groupBoxCapNhat.Text = "Cập nhật trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 56);
            this.label4.TabIndex = 14;
            this.label4.Text = "1 – Đã thanh toán, \r\n2 – Đã chuyển hàng, \r\n3 – Giao dịch thành công, \r\n4 - Giao d" +
    "ịch thất bại, Hủy đơn hàng";
            // 
            // txtCapNhatTT
            // 
            this.txtCapNhatTT.Location = new System.Drawing.Point(166, 64);
            this.txtCapNhatTT.Name = "txtCapNhatTT";
            this.txtCapNhatTT.Size = new System.Drawing.Size(100, 29);
            this.txtCapNhatTT.TabIndex = 13;
            // 
            // txtMaDonCapNhat
            // 
            this.txtMaDonCapNhat.Location = new System.Drawing.Point(166, 29);
            this.txtMaDonCapNhat.Name = "txtMaDonCapNhat";
            this.txtMaDonCapNhat.Size = new System.Drawing.Size(140, 29);
            this.txtMaDonCapNhat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cập nhật trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập mã đơn:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(592, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MHDonGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBoxCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBoxXemDon);
            this.Controls.Add(this.dsDonHang);
            this.Controls.Add(this.label1);
            this.Name = "MHDonGiaoHang";
            this.Text = "MHDonGiaoHang";
            this.Load += new System.EventHandler(this.MHDonGiaoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDonHang)).EndInit();
            this.groupBoxXemDon.ResumeLayout(false);
            this.groupBoxXemDon.PerformLayout();
            this.groupBoxCapNhat.ResumeLayout(false);
            this.groupBoxCapNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsDonHang;
        private System.Windows.Forms.RadioButton radioButtonTrangThai;
        private System.Windows.Forms.Button btnTimKiemDH;
        private System.Windows.Forms.RadioButton radioButtonDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBoxXemDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBoxCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDonCapNhat;
        private System.Windows.Forms.RadioButton radioButtonDSDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapNhatTT;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTrangThai;
    }
}