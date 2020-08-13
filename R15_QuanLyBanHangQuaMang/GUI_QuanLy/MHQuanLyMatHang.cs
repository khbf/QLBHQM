using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class MHQuanLyMatHang : Form
    {
        BUS_MatHang busMatHang = new BUS_MatHang();
        public MHQuanLyMatHang()
        {
            InitializeComponent();
        }
        
        private void dsMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Load danh sach mat hang
        private void MHQuanLyMatHang_Load(object sender, EventArgs e)
        {
            dsMatHang.DataSource = busMatHang.LayDanhSachMatHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dsMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay row hien tai
            DataGridViewRow row = dsMatHang.SelectedRows[0];
            //chuyen gia tri len form
            txtTenMH.Text = row.Cells[2].Value.ToString();
            txtLoaiMH.Text = row.Cells[3].Value.ToString();
            cbbNCC.Text = row.Cells[4].Value.ToString();
            txtSoLuongTon.Text = row.Cells[5].Value.ToString();
            txtSoLuongHangToiThieu.Text = row.Cells[6].Value.ToString();
        }
    }
}
