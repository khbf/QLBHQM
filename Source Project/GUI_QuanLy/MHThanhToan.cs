using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class MHThanhToan : Form
    {
        private String selectedYear;
        private String selectedMonth;
        private const int numberOfYears = 20;
        private bool cashOptionSelected = false;
        public int? maHoaDon;
        public int? maKH;
        public int? maNV;
        public double? tongTien;

        public MHThanhToan()
        {
            InitializeComponent();

            //monthCB.Items.AddRange(new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            //monthCB.SelectedIndex = 0;
            setYears();
            setMonth();
        }

        private void setYears()
        {
            int currentYearInt = DateTime.Now.Year;
            for (int i = 0; i <= numberOfYears; i++)
            {
                yearCB.Items.Add((currentYearInt + i).ToString());
            }
            yearCB.SelectedIndex = 0;
            selectedYear = yearCB.Items[0].ToString();
        }

        private void setMonth()
        {
            monthCB.Items.Clear();
            int currentMonth = selectedYear == DateTime.Now.Year.ToString() ? DateTime.Now.Month : 1;
            for (int i = currentMonth; i <= 12; i++)
            {
                monthCB.Items.Add(i.ToString());
            }
            monthCB.SelectedIndex = 0;
        }
        
        private Tuple<bool, DTO_ThanhToan> kiemTraThongTinThanhToan()
        {
            if (!maHoaDon.HasValue || !maKH.HasValue || !maNV.HasValue || !tongTien.HasValue)
            {
                MessageBox.Show("Lỗi không tồn tại mã hóa đơn, mã khách hàng, mã nhân viên và tổng tiền!");
                return Tuple.Create<bool, DTO_ThanhToan>(false, null);
            }

            if (!BUS_ThanhToan.Instance.kiemTraThanhToanTonTai(maHoaDon.Value))
            {
                MessageBox.Show("Thanh toán tồn tại!");
                return Tuple.Create<bool, DTO_ThanhToan>(false, null); ;
            }

            DTO_ThanhToan thanhToan = new DTO_ThanhToan(maHoaDon.Value, maKH.Value, maNV.Value, 0, tongTien.Value, "");
            
            if (cashOptionSelected)
            {
                thanhToan.loaiThanhToan = 1;
                //BUS_ThanhToan.Instance.themThanhToan(thanhToan);
                MessageBox.Show("Thanh toán thành công!");
                return Tuple.Create<bool, DTO_ThanhToan>(true, thanhToan);
            }
            string cardNumber = cardNumberTB.Text;
            string cardholder = cardholderTB.Text;
            string cvc = cvcTB.Text;
            if (cardNumber == "" || cardholder == "" || cvc == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin thanh toán");
                return Tuple.Create<bool, DTO_ThanhToan>(false, null); ;
            }
            if (cvc.Length > 3)
            {
                MessageBox.Show("Số CVC không hợp lệ!");
                return Tuple.Create<bool, DTO_ThanhToan>(false, null); ;
            }
            thanhToan.loaiThanhToan = 0;
            thanhToan.soTaiKhoan = cardNumber;
            //BUS_ThanhToan.Instance.themThanhToan(thanhToan);
            MessageBox.Show("Thanh toán thành công!");
            return Tuple.Create<bool, DTO_ThanhToan>(true, thanhToan); ;
        }

        private void thanhToan()
        {
            var result = kiemTraThongTinThanhToan();
            if (result.Item1)
            {
                BUS_ThanhToan.Instance.themThanhToan(result.Item2);
                MessageBox.Show("Thanh toán thành công!");
            } else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin thanh toán!");
            }
        }

        private void setPaymentDisplay(bool cashPayment)
        {
            cashOptionSelected = cashPayment;
            paymentInfoGroupBox.Enabled = !cashPayment;
        }

        // Event functions
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            thanhToan();
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = yearCB.SelectedItem.ToString();
            setMonth();
        }

        private void masterCardRB_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        private void visaRB_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        private void payPalRB_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        private void cashRB_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(true);
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = monthCB.SelectedItem.ToString();
        }
    }
}
