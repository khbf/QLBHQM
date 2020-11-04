using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_MatHang
    {
        private static BUS_MatHang instance;
        public static BUS_MatHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_MatHang();
                return instance;
            }
        }
        private BUS_MatHang() { }

        //Lay danh sach mat hang
        public DataTable LayDanhSachMatHang()               
        {
            return DAL_MatHang.Instance.LayDanhSachMatHang();
        }

        //Tìm kiếm MH theo tên mặt hàng
        public DataTable TimKiemTheoTenMH(string tenmh)              
        {
            return DAL_MatHang.Instance.TimKiemTheoTenMH(tenmh);
        }

        //Tìm kiếm MH theo tên NCC
        public DataTable TimKiemTheoTenNCC(string tenncc)               
        {
            return DAL_MatHang.Instance.TimKiemTheoTenNCC(tenncc);
        }

        //Tìm kiếm MH theo tên NV quan ly
        public DataTable TimKiemTheoTenNVQuanLy(string tennv)              
        {
            return DAL_MatHang.Instance.TimKiemTheoTenNVQuanLy(tennv);
        }

        //Them mat hang
        public bool ThemMatHang(DTO_MatHang mh)             
        {
            return DAL_MatHang.Instance.ThemMatHang(mh);
        }

        //Kiem tra mat hang da ton tai truoc do chua
        public bool KiemTraTonTai(string tenmh, int ncc)            
        {
            DTO_MatHang mh = DAL_MatHang.Instance.DocThongTinMH(tenmh,ncc);
            if (mh == null)
            {
                return false;        //Chưa tồn tại 
            }
            return true;
        }

        //Cap nhat mat hang
        public bool CapNhatMH(DTO_MatHang mh)        
        {
            return DAL_MatHang.Instance.CapNhatMH(mh);
        }

        //Xóa mặt hàng
        public bool XoaMatHang(int mamh)         
        {
            return DAL_MatHang.Instance.XoaMatHang(mamh);
        }

    }
}
