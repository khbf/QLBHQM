using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class MHQuanLyNCC : Form
    {
        public MHQuanLyNCC()
        {
            InitializeComponent();
        }

        //Load danh sach ncc len giao dien
        private void MHQuanLyNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            HienThi();
        }

        //Ham hien thi danh sach NCC
        private void HienThi()
        {
            BUS_NCC.Instance.LayToanBoDanhSachNCC();
            dsNCC.DataSource = BUS_NCC.Instance.LayToanBoDanhSachNCC();
        }

        //Button Thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button Them NCC
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            //Kiểm tra ô Ten NCC bị trống giá trị
            if (txtTenNCC.Text.Length != 0)
            {
                //Kiểm tra tên ncc đó đã tồn tại
                if (BUS_NCC.Instance.KiemTraTonTaiNCC(txtTenNCC.Text) == false)
                {
                    //kiểm tra tên NCC khi nhập vào phải <= 50
                    if (txtTenNCC.Text.Length <= 50)
                    {
                            DTO_NCC ncc = new DTO_NCC(txtTenNCC.Text, txtGioiThieuNCC.Text);
                            if (BUS_NCC.Instance.ThemNCCMoi(ncc))
                            {
                                MessageBox.Show("Thêm NCC mới thành công!");
                                HienThi();
                            }
                            else
                                MessageBox.Show("Lỗi! Thêm NCC mới không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Tên NCC đã quá 50 ký tự. Xin nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên NCC này đã tồn tại. Xin nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ô Tên NCC!");
            }
        }

        //Lay tung gia tri trong cot cua datagridView hien len textbox
        private void dsNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienGiaTriPhanTu();
        }

        private void HienGiaTriPhanTu()
        {
            int i = dsNCC.CurrentRow.Index;
            txtMaNCC.Text = dsNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dsNCC.Rows[i].Cells[1].Value.ToString();
            txtGioiThieuNCC.Text = dsNCC.Rows[i].Cells[2].Value.ToString();
        }

        //Button Cap nhat thong tin NCC
        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            //Kiểm tra ô Ten NCC bị trống giá trị
            if (txtTenNCC.Text.Length != 0)
            {
                    //kiểm tra tên NCC khi nhập vào phải <= 50
                    if (txtTenNCC.Text.Length <= 50)
                    {
                        DTO_NCC ncc = new DTO_NCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtGioiThieuNCC.Text);
                        if (BUS_NCC.Instance.CapNhatNCC(ncc))
                        {
                            MessageBox.Show("Cập nhật NCC thành công!");
                            HienThi();
                        }
                        else
                            MessageBox.Show("Lỗi! Cập nhật NCC không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Tên NCC đã quá 50 ký tự. Xin nhập lại!");
                    }
            }
            else
            {
                MessageBox.Show("Không được để trống ô Tên NCC!");
            }
        }

        //Button xoa NCC
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_NCC.Instance.XoaNCC(int.Parse(txtMaNCC.Text)))
                {
                    MessageBox.Show("Xóa NCC thành công!");
                    HienThi();
                }
                else
                    MessageBox.Show("Lỗi! Xóa NCC không thành công!");
            }
            catch
            {
                MessageBox.Show("NCC này còn đang cung cấp những mặt hàng đang được bán. Không được xóa!");     //rang buoc khoa ngoai
            }
        }

        DataTable dsncc;

        //Button Tim kiem NCC
        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            // TimKiem();
            dsncc = new DataTable();

            if (radioButtonTKTheoTenNCC.Checked == true)         //theo ten ncc
            {
                dsncc = BUS_NCC.Instance.TimKiemTheoTenNCC(txtTKTheoTenNCC.Text);
            }
            if (radioButtonLayTatCaNCC.Checked == true)          //lay tat ca
            {
                dsncc = BUS_NCC.Instance.LayToanBoDanhSachNCC();
            }
            dsNCC.DataSource = dsncc;
        }
    }
}
