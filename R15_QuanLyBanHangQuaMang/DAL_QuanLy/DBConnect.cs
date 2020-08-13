using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        //class DBConnect se chua connection
        protected SqlConnection conn = new SqlConnection("Data Source=Meo-PC;Initial Catalog=QuanLyBanHangQuaMang;Integrated Security=True");

    }
}
