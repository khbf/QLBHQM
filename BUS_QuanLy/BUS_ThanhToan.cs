using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ThanhToan
    {
        private static BUS_ThanhToan instance;
        public static BUS_ThanhToan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_ThanhToan();
                return instance;
            }
        }
        private BUS_ThanhToan() { }

        public bool themThanhToan(DTO_ThanhToan thanhToan)
        {
            return DAL_ThanhToan.instance.themThanhToan(thanhToan);
        }

        public bool kiemTraThanhToanTonTai(int maHoaDon)
        {
            DTO_ThanhToan thanhToan = DAL_ThanhToan.instance.layThanhToan(maHoaDon);
            if (thanhToan == null)
            {
                return false;
            }
            return true;
        }
    }
}
