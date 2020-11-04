using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class MHTrangChu : Form
    {
        public MHTrangChu()
        {
            InitializeComponent();
        }

        private void quảnLýMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyMatHang qlmh = new MHQuanLyMatHang();
            qlmh.StartPosition = FormStartPosition.CenterScreen;
            qlmh.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyNV ql = new MHQuanLyNV();
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void quảnLýNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyNCC ql = new MHQuanLyNCC();
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void xÉTCOMMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHXuLyComment ql = new MHXuLyComment();
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void gIAOHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHDonGiaoHang ql = new MHDonGiaoHang();
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void tHANHTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHThanhToan ql = new MHThanhToan();
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }
    }
}
