using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace QuanLyNhaHang.DAL
{
    class KhachHangDAL
    {
        private string FileText = "KhachHang.txt";
        private string ACC = "TaiKhoanKhach.txt";
        public int GetID()
        {
            int i, d = 0;
            List<string> l = new List<string>();
            Random ran = new Random();
            i = ran.Next(1, 100);
            StreamReader sr = new StreamReader(ACC);
            string s;
            while((s = sr.ReadLine())!= null)
            {
                string[] tmp = s.Split('#');
                d++;
                l.Add(tmp[2]);
            }
            sr.Close();
            // Kiểm tra mã khách hàng đã tồn tại chưa
            for(int x = 0; x < d; x++)
            {
                if(l[x] == ("KH" + i))
                {
                    i = ran.Next(1, 100);
                    x = -1;
                }
            }
            return i;
        }

        public void Them(string maKH, string tenKH, string DiaChi, string SDT, string Email)
        {
            if( !File.Exists( FileText ) )
            {
                FileStream fs = File.Create(FileText);
                fs.Close();
            }
            StreamWriter sw = new StreamWriter( FileText, true );
            sw.WriteLine( maKH + "#" + tenKH + "#" + DiaChi + "#" + SDT + "#" + Email);
            sw.Close();
        }


        public void Sua(string maKH, string tenKH, string DiaChi, string SDT, string Email)
        {
            StreamReader sr = new StreamReader( FileText );
            string s, result = "";

            while( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0] != maKH )
                    result += s + "\n";
                else
                {
                    result += maKH + "#" + tenKH + "#" + DiaChi + "#" + SDT + "#" + Email + "\n";
                }
            }

            sr.Close();

            StreamWriter sw = new StreamWriter( FileText );
            sw.Write( result );
            sw.Close();
        }

        public void SuaTK(string TK, string MK, string maKH)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maKH)
                    result += s + "\n";
                else
                {
                    result += TK + "#" + MK + "#" + maKH + "\n";
                }
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(ACC);
            sw.Write(result);
            sw.Close();
        }

        public string TimKiem( string name )
        {
            StreamReader sr = new StreamReader( FileText );
            string s, resultName = "", resultID = "";
            int check = 0;

            while ( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if (tmp[0].ToLower() == name.ToLower())
                {
                    check = 1;
                    resultID = s;
                    break;
                }
                else if (tmp[1].ToLower().Contains(name.ToLower()))
                {
                    resultName += s + "\n";
                }
            }

            sr.Close();
            if (check == 1)
                return resultID;
            return resultName;
        }

        public void Xoa( string maKH )
        {
            StreamReader sr = new StreamReader( FileText );
            string s, result = "";

            while( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0] != maKH )
                    result += s + "\n";
                else
                    continue;
            }

            sr.Close();

            StreamWriter sw = new StreamWriter( FileText );
            sw.Write( result );
            sw.Close();

            StreamReader sr2 = new StreamReader(ACC);
            result = "";
            while ((s = sr2.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[2] != maKH)
                    result += s + "\n";
                else
                    continue;
            }

            sr2.Close();

            StreamWriter sw2 = new StreamWriter(ACC);
            sw2.Write(result);
            sw2.Close();
        }

        // Kiểm tra số điện thoại đã tồn tại chưa
        public int checkSDT(string SDT)
        {
            StreamReader sr = new StreamReader(FileText);
            string s;
            int check = 0;
            while((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[3] == SDT)
                {
                    check = 1;
                }
            }
            sr.Close();
            return check;
        }

        public List<string> Laydanhsach()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(FileText);
            string s, result;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4];
                list.Add(result);
            }
            sr.Close();

            return list;
        }

        public string Laythongtin(string maKH)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maKH)
                    result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4];
            }
            sr.Close();

            return result;
        }

        public string LaythongtinTK(string TK)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0] == TK || tmp[2] == TK)
                    result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2];
            }

            sr.Close();
            return result;
        }

        public void ThemTK(string TK, string MK)
        {
            if (!File.Exists(ACC))
            {
                FileStream fs = File.Create(ACC);
                fs.Close();
            }
            string maKH = "KH" + GetID();
            string result = TK + "#" + MK + "#" + maKH;

            StreamWriter sw = new StreamWriter(ACC, true);
            sw.WriteLine(result);
            sw.Close();
        }

        public string ThemTKTuDong()
        {
            string maKH = "KH" + GetID();
            string TK = maKH;
            string MK = maKH;
            string result = TK + "#" + MK + "#" + maKH;

            StreamWriter sw = new StreamWriter(ACC, true);
            sw.WriteLine(result);
            sw.Close();

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

        public void DoiMK(string maKH, string MK)
        {
            StreamReader sr = new StreamReader(ACC);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[2] != maKH)
                    result += s + "\n";
                else
                    result += tmp[0] + "#" + MK + "#" + tmp[2] + "\n";
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

        public string QuenMK(string SDT)
        {
            StreamReader sr1 = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr1.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[3] == SDT)
                {
                    StreamReader sr2 = new StreamReader(ACC);
                    while((s = sr2.ReadLine()) != null)
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

    }
}
