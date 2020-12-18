using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class NhanVienBUS
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();

        public void ThemNV(string maNV, string tenNV, DateTime NgaySinh, bool gioiTinh, string DiaChi, string SDT, string CMT, string Email)
        {
            nvDAL.ThemNV(maNV, tenNV, NgaySinh, gioiTinh, DiaChi, SDT, CMT, Email);
        }

        //public void ThemPV(string maNV, string maKH)
        //{
        //    nvDAL.ThemPhucVu(maNV, maKH);
        //}

        public string ThemTK()
        {
            return nvDAL.ThemTK();
        }

        public void DoiMK(string TK, string MK)
        {
            nvDAL.DoiMK(TK, MK);
        }

        public int DangNhap(string TK, string MK)
        {
            return nvDAL.DangNhap(TK, MK);
        }

        public bool checkTK(string TK)
        {
            return nvDAL.checkTK(TK);
        }

        public bool checkNV(string maNV)
        {
            return nvDAL.checkNV(maNV);
        }

        public void SuaNV(string maNV, string tenNV, DateTime NgaySinh, bool gioiTinh, string DiaChi, string SDT, string CMT, string Email)
        {
            nvDAL.SuaNV(maNV, tenNV, NgaySinh, gioiTinh, DiaChi, SDT, CMT, Email);
        }

        //public void SuaPV(string maNV, string maKH)
        //{
        //    nvDAL.SuaPV(maNV, maKH);
        //}

        public void SuaTK(string TK, string MK, string maNV)
        {
            nvDAL.SuaTK(TK, MK, maNV);
        }

        public string TimKiem(string maNV)
        {
            return nvDAL.TimKiem(maNV);
        }

        public void Xoa(string maNV)
        {
            nvDAL.Xoa(maNV);
        }

        public List<string> Laydanhsach()
        {
            return nvDAL.Laydanhsach();
        }

        //public List<string> HienPhucVu(string maNV)
        //{
        //    return nvDAL.HienPhucVu(maNV);
        //}

        public string LaythongtinTK(string TK) => nvDAL.LaythongtinTK(TK);

        public string Laythongtin(string maNV) => nvDAL.Laythongtin(maNV);

        public int checkNum(string Num)
        {
            return nvDAL.checkNum(Num);
        }
    }
}
