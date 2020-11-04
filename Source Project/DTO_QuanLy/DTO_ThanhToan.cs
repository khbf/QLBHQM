using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThanhToan
    {
        private int _maHoaDon;
        private int _khThanhToan;
        private int _nvThanhToan;
        private int _loaiThanhToan;
        private double _soTienNhan;
        private string _soTaiKhoan;

        public int maHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }

        public int khThanhToan
        {
            get { return _khThanhToan; }
            set { _khThanhToan = value; }
        }

        public int nvThanhToan
        {
            get { return _nvThanhToan; }
            set { _nvThanhToan = value; }
        }

        public int loaiThanhToan
        {
            get { return _loaiThanhToan; }
            set { _loaiThanhToan = value; }
        }

        public double soTienNhan
        {
            get { return _soTienNhan; }
            set { _soTienNhan = value; }
        }

        public string soTaiKhoan
        {
            get { return _soTaiKhoan; }
            set { _soTaiKhoan = value; }
        }

        public DTO_ThanhToan()
        {
        }

        public DTO_ThanhToan(int maHoaDon, int khThanhToan, int nvThanhToan, int loaiThanhToan, double soTienNhan, string soTaiKhoan)
        {
            this.maHoaDon = maHoaDon;
            this.khThanhToan = khThanhToan;
            this.nvThanhToan = nvThanhToan;
            this.loaiThanhToan = loaiThanhToan;
            this.soTienNhan = soTienNhan;
            this.soTaiKhoan = soTaiKhoan;
        }
    }
}
