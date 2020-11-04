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
    public class BUS_Comment
    {
        private static BUS_Comment instance;
        public static BUS_Comment Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Comment();
                return instance;
            }
        }
        private BUS_Comment() { }

        //Lay danh sach mat hang
        public DataTable LayDanhSachComment()
        {
            return DAL_Comment.Instance.LayDanhSachComment();
        }

       

        public DataTable TimKiemTheoThoiGian(DateTime dateFrom,DateTime  dateTo)
        {
            return DAL_Comment.Instance.TimKiemTheoThoiGian(dateFrom, dateTo);
        }
        public DataTable LayDanhSachNhanQua(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_Comment.Instance.LayDanhSachNhanQua(dateFrom, dateTo);
        }

        public void XoaComment(List<int> MaCMT)
        {
             DAL_Comment.Instance.XoaComment( MaCMT);
        }
        public void ThemDanhSachNhanQua(List<int> MaCMT)
        {
             DAL_Comment.Instance.ThemDanhSachNhanQua(MaCMT);
        }

      

//         //Xóa mặt hàng
//         public bool XoaComment(int mamh)
//         {
//             return DAL_Comment.Instance.XoaComment(mamh);
//         }

    }
}
