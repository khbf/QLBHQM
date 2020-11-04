using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_NCC
    {
        private static BUS_NCC instance;
        public static BUS_NCC Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_NCC();
                return instance;
            }
        }
        private BUS_NCC() { }

        //Lay danh sach NCC cho ben GD QLMH
        public DataTable LayDanhSachNCC_ChoMH()
        {
            return DAL_NCC.Instance.LayDanhSachNCC_ChoMH();
        }

        //Lay toan bo danh sach ncc
        public DataTable LayToanBoDanhSachNCC()
        {
            return DAL_NCC.Instance.LayDanhSachNCC();
        }

        //Them ncc
        public bool ThemNCCMoi(DTO_NCC ncc)
        {
            return DAL_NCC.Instance.ThemNCC(ncc);
        }

        //Kiem tra ncc da ton tai truoc do qua so sanh ten ncc
        public bool KiemTraTonTaiNCC(string tenncc)
        {
            DTO_NCC nv = DAL_NCC.Instance.DocThongTinNCC(tenncc);
            if (nv == null)
            {
                return false;        //Chưa tồn tại 
            }
            return true;
        }


        //Cap nhat ncc
        public bool CapNhatNCC(DTO_NCC ncc)
        {
            return DAL_NCC.Instance.CapNhatNCC(ncc);
        }

        //Xóa ncc
        public bool XoaNCC(int mancc)
        {
            return DAL_NCC.Instance.XoaNCC(mancc);
        }

        //Tìm kiếm ncc theo tên ncc
        public DataTable TimKiemTheoTenNCC(string tenncc)
        {
            return DAL_NCC.Instance.TimKiemTheoTenNCC(tenncc);
        }
         
    }
}
