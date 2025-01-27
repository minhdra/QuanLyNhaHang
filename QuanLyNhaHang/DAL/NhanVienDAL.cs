﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyNhaHang.DAL
{
    class NhanVienDAL
    {
        private string FileText = "NhanVien.txt";
        //private string FileText_inCharge = "PhucVu.txt";
        private string ACC = "TaiKhoanNV.txt";

        // Tạo ID Random
        public int GetID()
        {
            int i, d = 0;
            List<string> l = new List<string>();
            Random ran = new Random();
            i = ran.Next(1, 100);
            StreamReader sr = new StreamReader(ACC);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                d++;
                l.Add(tmp[2]);
            }
            sr.Close();
            // Kiểm tra mã nhân viên đã tồn tại chưa
            for (int x = 0; x < d; x++)
            {
                if (l[x] == ("NV" + i))
                {
                    i = ran.Next(1, 100);
                    x = -1;
                }
            }
            return i;
        }

        public void ThemNV( string maNV, string tenNV, DateTime NgaySinh, bool gioiTinh, string DiaChi, string SDT, string CMT, string Email, string ChucVu )
        {
            if( !File.Exists( FileText ) )
            {
                FileStream fs = File.Create(FileText);
                fs.Close();
            }
            string GT;
            if (gioiTinh == true)
                GT = "Nam";
            else
                GT = "Nu";

            StreamWriter sw = new StreamWriter( FileText, true );
            sw.WriteLine( maNV + "#" + tenNV + "#" + NgaySinh.ToString("dd/MM/yyyy") + "#" + GT 
                + "#" + DiaChi + "#" + SDT + "#" + CMT + "#" + Email + "#" + ChucVu);
            sw.Close();
        }

        public string ThemTK()
        {
            if (!File.Exists(ACC))
            {
                FileStream fs = File.Create(ACC);
                fs.Close();
            }
            Random ran = new Random();
            string maNV = "NV" + GetID();
            string TK = maNV;
            string MK = "" + ran.Next(1,10);
            string result = TK + "#" + MK + "#" + maNV;

            StreamWriter sw = new StreamWriter(ACC, true);
            sw.WriteLine(result);
            sw.Close();

            return result;
        }

        public void DoiMK(string TK, string MK)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != TK)
                    result += s + "\n";
                else
                    result += tmp[0] + "#" + MK + "#" + tmp[2];
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(ACC);
            sw.Write(result);
            sw.Close();
        }

        public int DangNhap(string TK, string MK)
        {
            if (!File.Exists(ACC))
            {
                FileStream fs = File.Create(ACC);
                fs.Close();
            }

            StreamReader sr = new StreamReader(ACC);
            string s;
            int result = 0;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == TK && tmp[1] == MK)
                {
                    result = 1;
                    break;
                }
            }

            sr.Close();

            return result;
        }

        public bool checkTK(string TK)
        {
            if (!File.Exists(ACC))
            {
                FileStream fs = File.Create(ACC);
                fs.Close();
            }

            StreamReader sr = new StreamReader(ACC);
            string s;
            bool check = false;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == TK)
                    check = true;
            }
            sr.Close();

            return check;
        }

        public void SuaTK(string TK, string MK, string maNV)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maNV)
                    result += s + "\n";
                else
                {
                    result += TK + "#" + MK + "#" + maNV + "\n";
                }
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(ACC);
            sw.Write(result);
            sw.Close();
        }

        public bool checkNV(string maNV)
        {
            if (!File.Exists(FileText))
            {
                FileStream fs = File.Create(FileText);
                fs.Close();
            }
            StreamReader sr = new StreamReader(FileText);
            string s;
            bool check = false;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maNV)
                    check = true;
            }

            return check;
        }

        public void SuaNV(string maNV, string tenNV, DateTime NgaySinh, bool gioiTinh, string DiaChi, string SDT, string CMT, string Email)
        {
            StreamReader sr = new StreamReader( FileText );
            string s, result = "";

            string GT;
            if (gioiTinh == true)
                GT = "Nam";
            else
                GT = "Nu";

            while ( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0] != maNV )
                    result += s + "\n";
                else
                    result += maNV + "#" + tenNV + "#" + NgaySinh.ToString("dd/MM/yyyy") + "#" + GT 
                        + "#" + DiaChi + "#" + SDT + "#" + CMT + "#" + Email + "#" + tmp[8];
            }
            sr.Close();
            StreamWriter sw = new StreamWriter( FileText );
            sw.Write( result );
            sw.Close();
        }

        public void SuaCV(string maNV, string ChucVu)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maNV)
                    result += s + "\n";
                else
                    result += maNV + "#" + tmp[1] + "#" + tmp[2] + "#" + tmp[3]
                        + "#" + tmp[4] + "#" + tmp[5] + "#" + tmp[6] + "#" + tmp[7] + "#" + ChucVu;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(FileText);
            sw.Write(result);
            sw.Close();
        }

        public string TimKiem(string name)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[1].ToLower().Contains(name.ToLower()) 
                    || tmp[0].ToLower() == name.ToLower())
                {
                    result += s + "\n";
                }
            }

            sr.Close();
            return result;
        }

        public void Xoa( string maNV )
        {
            StreamReader sr1 = new StreamReader( FileText );
            string s, result = "";

            while( (s = sr1.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0] != maNV )
                    result += s + "\n";
                else
                    continue;
            }
            sr1.Close();
            StreamWriter sw1 = new StreamWriter( FileText );
            sw1.Write( result );
            sw1.Close();


            StreamReader sr2 = new StreamReader(ACC);
            result = "";
            while ((s = sr2.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[2] != maNV)
                    result += s + "\n";
                else
                    continue;
            }

            sr2.Close();

            StreamWriter sw2 = new StreamWriter(ACC);
            sw2.Write(result);
            sw2.Close();
        }

        public int checkNum(string Num)
        {
            StreamReader sr = new StreamReader(FileText);
            string s;
            int check = 0;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[3] == Num || tmp[6] == Num)
                {
                    check = 1;
                }
            }
            sr.Close();
            return check;
        }

        public string QuenMK(string SDT)
        {
            StreamReader sr1 = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr1.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[3] == SDT)
                {
                    StreamReader sr2 = new StreamReader(ACC);
                    while ((s = sr2.ReadLine()) != null)
                    {
                        string[] tmp2 = s.Split('#');
                        if (tmp2[2] == tmp[0])
                        {
                            result = "Tài khoản: " + tmp2[0] + "\nMật khẩu: " + tmp2[1];
                            sr2.Close();
                            break;
                        }
                    }
                    break;
                }
            }
            sr1.Close();

            return result;
        }

        public List<string> Laydanhsach()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(FileText);
            string s, result;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" 
                    + tmp[4] + "\t" + tmp[5] + "\t" + tmp[6] + "\t" + tmp[7] + "\t" + tmp[8];
                list.Add(result);
            }
            sr.Close();

            return list;
        }

        public List<string> LaydanhsachAcc()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(ACC);
            string s, result;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2];
                list.Add(result);
            }
            sr.Close();

            return list;
        }

        public string LaythongtinTK(string TK)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == TK || tmp[2] == TK)
                    result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2];
            }

            sr.Close();
            return result;
        }

        public string Laythongtin(string maNV)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maNV)
                {
                    result = s;
                    break;
                }
            }

            sr.Close();
            return result;
        }

        public int Count()
        {
            int d = 0;
            StreamReader sr = new StreamReader(FileText);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                d++;
            }
            sr.Close();
            return d;
        }

        public int CountAcc()
        {
            int d = 0;
            StreamReader sr = new StreamReader(ACC);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                d++;
            }
            sr.Close();
            return d;
        }
    }
}
