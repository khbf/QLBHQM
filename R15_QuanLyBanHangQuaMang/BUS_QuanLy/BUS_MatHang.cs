using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_MatHang
    {
        DAL_MatHang dalMatHang = new DAL_MatHang();
        public DataTable LayDanhSachMatHang()
        {
            return dalMatHang.LayDanhSachMatHang();
        }
    }
}
