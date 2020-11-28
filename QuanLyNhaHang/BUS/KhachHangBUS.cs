using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class KhachHangBUS
    {
        private KhachHangDAL khDAL = new KhachHangDAL();

        public void Them(string maKH, string tenKH, string DiaChi, string SDT, string Email)
        {
            khDAL.Them(maKH, tenKH, DiaChi, SDT, Email);
        }

        public void ThemTK(string TK, string MK)
        {
            khDAL.ThemTK(TK, MK);
        }

        public void DoiMK(string maKH, string MK)
        {
            khDAL.DoiMK(maKH, MK);
        }

        public int DangNhap(string TK, string MK)
        {
            return khDAL.DangNhap(TK, MK);
        }

        public bool CheckTK(string TK)
        {
            return khDAL.checkTK(TK);
        }

        public void Sua(string maKH, string tenKH, string DiaChi, string SDT, string Email)
        {
            khDAL.Sua(maKH, tenKH, DiaChi, SDT, Email);
        }

        public void SuaTK(string TK, string MK, string maKH)
        {
            khDAL.SuaTK(TK, MK, maKH);
        }

        public string TimKiem(string maKH)
        {
            return khDAL.TimKiem(maKH);
        }

        public void Xoa(string maKH)
        {
            khDAL.Xoa(maKH);
        }

        public List<string> Laydanhsach()
        {
            return khDAL.Laydanhsach();
        }

        public string LaythongtinTK(string TK)
        {
            return khDAL.LaythongtinTK(TK);
        }

        public string Laythongtin(string maKH)
        {
            return khDAL.Laythongtin(maKH);
        }

        public string QuenMK(string SDT)
        {
            return khDAL.QuenMK(SDT);
        }

        public int checkSDT(string SDT)
        {
            return khDAL.checkSDT(SDT);
        }
    }
}