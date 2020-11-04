using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Comment
    {
        public int MaCMT { get; set; }
        public string TenKH { get; set; }
        public string MaMH { get; set; }
        //public int LoaiCMT { get; set; }
        public DateTime NgayCMT { get; set; }
        public string NoiDungCMT { get; set; }    	
    }
}
