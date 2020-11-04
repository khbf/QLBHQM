using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NCC 
    {
        public static DAL_NCC instance;
        public static DAL_NCC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_NCC();
                return instance;
            }
        }
        private DAL_NCC() { }

        //Lay toan bo danh sach NCC cho ben giao dien MH
        public DataTable LayDanhSachNCC_ChoMH()                
        {
            string query = "Select * from NCC";
            DataTable dtNCC = DBConnect.Instance.ExecuteQuery(query);
            return dtNCC;
        }

        //Lay toan bo danh sach ncc hien ra bang
        public DataTable LayDanhSachNCC()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaNCC", typeof(int));
            table.Columns.Add("TenNCC", typeof(string));
            table.Columns.Add("GioiThieu", typeof(string));

            string query = "Select MaNCC, TenNCC, GioiThieu from NCC";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaNCC"] = (int)item["MaNCC"];
                row["TenNCC"] = item["TenNCC"].ToString();
                row["GioiThieu"] = item["GioiThieu"].ToString();

                table.Rows.Add(row);
            }
            return table;
        }

        // Them ncc
        public bool ThemNCC(DTO_NCC ncc)
        {
            string query = "Insert INTO NCC(TenNCC , GioiThieu) VALUES ( @TenNCC , @GioiThieu ) ";
            object[] para = new object[] { ncc.TenNCC, ncc.GioiThieu };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Đọc thông tin ncc thong qua ten ncc
        public DTO_NCC DocThongTinNCC(string tenncc)
        {
            string query = "Select * From NCC where TenNCC = @TenNCC";
            object[] para = new object[] { tenncc };
            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaNCC = (int)item["MaNCC"];
                string TenNCC = item["TenNCC"].ToString();
                string GioiThieu = item["GioiThieu"].ToString();

                DTO_NCC newnv = new DTO_NCC(MaNCC, TenNCC, GioiThieu);
                return newnv;
            }
            return null;
        }

        //Cập nhật thong tin ncc
        public bool CapNhatNCC(DTO_NCC mh)
        {
            string query = "Update NCC set TenNCC = @TenNCC , GioiThieu = @GioiThieu where MaNCC = @MaNCC";
            object[] para = new object[] { mh.TenNCC, mh.GioiThieu, mh.MaNCC };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Xóa NCC
        public bool XoaNCC(int mancc)
        {
            string query = "DELETE FROM NCC Where MaNCC = @MaNCC";
            object[] para = new object[] { mancc };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Tìm kiếm theo tên ncc
        public DataTable TimKiemTheoTenNCC(string tenncc)
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //tao cau truy van
            DataTable dt = new DataTable();
            string query = "Select MaNCC, TenNCC, GioiThieu from NCC where TenNCC like N'%" + tenncc + "%'";

            //thuc thi cau truy van
            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);

            //lay du lieu tra ve
            dt = a.Tables[0];
            cn.Close();
            return dt;
        }
    }
}
