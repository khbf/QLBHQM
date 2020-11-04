using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        private static BUS_NhanVien instance;
        public static BUS_NhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_NhanVien();
                return instance;
            }
        }
        private BUS_NhanVien() { }

        //Lay ra danh sach cac nhan vien ban hang
        public DataTable LayDanhSachNhanVienBanHang()
        {
            return DAL_NhanVien.Instance.LayDanhSachNhanVienBanHang();
        }

        //Lay danh sach nhan vien
        public DataTable LayDanhSachLoaiNV()
        {
            return DAL_NhanVien.Instance.LayDanhSachLoaiNV();
        }

        //Lay danh sach nhan vien
        public DataTable LayDanhSachNhanVien()
        {
            return DAL_NhanVien.Instance.LayDanhSachNhanVien();
        }

        //Them NV
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return DAL_NhanVien.Instance.ThemNV(nv);
        }

        //Kiem tra NV da ton tai truoc do chua qua so sanh email
        public bool KiemTraTonTai_Email(string email)
        {
            DTO_NhanVien nv = DAL_NhanVien.Instance.DocThongTinNV_Email(email);
            if (nv == null)
            {
                return false;        //Chưa tồn tại 
            }
            return true;
        }

        //Cap nhat NV
        public bool CapNhatNhanVien(DTO_NhanVien nv)
        {
            return DAL_NhanVien.Instance.CapNhatNV(nv);
        }

        //Xóa NV
        public bool XoaNhanVien(int manv, string loainv)
        {
            return DAL_NhanVien.Instance.XoaNV(manv,loainv);
        }

        //Tìm kiếm NV theo tên NV
        public DataTable TimKiemTheoTenNhanVien(string tennv)
        {
            return DAL_NhanVien.Instance.TimKiemTheoTenNV(tennv);
        }

        //Tìm kiếm NV theo loai NV
        public DataTable TimKiemTheoLoaiNhanVien(string loainv)
        {
            return DAL_NhanVien.Instance.TimKiemTheoLoaiNV(loainv);
        }
    }
}
