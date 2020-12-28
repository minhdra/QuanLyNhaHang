using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class KhachHangBUS
    {
        private KhachHangDAL khDAL = new KhachHangDAL();

        public void Them(string maKH, string tenKH, DateTime NgaySinh, bool gioiTinh,
            string DiaChi, string SDT, string CMT, string Email)
        {
            khDAL.Them(maKH, tenKH, NgaySinh, gioiTinh, DiaChi, SDT, CMT, Email);
        }

        public void ThemTK(string TK, string MK)
        {
            khDAL.ThemTK(TK, MK);
        }

        public string ThemTKTuDong()
        {
            return khDAL.ThemTKTuDong();
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

        public void Sua(string maKH, string tenKH, DateTime NgaySinh, bool gioiTinh,
            string DiaChi, string SDT, string CMT, string Email)
        {
            khDAL.Sua(maKH, tenKH, NgaySinh, gioiTinh, DiaChi, SDT, CMT, Email);
        }

        public void SuaTK(string TK, string MK, string maKH)
        {
            khDAL.SuaTK(TK, MK, maKH);
        }

        public string TimKiem(string name)
        {
            return khDAL.TimKiem(name);
        }

        public void Xoa(string maKH)
        {
            khDAL.Xoa(maKH);
        }

        public List<string> Laydanhsach()
        {
            return khDAL.Laydanhsach();
        }

        public List<string> LaydanhsachAcc() => khDAL.LaydanhsachAcc();

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

        public int checkNum(string Num)
        {
            return khDAL.checkNum(Num);
        }

        public int Count() => khDAL.Count();

        public int CountAcc() => khDAL.CountAcc();

        public void Sort()
        {
            khDAL.Sort();
        }
    }
}