using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_Comment
    {
        public static DAL_Comment instance;
        public static DAL_Comment Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_Comment();
                return instance;
            }
        }
        private DAL_Comment() { }
        public DataTable LayDanhSachComment()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaCMT", typeof(int));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("TenMH", typeof(string));
            table.Columns.Add("NgayCMT", typeof(DateTime));
            table.Columns.Add("NoidungCMT", typeof(string));

            string query = "Select c.MaCMT, KH.TenKH, MH.TenMH, c.NgayCMT, C.NoiDungCMT from MAT_HANG MH, KHACH_HANG KH,COMMENT c where MH.MaMH = c.MaMH_CMT and KH.MaKH = c.MaKH_CMT";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaCMT"] = item["MaCMT"].ToString();
                row["TenKH"] = item["TenKH"].ToString();
                row["TenMH"] = item["TenMH"].ToString();
                row["NgayCMT"] = item["NgayCMT"].ToString();
                row["NoiDungCMT"] = item["NoiDungCMT"].ToString();
                table.Rows.Add(row);
            }
            return table;
        }
        public DataTable LayDanhSachNhanQua(DateTime dateFrom, DateTime dateTo)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaKh", typeof(int));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("SDT_KH", typeof(string));

            string query = "Select distinct KH.MaKH, KH.TenKH, Kh.Email, KH.SDT_KH from KHACH_HANG KH,COMMENT c where c.LoaiCMT = 2 and KH.MaKH = c.MaKH_CMT and c.NgayCMT>= @NgayCMT1 and c.NgayCMT<= @NgayCMT2";
            object[] para = new object[] { dateFrom, dateTo };

            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaKH"] = item["MaKH"].ToString();
                row["TenKH"] = item["TenKH"].ToString();
                row["Email"] = item["Email"].ToString();
                row["SDT_KH"] = item["SDT_KH"].ToString();
                table.Rows.Add(row);
            }
            return table;
        }
        public DataTable TimKiemTheoThoiGian(DateTime dateFrom, DateTime dateTo)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaCMT", typeof(int));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("TenMH", typeof(string));
            table.Columns.Add("NgayCMT", typeof(DateTime));
            table.Columns.Add("NoidungCMT", typeof(string));

            string query = "Select c.MaCMT, KH.TenKH, MH.TenMH, c.NgayCMT, C.NoiDungCMT from MAT_HANG MH, KHACH_HANG KH,COMMENT c where MH.MaMH = c.MaMH_CMT and KH.MaKH = c.MaKH_CMT and c.NgayCMT>= @NgayCMT1 and c.NgayCMT<= @NgayCMT2 ";
            object[] para = new object[] { dateFrom, dateTo };

            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaCMT"] = item["MaCMT"].ToString();
                row["TenKH"] = item["TenKH"].ToString();
                row["TenMH"] = item["TenMH"].ToString();
                row["NgayCMT"] = item["NgayCMT"].ToString();
                row["NoiDungCMT"] = item["NoiDungCMT"].ToString();
                table.Rows.Add(row);
            }
            return table;
        }
        public void XoaComment(List<int> MaCMT)
        {
            foreach (var item in MaCMT)
            {
                string query1 = "DELETE FROM COMMENT Where MaCMT= @MaCMT ";
                string query2 = "UPDATE kh SET kh.tinhtrangCMT = 0 from COMMENT c, KHACH_HANG kh WHERE c.MaCMT = @MaCMT and MAKH = c.MaKH_CMT ";
                object[] para = new object[] { item };
                DBConnect.Instance.ExecuteScalar(query2, para);
                DBConnect.Instance.ExecuteScalar(query1, para);
            }
        }
        public void ThemDanhSachNhanQua(List<int> MaCMT)
        {
            foreach (var item in MaCMT)
            {
                string query = "UPDATE COMMENT SET LoaiCMT = 2  WHERE MaCMT = @MaCMT ";
                object[] para = new object[] { item };
                DBConnect.Instance.ExecuteScalar(query, para);
            }
        }

    }
}
