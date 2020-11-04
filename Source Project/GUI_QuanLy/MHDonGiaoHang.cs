using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class MHDonGiaoHang : Form
    {
        public MHDonGiaoHang()
        {
            InitializeComponent();
        }

        //Load danh sach don hang len giao dien
        private void MHDonGiaoHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }


        private void HienThi()
        {
            BUS_DonHang.Instance.LayDanhSachDonHang();
            dsDonHang.DataSource = BUS_DonHang.Instance.LayDanhSachDonHang();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            XemDonHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtCapNhatTT.Text.Length != 0)
            {
                    if (BUS_DonHang.Instance.CapNhatTT(txtCapNhatTT.Text, txtMaDonCapNhat.Text))
                    {
                        MessageBox.Show("Cập nhật trang thai thành công!");
                        HienThi();
                    }
                    else
                        MessageBox.Show("Lỗi! Cập nhật Nhân viên không thành công!");
            }
            else
            {
                MessageBox.Show("Không được để trống các ô cần nhập!");
            }
        }

        // Xem Đơn hàng
        private void XemDonHang()
        {
            DataTable dsdh = new DataTable();

            if (radioButtonTrangThai.Checked == true)
            {
                dsdh = BUS_DonHang.Instance.XemDH_TrangThai(txtTrangThai.Text);
            }
            if (radioButtonDiaChi.Checked == true)
            {
                dsdh = BUS_DonHang.Instance.XemDH_DiaChi(txtDiaChi.Text);
            }
            if (radioButtonDSDH.Checked == true)
            {
                dsdh = BUS_DonHang.Instance.LayDanhSachDonHang();
            }
            dsDonHang.DataSource = dsdh;    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = String.Empty;
            txtMaDonCapNhat.Text = String.Empty;
            txtCapNhatTT.Text = String.Empty;
            txtTrangThai.Text = String.Empty;
            HienThi();
            MessageBox.Show("Reset dữ liệu thành công!");
        }


    }
}
