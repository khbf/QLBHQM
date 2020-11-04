using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_DonHang
    {
        private int _MaDH;
        private int _MaKH_DatHang;
        private string _NgayDatHang;
        private string _SDT_KH;
        private string _DiaChi_KH ;
        private string _Email_KH;
        private decimal _TongTien;
        private int _HinhThucThanhToan;  //(0 - tien mat, 1 - qua thẻ)
        private int _TrangThaiDH; 
        //(0 – Đã xác nhận, 1 – Đã thanh toán, 2 – Đang chuyển hàng, 3 – Giao dịch thành công, 4 - Giao dịch thất bại, Hủy đơn hàng)

        public int MaDH
        {
            get { return _MaDH; }

            set { _MaDH = value; }
        }

        public int MaKH_DatHang
        {
            get { return _MaKH_DatHang; }

            set { _MaKH_DatHang = value; }
        }

        public string NgayDatHang
        {
            get { return _NgayDatHang; }

            set { _NgayDatHang = value; }
        }

        public string SDT_KH
        {
            get { return _SDT_KH; }

            set { _SDT_KH = value; }
        }
        public string DiaChi_KH
        {
            get { return _DiaChi_KH; }

            set { _DiaChi_KH = value; }
        }

        public string Email_KH
        {
            get { return _Email_KH; }

            set { _Email_KH = value; }
        }

        public decimal TongTien
        {
            get { return _TongTien; }

            set { _TongTien = value; }
        }

        public int HinhThucThanhToan
        {
            get { return _HinhThucThanhToan; }

            set { _HinhThucThanhToan = value; }
        }

        public int TrangThaiDH
        {
            get { return _TrangThaiDH; }

            set { _TrangThaiDH = value; }
        }

        /* === Constructor === */
        public DTO_DonHang()
        {

        }

        public DTO_DonHang(int madh, int makh_dh, string ngaydat, string sdt_kh, string diachi_kh, string email_kh, decimal tongtien, int hinhthucTT, int trangthai)
        {
            this.MaDH = madh;
            this.MaKH_DatHang = makh_dh;
            this.NgayDatHang = ngaydat;
            this.SDT_KH = sdt_kh;
            this.DiaChi_KH = diachi_kh;
            this.Email_KH = email_kh;
            this.TongTien = tongtien;
            this.HinhThucThanhToan = hinhthucTT;
            this.TrangThaiDH = trangthai;
    }
        public DTO_DonHang(int madh, string ngaydat, string sdt_kh, string diachi_kh, decimal tongtien, int hinhthucTT, int trangthai)
        {
            this.MaDH = madh;
            this.NgayDatHang = ngaydat;
            this.SDT_KH = sdt_kh;
            this.DiaChi_KH = diachi_kh;
            this.TongTien = tongtien;
            this.HinhThucThanhToan = hinhthucTT;
            this.TrangThaiDH = trangthai;
        }
    }
}
