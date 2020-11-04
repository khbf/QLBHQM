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
    public class DAL_MatHang 
    {

        public static DAL_MatHang instance;
        public static DAL_MatHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_MatHang();
                return instance;
            }
        }
        private DAL_MatHang() { }

        //Lay toan bo danh sach mat hang ve
        public DataTable LayDanhSachMatHang()                    
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaMH", typeof(int));
            table.Columns.Add("TenMH", typeof(string));
            table.Columns.Add("LoaiMH", typeof(string));
            table.Columns.Add("TenNCC", typeof(string));
            table.Columns.Add("SoLuongTon", typeof(int));
            table.Columns.Add("SoLuongHangToiThieu", typeof(int));
            table.Columns.Add("GiaTien", typeof(decimal));
            table.Columns.Add("TenNV", typeof(string));

            string query = "Select MH.MaMH, MH.TenMH, MH.LoaiMH, NCC.TenNCC, MH.SoLuongTon, MH.SoLuongHangToiThieu, MH.GiaTien, NV.TenNV from MAT_HANG MH, NCC, NHAN_VIEN NV where MH.NCC = NCC.MaNCC and MH.NVQuanLy = NV.MaNV";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaMH"] = (int)item["MaMH"];
                row["TenMH"] = item["TenMH"].ToString();
                row["LoaiMH"] = item["LoaiMH"].ToString();
                row["TenNCC"] = item["TenNCC"].ToString();
                row["SoLuongTon"] = (int)item["SoLuongTon"];
                row["SoLuongHangToiThieu"] = (int)item["SoLuongHangToiThieu"];
                row["GiaTien"] = (decimal)item["GiaTien"];
                row["TenNV"] = item["TenNV"].ToString();

                table.Rows.Add(row);
            }
            return table;
        }

        // Them mat hang
        public bool ThemMatHang(DTO_MatHang mh)             
        {
            string query = "Insert INTO MAT_HANG(TenMH , NCC , LoaiMH , SoLuongTon , SoLuongHangToiThieu , GiaTien , NVQuanLy) VALUES ( @TenMH , @NCC , @LoaiMH , @SoLuongTon , @SoLuongHangToiThieu , @GiaTien , @NVQuanLy ) ";
            object[] para = new object[] { mh.TenMH, mh.NCC, mh.LoaiMH, mh.SoLuongTon, mh.SoLuongHangToiThieu, mh.GiaTien, mh.NVQuanLy };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Đọc thông tin mặt hàng
        public DTO_MatHang DocThongTinMH(string tenmh, int ncc)     
        {
            string query = "Select * From MAT_HANG where TenMH = @TenMH and NCC = @NCC";
            object[] para = new object[] { tenmh , ncc };
            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaMH = (int)item["MaMH"];
                string TenMH = item["TenMH"].ToString();
                string LoaiMH = item["LoaiMH"].ToString();
                int NCC = (int)item["NCC"];
                int SoLuongTon = (int)item["SoLuongTon"];
                int SoLuongHangToiThieu = (int)item["SoLuongHangToiThieu"];
                decimal GiaTien = (decimal)item["GiaTien"];
                int NVQuanLy = (int)item["NVQuanLY"];

                DTO_MatHang newmh = new DTO_MatHang(MaMH, TenMH, NCC, LoaiMH, SoLuongTon, SoLuongHangToiThieu, GiaTien, NVQuanLy);
                return newmh;
            }
            return null;
        }
       
        //Cập nhật mặt hàng
        public bool CapNhatMH(DTO_MatHang mh)        
        {
            string query = "Update MAT_HANG set TenMH = @TenMH , NCC = @NCC , LoaiMH = @LoaiMH , SoLuongTon = @SoLuongTon , SoLuongHangToiThieu = @SoLuongHangToiThieu , GiaTien = @GiaTien , NVQuanLy = @NVQuanLy where MaMH = @MaMH";
            object[] para = new object[] { mh.TenMH, mh.NCC, mh.LoaiMH, mh.SoLuongTon, mh.SoLuongHangToiThieu, mh.GiaTien, mh.NVQuanLy, mh.MaMH };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Xóa mặt hàng
        public bool XoaMatHang(int mamh)       
        {
            string query = "DELETE FROM MAT_HANG Where MaMH= @MaMH ";
            object[] para = new object[] { mamh };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Tìm kiếm theo tên mặt hàng
        public DataTable TimKiemTheoTenMH(string tenmh)                       
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //tao cau truy van
            DataTable dt = new DataTable();
            string query = "Select MH.MaMH, MH.TenMH, MH.LoaiMH, NCC.TenNCC, MH.SoLuongTon, MH.SoLuongHangToiThieu, MH.GiaTien, NV.TenNV from MAT_HANG MH, NCC, NHAN_VIEN NV where MH.NCC = NCC.MaNCC and MH.NVQuanLy = NV.MaNV and MH.TenMH like N'%" + tenmh + "%'";
            
            //thuc thi cau truy van
            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);

            //lay du lieu tra ve
            dt = a.Tables[0];
            cn.Close();
            return dt;
        }

        //Tìm kiếm theo tên ncc
        public DataTable TimKiemTheoTenNCC(string tenncc)                        
        {
            SqlConnection cn;
            cn = DBConnect.Connect();

            DataTable dt = new DataTable();
            string query = "Select MH.MaMH, MH.TenMH, MH.LoaiMH, NCC.TenNCC, MH.SoLuongTon, MH.SoLuongHangToiThieu, MH.GiaTien, NV.TenNV from MAT_HANG MH, NCC, NHAN_VIEN NV where MH.NCC = NCC.MaNCC and MH.NVQuanLy = NV.MaNV and NCC.TenNCC like N'%" + tenncc + "%'";

            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);
            dt = a.Tables[0];
            cn.Close();
            return dt;
        }

        //Tìm kiếm theo tên NV quan ly
        public DataTable TimKiemTheoTenNVQuanLy(string tennv)                      
        {
            SqlConnection cn;
            cn = DBConnect.Connect();

            DataTable dt = new DataTable();
            string query = "Select MH.MaMH, MH.TenMH, MH.LoaiMH, NCC.TenNCC, MH.SoLuongTon, MH.SoLuongHangToiThieu, MH.GiaTien, NV.TenNV from MAT_HANG MH, NCC, NHAN_VIEN NV where MH.NCC = NCC.MaNCC and MH.NVQuanLy = NV.MaNV and NV.TenNV like N'%" + tennv + "%'";

            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);
            dt = a.Tables[0];
            cn.Close();
            return dt;
        }
    }
}
