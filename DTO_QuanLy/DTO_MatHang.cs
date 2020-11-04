using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_MatHang
    {
        private int _maMH;
        private string _tenMH;
        private int _ncc;
        private string _loaiMH;
        private int _soLuongTon;
        private int _soLuongHangToiThieu;
        private decimal _giaTien;
        private int _nvQuanLy;

        /* ======== GETTER/SETTER ========*/
        
        public int MaMH
        {
            get { return _maMH; }

            set { _maMH = value; }
        }
        
        public string TenMH
        {
            get { return _tenMH; }

            set { _tenMH = value; }
        }

        public int NCC
        {
            get
            {
                return _ncc;
            }

            set
            {
                _ncc = value;
            }
        }

        public string LoaiMH
        {
            get
            {
                return _loaiMH;
            }

            set
            {
                _loaiMH = value;
            }
        }
        public int SoLuongTon
        {
            get
            {
                return _soLuongTon;
            }

            set
            {
                _soLuongTon = value;
            }
        }
        public int SoLuongHangToiThieu
        {
            get
            {
                return _soLuongHangToiThieu;
            }

            set
            {
                _soLuongHangToiThieu = value;
            }
        }
        public decimal GiaTien
        {
            get
            {
                return _giaTien;
            }

            set
            {
                _giaTien = value;
            }
        }
        public int NVQuanLy
        {
            get { return _nvQuanLy; }

            set { _nvQuanLy = value; }
        }
        /* === Constructor === */
        public DTO_MatHang()
        {

        }

        public DTO_MatHang(int mamh, string tenmh, int ncc, string loaimh, int slton, int slhangtoithieu, decimal giatien, int nvquanly)
        {
            this.MaMH = mamh;
            this.TenMH = tenmh;
            this.NCC = ncc;
            this.LoaiMH = loaimh;
            this.SoLuongTon = slton;
            this.SoLuongHangToiThieu = slhangtoithieu;
            this.GiaTien = giatien;
            this.NVQuanLy = nvquanly;
        }
        public DTO_MatHang(string tenmh, int ncc, string loaimh, int slton, int slhangtoithieu, decimal giatien, int nvquanly)
        {
            //this.MaMH = mamh;
            this.TenMH = tenmh;
            this.NCC = ncc;
            this.LoaiMH = loaimh;
            this.SoLuongTon = slton;
            this.SoLuongHangToiThieu = slhangtoithieu;
            this.GiaTien = giatien;
            this.NVQuanLy = nvquanly;
        }
    }
}

