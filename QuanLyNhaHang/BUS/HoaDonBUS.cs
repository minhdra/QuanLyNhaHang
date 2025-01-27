﻿using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class HoaDonBUS
    {
        private HoaDonDAL hdDAL = new HoaDonDAL();

        public void Them(DateTime ngay, string maKH, double total, string maNV)
        {
            hdDAL.Them(ngay, maKH, total, maNV);
        }

        public void ThemChiTiet(string BillID, string maHH, int SL)
        {
            hdDAL.ThemChiTiet(BillID, maHH, SL);
        }

        public void Sua(string BillID, DateTime ngay, string maKH, double total, string maNV)
        {
            hdDAL.Sua(BillID, ngay, maKH, total, maNV);
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
