using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_DonHang
    {
        private static BUS_DonHang instance;
        public static BUS_DonHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_DonHang();
                return instance;
            }
        }
        private BUS_DonHang() { }

        //Lay danh sach don hang
        public DataTable LayDanhSachDonHang()
        {
            return DAL_DonHang.Instance.LayDanhSachDonHang();
        }

        //Xem đơn hàng dựa vào địa chỉ Khách hàng
        public DataTable XemDH_DiaChi(string diachi)
        {
            return DAL_DonHang.Instance.XemDH_DiaChi(diachi);
        }

        //Tìm kiếm MH theo tên NV quan ly
        public DataTable XemDH_TrangThai(string trangthai)
        {
            return DAL_DonHang.Instance.XemDH_TrangThai(trangthai);
        }

        //Cap nhat mat hang
        public bool CapNhatTT(string trangthai, string madon)
        {
            return DAL_DonHang.Instance.CapNhatTT(trangthai,madon);
        }

    }
}
