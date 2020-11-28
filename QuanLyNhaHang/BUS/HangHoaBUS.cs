using QuanLyNhaHang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.BUS
{
    class HangHoaBUS
    {
        private HanghoaDAL hhDAL = new HanghoaDAL();

        public void Them(string tenhh, int gia)
        {
            hhDAL.Them(tenhh, gia);
        }

        public void Sua(string ID, string tenhh, int gia)
        {
            hhDAL.Sua(ID, tenhh, gia);
        }

        public void Xoa(string ID)
        {
            hhDAL.Xoa(ID);
        }

        public List<string> Laydanhsach()
        {
            return hhDAL.LayDanhSach();
        }

        public string Laythongtin(string ID)
        {
            return hhDAL.LayThongTin(ID);
        }
    }
}
