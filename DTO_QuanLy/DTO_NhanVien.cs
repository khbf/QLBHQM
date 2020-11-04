using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private int _maNV;
        private string _tenNV;
        private string _email;
        private string _matKhau;
        private string _sdtNV;
        private string _loaiNV;

        public int MaNV
        {
            get { return _maNV; }

            set { _maNV = value; }
        }
        public string TenNV
        {
            get { return _tenNV; }

            set { _tenNV = value; }
        }
        public string Email
        {
            get { return _email; }

            set { _email = value; }
        }
        public string MatKhau
        {
            get { return _matKhau; }

            set { _matKhau = value; }
        }
        public string SDT_NV
        {
            get { return _sdtNV; }

            set { _sdtNV = value; }
        }
        public string LoaiNV
        {
            get { return _loaiNV; }

            set { _loaiNV = value; }
        }

        public DTO_NhanVien()
        {
        }

        public DTO_NhanVien(int manv, string tennv, string email, string mkhau, string sdtnv, string loainv)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.Email = email;
            this.MatKhau = mkhau;
            this.SDT_NV = sdtnv;
            this.LoaiNV = loainv;
        }
        public DTO_NhanVien(string tennv, string email, string mkhau, string sdtnv, string loainv)
        {
          //  this.MaNV = manv;
            this.TenNV = tennv;
            this.Email = email;
            this.MatKhau = mkhau;
            this.SDT_NV = sdtnv;
            this.LoaiNV = loainv;
        }
    }
}
