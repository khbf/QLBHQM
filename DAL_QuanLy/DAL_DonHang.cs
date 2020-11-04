using DTO_QuanLy;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_DonHang
    {
        public static DAL_DonHang instance;
        public static DAL_DonHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DonHang();
                return instance;
            }
        }
        private DAL_DonHang() { }

        //Lay danh sach tat ca don hang
        public DataTable LayDanhSachDonHang()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDH", typeof(int));
            table.Columns.Add("DiaChi_KH", typeof(string));
            table.Columns.Add("SDT_KH", typeof(string));
            table.Columns.Add("NgayDatHang", typeof(string));
            table.Columns.Add("TongTien", typeof(decimal));
            table.Columns.Add("HinhThucThanhToan", typeof(int));
            table.Columns.Add("TrangThaiDH", typeof(int));

            string query = "select MaDH, DiaChi_KH, SDT_KH, NgayDatHang, TongTien, HinhThucThanhToan, TrangThaiDH from DON_HANG";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDH"] = (int)item["MaDH"];
                row["DiaChi_KH"] = item["DiaChi_KH"].ToString();
                row["SDT_KH"] = item["SDT_KH"].ToString();
                row["NgayDatHang"] = item["NgayDatHang"].ToString();
                row["TongTien"] = item["TongTien"].ToString();
                row["HinhThucThanhToan"] = item["HinhThucThanhToan"].ToString();
                row["TrangThaiDH"] = item["TrangThaiDH"].ToString();
                table.Rows.Add(row);
            }
            return table;
        }


        //Cập nhật trạng thái đơn hàng
        public bool CapNhatTT(string trangthai, string madon )      
        {
            string query = "Update DON_HANG set TrangThaiDH = @TrangThai where MaDH = @MaDH";
            object[] para = new object[] { trangthai, madon };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Xem đơn hàng dựa vào địa chỉ Khách hàng
        public DataTable XemDH_DiaChi(string diachi)
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //Truy vấn
            DataTable dt = new DataTable();
            string query = "Select MaDH, DiaChi_KH, SDT_KH, NgayDatHang, TongTien, HinhThucThanhToan, TrangThaiDH from DON_HANG where DiaChi_KH like N'%" + diachi + "%'";

            //Thực thi
            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);

            dt = a.Tables[0];
            cn.Close();
            return dt;
        }

        //Xem đơn hàng dựa vào trạng thái
        public DataTable XemDH_TrangThai(string trangthai)
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //Truy vấn
            DataTable dt = new DataTable();
            string query = "Select MaDH, DiaChi_KH, SDT_KH, NgayDatHang, TongTien, HinhThucThanhToan, TrangThaiDH from DON_HANG where TrangThaiDH like N'%" + trangthai + "%'";

            //Thực thi
            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);

            dt = a.Tables[0];
            cn.Close();
            return dt;
        }
    }
}
