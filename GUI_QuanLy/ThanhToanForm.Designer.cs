namespace QuanLyBanHangQuaMang
{
    partial class ThanhToanForm
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
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paypalRadioButton = new System.Windows.Forms.RadioButton();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin mời chọn phương thức thanh toán:";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(15, 34);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(120, 17);
            this.cashRadioButton.TabIndex = 1;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Thanh toán tiền mặt";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(141, 34);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(125, 17);
            this.cardRadioButton.TabIndex = 2;
            this.cardRadioButton.Text = "Thanh toán bằng thẻ";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.paypalRadioButton);
            this.groupBox1.Controls.Add(this.visaRadioButton);
            this.groupBox1.Controls.Add(this.masterCardRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cardNumTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thẻ";
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(20, 37);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(174, 20);
            this.cardNumTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại thẻ";
            // 
            // paypalRadioButton
            // 
            this.paypalRadioButton.AutoSize = true;
            this.paypalRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paypalRadioButton.Image = global::QuanLyBanHangQuaMang.Properties.Resources.payment_paypal;
            this.paypalRadioButton.Location = new System.Drawing.Point(183, 80);
            this.paypalRadioButton.Name = "paypalRadioButton";
            this.paypalRadioButton.Size = new System.Drawing.Size(68, 59);
            this.paypalRadioButton.TabIndex = 5;
            this.paypalRadioButton.UseVisualStyleBackColor = true;
            this.paypalRadioButton.CheckedChanged += new System.EventHandler(this.paypalRadioButton_CheckedChanged);
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.visaRadioButton.Image = global::QuanLyBanHangQuaMang.Properties.Resources.payment_visa;
            this.visaRadioButton.Location = new System.Drawing.Point(103, 80);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(68, 59);
            this.visaRadioButton.TabIndex = 4;
            this.visaRadioButton.UseVisualStyleBackColor = true;
            this.visaRadioButton.CheckedChanged += new System.EventHandler(this.visaRadioButton_CheckedChanged);
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Image = global::QuanLyBanHangQuaMang.Properties.Resources.payment_mastercard;
            this.masterCardRadioButton.Location = new System.Drawing.Point(20, 80);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(68, 59);
            this.masterCardRadioButton.TabIndex = 3;
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            this.masterCardRadioButton.CheckedChanged += new System.EventHandler(this.masterCardRadioButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cardRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToanForm";
            this.Text = "ThanhToanForm";
            this.Load += new System.EventHandler(this.ThanhToanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.RadioButton paypalRadioButton;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}