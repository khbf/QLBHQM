using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    class DTO_NCC
    {
        private int _maNCC;
        private string _tenNCC;
        private string _gioiThieu;

        /* ======== GETTER/SETTER ======== */
        public int MaNCC
        {
            get { return _maNCC; }

            set { _maNCC = value; }
        }
        public string TenNCC
        {
            get { return _tenNCC; }

            set { _tenNCC = value; }
        }
        public string GioiThieu
        {
            get { return _gioiThieu; }

            set { _gioiThieu = value; }
        }
        /* === Constructor === */
        public DTO_NCC()
        {
        }

        public DTO_NCC(int mancc, string tenncc, string gioithieu)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.GioiThieu = gioithieu;
        }
    }
}
