namespace GUI_QuanLy
{
    partial class MHQuanLyNCC
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
            this.dsNCC = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioiThieuNCC = new System.Windows.Forms.TextBox();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnCapNhatNCC = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemNCC = new System.Windows.Forms.Button();
            this.radioButtonLayTatCaNCC = new System.Windows.Forms.RadioButton();
            this.txtTKTheoTenNCC = new System.Windows.Forms.TextBox();
            this.radioButtonTKTheoTenNCC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(356, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // dsNCC
            // 
            this.dsNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNCC.Location = new System.Drawing.Point(12, 221);
            this.dsNCC.Name = "dsNCC";
            this.dsNCC.Size = new System.Drawing.Size(839, 269);
            this.dsNCC.TabIndex = 4;
            this.dsNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsNCC_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(92, 60);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(378, 20);
            this.txtMaNCC.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên NCC";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(92, 98);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(378, 20);
            this.txtTenNCC.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giới thiệu";
            // 
            // txtGioiThieuNCC
            // 
            this.txtGioiThieuNCC.Location = new System.Drawing.Point(92, 138);
            this.txtGioiThieuNCC.Multiline = true;
            this.txtGioiThieuNCC.Name = "txtGioiThieuNCC";
            this.txtGioiThieuNCC.Size = new System.Drawing.Size(378, 60);
            this.txtGioiThieuNCC.TabIndex = 21;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.Location = new System.Drawing.Point(870, 260);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(95, 31);
            this.btnThemNCC.TabIndex = 22;
            this.btnThemNCC.Text = "THÊM";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.Location = new System.Drawing.Point(870, 319);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(95, 31);
            this.btnXoaNCC.TabIndex = 23;
            this.btnXoaNCC.Text = "XÓA";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnCapNhatNCC
            // 
            this.btnCapNhatNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNCC.Location = new System.Drawing.Point(870, 375);
            this.btnCapNhatNCC.Name = "btnCapNhatNCC";
            this.btnCapNhatNCC.Size = new System.Drawing.Size(95, 31);
            this.btnCapNhatNCC.TabIndex = 24;
            this.btnCapNhatNCC.Text = "CẬP NHẬT";
            this.btnCapNhatNCC.UseVisualStyleBackColor = true;
            this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(870, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemNCC);
            this.groupBox1.Controls.Add(this.radioButtonLayTatCaNCC);
            this.groupBox1.Controls.Add(this.txtTKTheoTenNCC);
            this.groupBox1.Controls.Add(this.radioButtonTKTheoTenNCC);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(524, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 147);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNCC.Location = new System.Drawing.Point(346, 107);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.Size = new System.Drawing.Size(95, 31);
            this.btnTimKiemNCC.TabIndex = 25;
            this.btnTimKiemNCC.Text = "TÌM KIẾM";
            this.btnTimKiemNCC.UseVisualStyleBackColor = true;
            this.btnTimKiemNCC.Click += new System.EventHandler(this.btnTimKiemNCC_Click);
            // 
            // radioButtonLayTatCaNCC
            // 
            this.radioButtonLayTatCaNCC.AutoSize = true;
            this.radioButtonLayTatCaNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLayTatCaNCC.Location = new System.Drawing.Point(15, 82);
            this.radioButtonLayTatCaNCC.Name = "radioButtonLayTatCaNCC";
            this.radioButtonLayTatCaNCC.Size = new System.Drawing.Size(84, 20);
            this.radioButtonLayTatCaNCC.TabIndex = 20;
            this.radioButtonLayTatCaNCC.TabStop = true;
            this.radioButtonLayTatCaNCC.Text = "Lấy tất cả";
            this.radioButtonLayTatCaNCC.UseVisualStyleBackColor = true;
            // 
            // txtTKTheoTenNCC
            // 
            this.txtTKTheoTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKTheoTenNCC.Location = new System.Drawing.Point(128, 36);
            this.txtTKTheoTenNCC.Multiline = true;
            this.txtTKTheoTenNCC.Name = "txtTKTheoTenNCC";
            this.txtTKTheoTenNCC.Size = new System.Drawing.Size(313, 20);
            this.txtTKTheoTenNCC.TabIndex = 1;
            // 
            // radioButtonTKTheoTenNCC
            // 
            this.radioButtonTKTheoTenNCC.AutoSize = true;
            this.radioButtonTKTheoTenNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTKTheoTenNCC.Location = new System.Drawing.Point(15, 35);
            this.radioButtonTKTheoTenNCC.Name = "radioButtonTKTheoTenNCC";
            this.radioButtonTKTheoTenNCC.Size = new System.Drawing.Size(107, 20);
            this.radioButtonTKTheoTenNCC.TabIndex = 0;
            this.radioButtonTKTheoTenNCC.TabStop = true;
            this.radioButtonTKTheoTenNCC.Text = "Theo tên NCC";
            this.radioButtonTKTheoTenNCC.UseVisualStyleBackColor = true;
            // 
            // MHQuanLyNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhatNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.txtGioiThieuNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsNCC);
            this.Controls.Add(this.label1);
            this.Name = "MHQuanLyNCC";
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.MHQuanLyNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGioiThieuNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnCapNhatNCC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLayTatCaNCC;
        private System.Windows.Forms.TextBox txtTKTheoTenNCC;
        private System.Windows.Forms.RadioButton radioButtonTKTheoTenNCC;
        private System.Windows.Forms.Button btnTimKiemNCC;
    }
}