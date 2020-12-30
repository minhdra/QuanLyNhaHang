using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyNhaHang.DAL
{
    class HoaDonDAL
    {
        private string FileText = "HoaDonXuat.txt";
        private string FileText_detail = "HoaDonXuatChiTiet.txt";
        private string FileText_Goods = "HangHoa.txt";
        HanghoaDAL hhDAL = new HanghoaDAL();

        // Tạo ID Random
        private int GetID()
        {
            int i, d = 0;
            List<string> l = new List<string>();
            Random ran = new Random();
            i = ran.Next(1, 100);
            StreamReader sr = new StreamReader(FileText_detail);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                d++;
                l.Add(tmp[0]);
            }
            sr.Close();
            // Check ID
            for (int x = 0; x < d; x++)
            {
                if (l[x] == ("HD" + i))
                {
                    // Random again
                    i = ran.Next(1, 100);
                    x = -1;
                }
            }
            return i;
        }

        public void Them(string tenKH, DateTime ngay, string maKH, double total)
        {
            if( !File.Exists( FileText ) )
            {
                FileStream fs = File.Create( FileText );
                fs.Close();
            }
            StreamReader sr = new StreamReader(FileText);
            string s;
            string BillID = "HD" + GetID();
            int d = 0; // Count
            
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                // Nếu mã khách hàng và ngày đã tồn tại thì break
                if (tmp[3] == maKH && tmp[2] == ngay.ToString("dd/MM/yyyy"))
                {
                    d++;
                    break;
                }
            }
            sr.Close();
            // Nếu mã khách hàng và ngày chưa có trong hệ thống thì tạo mới bản ghi
            if(d == 0)
            {
                StreamWriter sw = new StreamWriter(FileText, true);
                sw.WriteLine(BillID + "#" + tenKH + "#" + ngay.ToString("dd/MM/yyyy") + "#" + maKH + "#" + total);
                sw.Close();
            }
        }

        public void ThemChiTiet(string BillID, string maHH, int SL)
        {
            if(!File.Exists(FileText_detail))
            {
                FileStream fs = File.Create(FileText_detail);
                fs.Close();
            }
            
            StreamWriter sw = new StreamWriter(FileText_detail, true);
            sw.WriteLine(BillID + "#" + maHH + "#" + SL);
            sw.Close();
        }

        public void Sua(string BillID, string tenKH, DateTime ngay, string maKH, double total)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != BillID)
                    result += s + "\n";
                else
                    result += BillID + "#" + tenKH + "#" + ngay.ToString("dd/MM/yyyy") + "#" + maKH + "#" + total + "\n";
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FileText);
            sw.Write(result);
            sw.Close();
        }

        public void SuaChiTiet(string BillID, string maHH, int SL)
        {
            StreamReader sr = new StreamReader(FileText_detail);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[1] == maHH && tmp[0] == BillID)
                    result += BillID + "#" + maHH + "#" + SL + "\n";
                else result += s + "\n";
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FileText_detail);
            sw.Write(result);
            sw.Close();
        }

        public string TimKiem( string name )
        {
            StreamReader sr = new StreamReader( FileText );
            string s, result = "";

            while( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0].ToLower() == name.ToLower() 
                    || tmp[1].ToLower().Contains(name.ToLower()))
                {
                    result += s + "\n";
                    break;
                }
            }

            sr.Close();
            return result;
        }

        public void Xoa( string BillID )
        {
            StreamReader sr1 = new StreamReader( FileText );
            string s, result = "";

            while( (s = sr1.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                if( tmp[0] != BillID )
                    result += s + "\n";
                else
                    continue;
            }
            sr1.Close();
            StreamWriter sw1 = new StreamWriter( FileText );
            sw1.Write( result );
            sw1.Close();

            StreamReader sr2 = new StreamReader(FileText);
            result = "";

            while ((s = sr2.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != BillID)
                    result += s + "\n";
                else
                    continue;
            }
            sr2.Close();
            StreamWriter sw2 = new StreamWriter(FileText);
            sw2.Write(result);
            sw2.Close();
        }
        // Tổng tiền phải trả của 1 khách hàng
        public double TongTien(string maKH, string date)
        {
            StreamReader sr1 = new StreamReader(FileText);

            string s;
            double total = 0;
            while ((s = sr1.ReadLine()) != null)
            {
                string[] tmp1 = s.Split('#');
                if (tmp1[3] == maKH && date == tmp1[2])
                {

                    StreamReader sr2 = new StreamReader(FileText_detail);
                    while ((s = sr2.ReadLine()) != null)
                    {
                        string[] tmp2 = s.Split('#');
                        if (tmp1[0] == tmp2[0])
                        {
                            StreamReader sr3 = new StreamReader(FileText_Goods);
                            while ((s = sr3.ReadLine()) != null)
                            {
                                string[] tmp3 = s.Split('#');
                                if (tmp2[1] == tmp3[0])
                                    total += Convert.ToDouble(tmp3[2]) * Convert.ToDouble(tmp2[2]);
                            }
                            sr3.Close();
                        }
                    }
                    sr2.Close();
                }
            }

            sr1.Close();

            return total;
        }



        public List<string> Laydanhsach()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader( FileText );
            string s, result;

            while( (s = sr.ReadLine()) != null )
            {
                string[] tmp = s.Split( '#' );
                result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4];
                list.Add( result );
            }

            sr.Close();

            return list;
        }

        public string Laythongtin(string ID)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[3] == ID || tmp[0] == ID)
                    result += tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3]  + "\t" + tmp[4] + "\n";
            }
            sr.Close();
            return result;
        }

        public List<string> HienChiTiet(string BillID)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(FileText_detail);
            string s, result;

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');

                if (tmp[0] == BillID)
                {
                    result = hhDAL.LayThongTin(tmp[1]) + "\t" + tmp[2];
                    list.Add(result);
                }
            }
            sr.Close();

            return list;
        }

        public string LayMaHD(string maKH, DateTime ngay)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[3] == maKH && tmp[2] == ngay.ToString("dd/MM/yyyy"))
                    result = tmp[0];
            }
            sr.Close();

            return result;
        }

    }
}
