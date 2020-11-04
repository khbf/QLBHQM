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
    public class DAL_NhanVien
    {
        public static DAL_NhanVien instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_NhanVien();
                return instance;
            }
        }
        private DAL_NhanVien() { }

        //Lay ra danh sach cac nhan vien ban hang
        public DataTable LayDanhSachNhanVienBanHang()               
        {
            string query = "Select * from NHAN_VIEN where LoaiNV like N'%Bán hàng%';";
            DataTable dtNV = DBConnect.Instance.ExecuteQuery(query);
            return dtNV;
        }
        //Lay ra danh sach cot loai nhan vien
        public DataTable LayDanhSachLoaiNV()
        {
            string query = "Select distinct LoaiNV from NHAN_VIEN;";
            DataTable dtNV = DBConnect.Instance.ExecuteQuery(query);
            return dtNV;
        }

        //Lay toan bo danh sach nhan vien hien ra bang
        public DataTable LayDanhSachNhanVien()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaNV", typeof(int));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("SDT_NV", typeof(string));
            table.Columns.Add("LoaiNV", typeof(string));

            string query = "Select MaNV, TenNV, Email, MatKhau, SDT_NV, LoaiNV from NHAN_VIEN";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaNV"] = (int)item["MaNV"];
                row["TenNV"] = item["TenNV"].ToString();
                row["Email"] = item["Email"].ToString();
                row["MatKhau"] = item["MatKhau"].ToString();
                row["SDT_NV"] = item["SDT_NV"].ToString();
                row["LoaiNV"] = item["LoaiNV"].ToString();

                table.Rows.Add(row);
            }
            return table;
        }

        // Them NV
        public bool ThemNV(DTO_NhanVien nv)
        {
            string query = "Insert INTO NHAN_VIEN(TenNV , Email , MatKhau , SDT_NV , LoaiNV) VALUES ( @TenNV , @Email , @MatKhau , @SDT_NV , @LoaiNV ) ";
            object[] para = new object[] { nv.TenNV, nv.Email, nv.MatKhau, nv.SDT_NV, nv.LoaiNV };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Đọc thông tin NV thong qua email
        public DTO_NhanVien DocThongTinNV_Email(string email)
        {
            string query = "Select * From NHAN_VIEN where Email = @Email";
            object[] para = new object[] { email };
            DataTable data = DBConnect.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaNV = (int)item["MaNV"];
                string TenNV = item["TenNV"].ToString();
                string Email = item["Email"].ToString();
                string MatKhau = item["MatKhau"].ToString();
                string SDT_NV = item["SDT_NV"].ToString();
                string LoaiNV = item["LoaiNV"].ToString();

                DTO_NhanVien newnv = new DTO_NhanVien(MaNV, TenNV, Email, MatKhau, SDT_NV, LoaiNV);
                return newnv;
            }
            return null;
        }

        //Cập nhật thong tin NV
        public bool CapNhatNV(DTO_NhanVien mh)      //Khong cho cap nhat lai email
        {
            string query = "Update NHAN_VIEN set TenNV = @TenNV , MatKhau = @MatKhau , SDT_NV = @SDT_NV , LoaiNV = @LoaiNV where MaNV = @MaNV";
            object[] para = new object[] { mh.TenNV, mh.MatKhau, mh.SDT_NV, mh.LoaiNV, mh.MaNV };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }


        //Xóa NV
        public bool XoaNV(int manv, string loainv)
        {
            string query = "DELETE FROM NHAN_VIEN Where MaNV= @MaNV and LoaiNV not like N'%Quản lý%'";
            object[] para = new object[] { manv };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //Tìm kiếm theo tên nv
        public DataTable TimKiemTheoTenNV(string tennv)
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //tao cau truy van
            DataTable dt = new DataTable();
            string query = "Select MaNV, TenNV, Email, MatKhau, SDT_NV, LoaiNV from NHAN_VIEN where TenNV like N'%" + tennv + "%'";

            //thuc thi cau truy van
            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataSet a = new DataSet();
            adp.Fill(a);

            //lay du lieu tra ve
            dt = a.Tables[0];
            cn.Close();
            return dt;
        }

        //Tìm kiếm theo loai nv
        public DataTable TimKiemTheoLoaiNV(string loainv)
        {
            //connect
            SqlConnection cn;
            cn = DBConnect.Connect();

            //tao cau truy van
            DataTable dt = new DataTable();
            string query = "Select MaNV, TenNV, Email, MatKhau, SDT_NV, LoaiNV from NHAN_VIEN where LoaiNV like N'%" + loainv + "%'";

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
