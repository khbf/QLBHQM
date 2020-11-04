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
    public partial class MHQuanLyMatHang : Form
    {
        public MHQuanLyMatHang()
        {
            InitializeComponent();
        }

        //Load danh sach mat hang, NCC và nhan vien len giao dien
        private void MHQuanLyMatHang_Load(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            HienThi();
        }

        private void HienThi()
        {
            BUS_MatHang.Instance.LayDanhSachMatHang();
            dsMatHang.DataSource = BUS_MatHang.Instance.LayDanhSachMatHang();

            cbbNCC.DataSource = BUS_NCC.Instance.LayDanhSachNCC_ChoMH();
            //Hiển thị và giá trị của combobox NCC
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";

            cbbTKTheoNCC.DataSource = BUS_NCC.Instance.LayDanhSachNCC_ChoMH();
            cbbTKTheoNCC.DisplayMember = "TenNCC";
            cbbTKTheoNCC.ValueMember = "TenNCC";

            cbbNVBanHangQuanLyMH.DataSource = BUS_NhanVien.Instance.LayDanhSachNhanVienBanHang();
            cbbNVBanHangQuanLyMH.DisplayMember = "TenNV";
            cbbNVBanHangQuanLyMH.ValueMember = "MaNV";

            cbbTKTheoNV.DataSource = BUS_NhanVien.Instance.LayDanhSachNhanVienBanHang();
            cbbTKTheoNV.DisplayMember = "TenNV";
            cbbTKTheoNV.ValueMember = "TenNV";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button thêm mặt hàng
        private void btnThemMH_Click(object sender, EventArgs e)            
        {
            //Kiểm tra các ô bị trống giá trị
            if(txtTenMH.Text.Length != 0 && txtLoaiMH.Text.Length != 0 && txtSoLuongTon.Text.Length != 0 && txtSoLuongHangToiThieu.Text.Length != 0 && txtGiaTien.Text.Length != 0)
            {
                //Kiểm tra tên mặt hàng và NCC của mặt hàng đó đã tồn tại
                if (BUS_MatHang.Instance.KiemTraTonTai(txtTenMH.Text, int.Parse(cbbNCC.SelectedValue.ToString())) == false)
                {
                    //kiểm tra tên mặt hàng va tên loại mặt hàng khi nhập vào phải <= 50
                    if (txtTenMH.Text.Length <= 50 && txtLoaiMH.Text.Length <= 50)  
                    {
                        //Kiểm tra số lượng nhập vào # 0
                        if(int.Parse(txtSoLuongTon.Text) != 0 && int.Parse(txtSoLuongHangToiThieu.Text) != 0)
                        {
                            DTO_MatHang mh = new DTO_MatHang(txtTenMH.Text, int.Parse(cbbNCC.SelectedValue.ToString()), txtLoaiMH.Text, int.Parse(txtSoLuongTon.Text), int.Parse(txtSoLuongHangToiThieu.Text), decimal.Parse(txtGiaTien.Text), int.Parse(cbbNVBanHangQuanLyMH.SelectedValue.ToString()));
                            if (BUS_MatHang.Instance.ThemMatHang(mh))
                            {
                                MessageBox.Show("Thêm mặt hàng thành công!");
                                HienThi();
                            }
                            else
                                MessageBox.Show("Lỗi! Thêm mặt hàng không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Số lượng nhập vào phải khác 0!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Tên mặt hàng hay Loại mặt hàng đã quá 50 ký tự. Xin nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên mặt hàng và NCC này đã tồn tại. Xin nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô cần nhập!");
            }
        }

        private void dsMatHang_CellClick(object sender, DataGridViewCellEventArgs e)     
        {
            int i = dsMatHang.CurrentRow.Index;
            txtMaMH.Text= dsMatHang.Rows[i].Cells[0].Value.ToString();
            txtTenMH.Text = dsMatHang.Rows[i].Cells[1].Value.ToString();
            cbbNCC.Text = dsMatHang.Rows[i].Cells[3].Value.ToString();
            txtLoaiMH.Text = dsMatHang.Rows[i].Cells[2].Value.ToString();
            txtSoLuongTon.Text = dsMatHang.Rows[i].Cells[4].Value.ToString();
            txtSoLuongHangToiThieu.Text = dsMatHang.Rows[i].Cells[5].Value.ToString();
            txtGiaTien.Text = dsMatHang.Rows[i].Cells[6].Value.ToString();
            cbbNVBanHangQuanLyMH.Text = dsMatHang.Rows[i].Cells[7].Value.ToString();

        }

        //Button cập nhật mặt hàng
        private void btnCapNhatMH_Click(object sender, EventArgs e)              
        {
            //Kiểm tra các ô bị trống giá trị
            if (txtTenMH.Text.Length != 0 && txtLoaiMH.Text.Length != 0 && txtSoLuongTon.Text.Length != 0 && txtSoLuongHangToiThieu.Text.Length != 0 && txtGiaTien.Text.Length != 0)
            {
                    //kiểm tra tên mặt hàng hoặc tên loại mặt hàng khi nhập vào phải <= 50
                    if (txtTenMH.Text.Length <= 50 && txtLoaiMH.Text.Length <= 50)
                    {
                        //Kiểm tra số lượng nhập vào # 0
                        if (int.Parse(txtSoLuongTon.Text) != 0 && int.Parse(txtSoLuongHangToiThieu.Text) != 0)
                        {
                            DTO_MatHang mh = new DTO_MatHang(int.Parse(txtMaMH.Text), txtTenMH.Text, int.Parse(cbbNCC.SelectedValue.ToString()), txtLoaiMH.Text, int.Parse(txtSoLuongTon.Text), int.Parse(txtSoLuongHangToiThieu.Text), decimal.Parse(txtGiaTien.Text), int.Parse(cbbNVBanHangQuanLyMH.SelectedValue.ToString()));
                            if (BUS_MatHang.Instance.CapNhatMH(mh))
                            {
                                MessageBox.Show("Cập nhật mặt hàng thành công!");
                                HienThi();
                            }
                            else
                            {
                                MessageBox.Show("Lỗi! Cập nhật mặt hàng không thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng nhập vào phải khác 0!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên mặt hàng hay Loại mặt hàng đã quá 50 ký tự. Xin nhập lại!");
                    }     
            }
            else
            {
                MessageBox.Show("Không được để trống các ô cần nhập!");
            }
        }

        //Button xóa mặt hàng
        private void btnXoaMH_Click(object sender, EventArgs e)             
        {
            try
            {
                if (BUS_MatHang.Instance.XoaMatHang(int.Parse(txtMaMH.Text)))
                {
                    MessageBox.Show("Xóa mặt hàng thành công!");
                    HienThi();
                }
                else
                    MessageBox.Show("Lỗi! Xóa mặt hàng không thành công!");
            }
            catch
            {
                MessageBox.Show("Mặt hàng này còn bị ràng buộc bởi nhiều bảng khác. Không được xóa!");     //rang buoc khoa ngoai
            }
        }

        DataTable dsmh;
        //Button tìm kiếm

        private void btnTimKiem_Click(object sender, EventArgs e)           
        {
            dsmh = new DataTable();

            if (radioButtonTKTheoTen.Checked == true)         //theo ten MH
            {
                dsmh = BUS_MatHang.Instance.TimKiemTheoTenMH(txtTKTenMH.Text);
            }
            if (radioButtonTKTheoNCC.Checked == true)         //theo ten ncc
            {
                dsmh = BUS_MatHang.Instance.TimKiemTheoTenNCC(cbbTKTheoNCC.SelectedValue.ToString());
            }
            if (radioButtonLayTatCa.Checked == true)          //lay tat ca
            {
                dsmh = BUS_MatHang.Instance.LayDanhSachMatHang();
            }
            if (radioButtonTheoNV.Checked == true)            //theo ten nv quan ly
            {
                dsmh = BUS_MatHang.Instance.TimKiemTheoTenNVQuanLy(cbbTKTheoNV.SelectedValue.ToString());
            }
            dsMatHang.DataSource = dsmh;
        }

    }
}
