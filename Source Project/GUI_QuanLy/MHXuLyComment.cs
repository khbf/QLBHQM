using BUS_QuanLy;
using DTO_QuanLy;
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
    public partial class MHXuLyComment : Form
    {
        public MHXuLyComment()
        {
            InitializeComponent();
        }


        private void MHXuLyComment_Load(object sender, EventArgs e)
        {
            DateTo.Value = DateTime.Now;
            DateFrom.Value = DateTime.Now.AddDays(-6);
            HienThi(DateFrom.Value, DateTo.Value);


        }
        public void HienThi(DateTime dateFrom, DateTime dateTo)
        {
            if (DateTime.Compare(DateFrom.Value, DateTo.Value) < 0)
            {
                // BUS_Comment.Instance.LayDanhSachComment();
                dsComment.DataSource = BUS_Comment.Instance.TimKiemTheoThoiGian(dateFrom, dateTo);

            }
            else
            {
                MessageBox.Show("Nhập thời gian không đúng");
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = DateFrom.Value;
            DateTime dateTo = DateTo.Value;
            if (DateTime.Compare(DateFrom.Value, DateTo.Value) < 0)
            {
                // BUS_Comment.Instance.LayDanhSachComment();
                dsComment.DataSource = BUS_Comment.Instance.TimKiemTheoThoiGian(dateFrom, dateTo);
                if (dsComment.RowCount == 0)
                {
                    MessageBox.Show("Không có commnent");
                }
            }
            else
            {
                MessageBox.Show("Nhập thời gian không đúng");
            }
        }

        private void taoDsCommentXau_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            dsBadComment.Rows.Clear();
            foreach (DataGridViewRow item in dsComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Cmt.Add(new DTO_Comment
                    {
                        MaCMT = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = (DateTime)item.Cells[4].Value,
                        NoiDungCMT = item.Cells[5].Value.ToString(),
                    });


                }


            }
            if (Cmt.Count == 0)
            {
                MessageBox.Show("Không có comment được chọn");
            }
            else
            {
                foreach (var item in Cmt)
                {
                    int n = dsBadComment.Rows.Add();
                    dsBadComment.Rows[n].Cells[1].Value = item.MaCMT;
                    dsBadComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsBadComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsBadComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString();
                    dsBadComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
                MessageBox.Show("Lâp danh sách thành công");
            }

        }

        private void taoDsCommentTot_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            dsGoodComment.Rows.Clear();
            foreach (DataGridViewRow item in dsComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Cmt.Add(new DTO_Comment
                    {

                        MaCMT = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = (DateTime)item.Cells[4].Value,
                        NoiDungCMT = item.Cells[5].Value.ToString(),
                    });


                }

            }
            if (Cmt.Count == 0)
            {
                MessageBox.Show("Không có comment được chọn");
            }
            else
            {
                foreach (var item in Cmt)
                {
                    int n = dsGoodComment.Rows.Add();
                    dsGoodComment.Rows[n].Cells[1].Value = item.MaCMT;
                    dsGoodComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsGoodComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsGoodComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString();
                    dsGoodComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
                MessageBox.Show("Lập danh sách thành công");
            }
        }

        private void hienDsNhanQua_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateFrom.Value, DateTo.Value) < 0)
            {
                // BUS_Comment.Instance.LayDanhSachComment();
                dsNhanQua.DataSource = BUS_Comment.Instance.LayDanhSachNhanQua(DateFrom.Value, DateTo.Value);
                if (dsNhanQua.RowCount == 0)
                {
                    MessageBox.Show("Không có người được nhận quà");
                }
            }
            else
            {
                MessageBox.Show("Nhập thời gian không đúng");
            }

        }

        private void xoaKhoiDsCommentXau_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();

            foreach (DataGridViewRow item in dsBadComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {

                    Cmt.Add(new DTO_Comment
                    {
                        MaCMT = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = Convert.ToDateTime(item.Cells[4].Value),
                        NoiDungCMT = item.Cells[5].Value.ToString()
                    });


                }


            }

            if ((dsBadComment.RowCount - Cmt.Count) == 0)
            {
                MessageBox.Show("Không có comment được chọn");
            }
            else
            {
                dsBadComment.Rows.Clear();
                foreach (var item in Cmt)
                {
                    int n = dsBadComment.Rows.Add();
                    dsBadComment.Rows[n].Cells[1].Value = item.MaCMT;
                    dsBadComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsBadComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsBadComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString("dd'/'MM'/'yyyy");
                    dsBadComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
                MessageBox.Show("Loại khỏi danh sách thành công");
            }
        }

        private void xoaComment_Click(object sender, EventArgs e)
        {
            List<int> MaCMT = new List<int>();
            foreach (DataGridViewRow item in dsBadComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {
                    MaCMT.Add(Convert.ToInt32(item.Cells[1].Value));
                }
            }
            if (MaCMT.Count == 0)
            {
                MessageBox.Show("Không có comment để xoá");
            }
            else
            {
                BUS_Comment.Instance.XoaComment(MaCMT);
                MessageBox.Show("Xoá thành công");
            }
        }

        private void xoaKhoiDsCommentTot_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();

            foreach (DataGridViewRow item in dsGoodComment.Rows)
            {

                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {

                    Cmt.Add(new DTO_Comment
                    {
                        MaCMT = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = Convert.ToDateTime(item.Cells[4].Value),
                        NoiDungCMT = item.Cells[5].Value.ToString()
                    });


                }

            }

            if ((dsGoodComment.RowCount - Cmt.Count) == 0)
            {
                MessageBox.Show("Không có comment được chọn");
            }
            else
            {
                dsGoodComment.Rows.Clear();
                foreach (var item in Cmt)
                {
                    int n = dsGoodComment.Rows.Add();
                    dsGoodComment.Rows[n].Cells[1].Value = item.MaCMT;
                    dsGoodComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsGoodComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsGoodComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString("dd'/'MM'/'yyyy");
                    dsGoodComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
                MessageBox.Show("Loại khỏi danh sách thành công");
            }
        }

        private void chonNhanQua_Click(object sender, EventArgs e)
        {
            List<int> MaCMT = new List<int>();
            foreach (DataGridViewRow item in dsGoodComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {
                    MaCMT.Add(Convert.ToInt32(item.Cells[1].Value));
                }
            }
            if (MaCMT.Count == 0)
            {
                MessageBox.Show("Không có comment để nhận quà");
            }
            else
            {
                BUS_Comment.Instance.ThemDanhSachNhanQua(MaCMT);
                MessageBox.Show("Thêm thành công");

            }
        }


    }
}

