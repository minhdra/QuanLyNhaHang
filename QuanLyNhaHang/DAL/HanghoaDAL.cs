using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyNhaHang.DAL
{
    public class HanghoaDAL
    {
        private string FileText = "HangHoa.txt";

        private int GetID()
        {
            int i, d = 0;
            List<string> l = new List<string>();
            Random ran = new Random();
            i = ran.Next(1, 100);
            StreamReader sr = new StreamReader(FileText);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                d++;
                l.Add(tmp[0]);
            }
            sr.Close();
            // Kiểm tra mã hàng hóa đã tồn tại chưa
            for (int x = 0; x < d; x++)
            {
                if (l[x] == ("HH" + i))
                {
                    i = ran.Next(1, 100);
                    x = -1;
                }
            }
            return i;
        }

        public void Them(string ten, int gia)
        {
            if (!File.Exists(FileText))
            {
                FileStream fs = File.Create(FileText);
                fs.Close();
            }
            string ID = "HH" + GetID();
            StreamWriter sw = new StreamWriter(FileText, true);
            sw.WriteLine(ID + "#" + ten + "#" + gia);
            sw.Close();
        }

        public void Sua(string ID, string ten, int gia)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != ID)
                    result += s + "\n";
                else
                    result += ID + "#" + ten + "#" + gia + "\n";
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FileText);
            sw.Write(result);
            sw.Close();
        }

        public void Xoa(string ID)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != ID)
                    result += s + "\n";
                else
                    continue;
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FileText);
            sw.Write(result);
            sw.Close();
        }

        public List<string> LayDanhSach()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(FileText);
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

        public string LayThongTin(string ID)
        {
            StreamReader sr = new StreamReader(FileText);
            string s, result = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');

                if (tmp[0] == ID)
                    result = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2];
            }

            sr.Close();

            return result;
        }

    }
}

