using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_ThanhToan
    {
        //public enum PaymentAttribute
        //{
        //    hoaDon,
        //    khThanhToan,
        //    nvThanhToan,
        //    loaiThanhToan
        //}

        public static DAL_ThanhToan instance;
        public static DAL_ThanhToan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThanhToan();
                return instance;
            }
        }
        private DAL_ThanhToan() { }
        
        public bool themThanhToan(DTO_ThanhToan thanhToan)
        {
            string query = "Insert INTO THANH_TOAN(HoaDon, KH_ThanhToan, NV_ThanhToan, LoaiThanhToan, SoTienNhan, SoTaiKhoan) " +
                "VALUES ( @HoaDon , @KH_ThanhToan , @NV_ThanhToan , @LoaiThanhToan , @SoTienNhan , @SoTaiKhoan )";
            object[] para = new object[] { thanhToan.maHoaDon, thanhToan.khThanhToan, thanhToan.nvThanhToan,
                thanhToan.loaiThanhToan, thanhToan.soTienNhan, thanhToan.soTaiKhoan };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public DTO_ThanhToan layThanhToan(int maHoaDon)
        {
            string query = "select * from THANH_TOAN where HoaDon = @HoaDon";
            object[] para = new object[] { maHoaDon };
            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int hoaDon = (int)item["HoaDon"];
                int khThanhToan = (int)item["KH_ThanhToan"];
                int nvThanhToan = (int)item["NV_ThanhToan"];
                int loaiThanhToan = (int)item["LoaiThanhToan"];
                double soTienNhan = (double)item["SoTienNhan"];
                string soTaiKhoan = item["SoTaiKhoan"].ToString();
                DTO_ThanhToan thanhToan = new DTO_ThanhToan(hoaDon, khThanhToan, nvThanhToan, loaiThanhToan, soTienNhan, soTaiKhoan);
                return thanhToan;
            }
            return null;
        }
    }
}
