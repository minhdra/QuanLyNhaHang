using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class HoaDonBUS
    {
        private HoaDonDAL hdDAL = new HoaDonDAL();

        public void Them(string tenKH, DateTime ngay, string maKH, double total)
        {
            hdDAL.Them(tenKH, ngay, maKH, total);
        }

        public void ThemChiTiet(string BillID, string maHH, int SL)
        {
            hdDAL.ThemChiTiet(BillID, maHH, SL);
        }

        public void Sua(string BillID, string tenKH, DateTime ngay, string maKH, double total)
        {
            hdDAL.Sua(BillID, tenKH, ngay, maKH, total);
        }

        public void SuaChiTiet(string BillID, string maHH, int SL)
        {
            hdDAL.SuaChiTiet(BillID, maHH, SL);
        }

        public string TimKiem(string BillID)
        {
            return hdDAL.TimKiem(BillID);
        }

        public void Xoa(string BillID)
        {
            hdDAL.Xoa(BillID);
        }

        public int ThongKeNgay(DateTime ngay)
        {
            return hdDAL.Thongkengay(ngay);
        }

        public int ThongKeThang(DateTime thang)
        {
            return hdDAL.Thongkethang(thang);
        }

        public int ThongKeNam(DateTime nam)
        {
            return hdDAL.Thongkenam(nam);
        }

        public double TongTien(string maKH, string date)
        {
            return hdDAL.TongTien(maKH, date);
        }

        public List<string> LayDanhSach()
        {
            return hdDAL.Laydanhsach();
        }

        public List<string> HienChiTiet(string BillID)
        {
            return hdDAL.HienChiTiet(BillID);
        }

        public string LayMaHD(string maKH, DateTime ngay)
        {
            return hdDAL.LayMaHD(maKH, ngay);
        }

        public string LayThongTin(string maKH)
        {
            return hdDAL.Laythongtin(maKH);
        }
    }
}
