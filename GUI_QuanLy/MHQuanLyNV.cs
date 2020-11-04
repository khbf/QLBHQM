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
    public partial class MHQuanLyNV : Form
    {
        public MHQuanLyNV()
        {
            InitializeComponent();
        }

        //Load danh sach nhan vien va loai nhan vien len giao dien
        private void MHQuanLyNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            HienThi();
        }

        private void HienThi()
        {
            BUS_NhanVien.Instance.LayDanhSachNhanVien();
            dsNhanVien.DataSource = BUS_NhanVien.Instance.LayDanhSachNhanVien();

            cbbLoaiNV.DataSource = BUS_NhanVien.Instance.LayDanhSachLoaiNV();
            //Hiển thị và giá trị của combobox LoaiNV
            cbbLoaiNV.DisplayMember = "LoaiNV";
            cbbLoaiNV.ValueMember = "LoaiNV";

            cbbTKTheoLoaiNV.DataSource = BUS_NhanVien.Instance.LayDanhSachLoaiNV();
            cbbTKTheoLoaiNV.DisplayMember = "LoaiNV";
            cbbTKTheoLoaiNV.ValueMember = "LoaiNV";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ham Kiem tra dinh dạng email co dang @..com
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        //Button Them NV
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            //Kiểm tra các ô bị trống giá trị
            if (txtTenNV.Text.Length != 0 && txtEmailNV.Text.Length != 0 && txtPasswordNV.Text.Length != 0 && cbbLoaiNV.Text.Length != 0)
            {
                //Kiểm tra email co dinh dạng dung
                if (isEmail(txtEmailNV.Text) == true)
                {
                    //kiểm tra tên NV va email va password khi nhập vào phải <= 50, SDT = 10 ki tu
                    if (txtTenNV.Text.Length <= 50 && txtEmailNV.Text.Length <= 50 && txtPasswordNV.Text.Length <= 50 && txtSDT_NV.Text.Length == 10)
                    {
                        if (BUS_NhanVien.Instance.KiemTraTonTai_Email(txtEmailNV.Text) == false)
                        {
                                DTO_NhanVien nv = new DTO_NhanVien(txtTenNV.Text, txtEmailNV.Text, txtPasswordNV.Text, txtSDT_NV.Text, cbbLoaiNV.SelectedValue.ToString());
                                if (BUS_NhanVien.Instance.ThemNhanVien(nv))
                                {
                                    MessageBox.Show("Thêm Nhân viên thành công!");
                                    HienThi();
                                }
                                else
                                    MessageBox.Show("Lỗi! Thêm Nhân viên không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Email của Nhân viên này đã tồn tại! Xin nhập lại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên nhân viên, Email và Mật khẩu cần ít hơn 50 ký tự! SĐT cần đúng 10 chữ số! Xin nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Email nhập vào có định dạng sai! Xin nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô cần nhập!");
            }
        }

        private void dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dsNhanVien.CurrentRow.Index;
            txtMaNV.Text = dsNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dsNhanVien.Rows[i].Cells[1].Value.ToString();
            txtEmailNV.Text = dsNhanVien.Rows[i].Cells[2].Value.ToString();
            txtPasswordNV.Text = dsNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSDT_NV.Text = dsNhanVien.Rows[i].Cells[4].Value.ToString();
            cbbLoaiNV.Text = dsNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        //Button cap nhat NV
        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            txtEmailNV.Enabled = false;             //khong cho sua lai email

            //Kiểm tra các ô bị trống giá trị
            if (txtTenNV.Text.Length != 0 && txtPasswordNV.Text.Length != 0 && cbbLoaiNV.Text.Length != 0 && txtSDT_NV.Text.Length != 0)
            {
                    //kiểm tra tên NV va password khi nhập vào phải <= 50, SDT = 10 ki tu
                    if (txtTenNV.Text.Length <= 50 && txtPasswordNV.Text.Length <= 50 && txtSDT_NV.Text.Length == 10)
                    {
                            DTO_NhanVien nv = new DTO_NhanVien(int.Parse(txtMaNV.Text), txtTenNV.Text, txtEmailNV.Text, txtPasswordNV.Text, txtSDT_NV.Text, cbbLoaiNV.SelectedValue.ToString());
                            if (BUS_NhanVien.Instance.CapNhatNhanVien(nv))
                            {
                                MessageBox.Show("Cập nhật Nhân viên thành công!");
                                HienThi();
                            }
                            else
                                MessageBox.Show("Lỗi! Cập nhật Nhân viên không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Tên nhân viên và Mật khẩu cần ít hơn 50 ký tự! SĐT cần đúng 10 chữ số! Xin nhập lại!");
                    }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô cần nhập!");
            }
        }

        //Reset lai cac o hien gia tri
        private void btnResetNV_Click(object sender, EventArgs e)
        {
            //HienThi();
            txtEmailNV.Text = String.Empty;
            txtEmailNV.Enabled = true;
            txtPasswordNV.Text = String.Empty;
            txtSDT_NV.Text = String.Empty;
            txtTenNV.Text = String.Empty;
            txtMaNV.Text = String.Empty;

           MessageBox.Show("Reset dữ liệu thành công!");
        }

        //Button xoa NV
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_NhanVien.Instance.XoaNhanVien(int.Parse(txtMaNV.Text), cbbLoaiNV.SelectedValue.ToString()))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    HienThi();
                }
                else
                    MessageBox.Show("Lỗi! Không được xóa nhân viên quản lý!");
            }
            catch
            {
                MessageBox.Show("Nhân viên này còn đang thực hiện công việc. Không được xóa!");
            }
        }

        DataTable dsnv;

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            dsnv = new DataTable();

            if (radioButtonTKTheoTenNV.Checked == true)         //theo ten nv
            {
                dsnv = BUS_NhanVien.Instance.TimKiemTheoTenNhanVien(txtTKTheoTenNV.Text);
            }
            if (radioButtonTKTheoLoaiNV.Checked == true)         //theo ten ncc
            {
                dsnv = BUS_NhanVien.Instance.TimKiemTheoLoaiNhanVien(cbbTKTheoLoaiNV.SelectedValue.ToString());
            }
            if (radioButtonLayTatCaNV.Checked == true)          //lay tat ca
            {
                dsnv = BUS_NhanVien.Instance.LayDanhSachNhanVien();
            }
            dsNhanVien.DataSource = dsnv;
        }
    }
}
