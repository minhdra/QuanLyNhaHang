using System;
using QuanLyNhaHang.BUS;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Constraint
{
    class constraint
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        
        public string Email(string email)
        {
            bool c = false;
            if (email != "")
                while (!c)
                {
                    for (int x = 0; x < email.Length; x++)
                    {
                        while (email.Length > 17)
                        {
                            Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
                            email = Console.ReadLine();
                        }
                        if ((email[x] >= 0 && email[x] < 48)
                            || (email[x] > 57 && email[x] < 65)
                            || (email[x] > 90 && email[x] < 97) || email[x] > 122)
                        {
                            x = -1;
                            Console.Write("Nhập lại (...@gmail.com): ");
                            email = Console.ReadLine();
                        }
                    }
                    email += "@gmail.com";
                    c = true;
                }
            return email;
        }

        public string NumberPhone(string SDT)
        {
            
            while (true)
            {

                for (int x = 0; x < SDT.Length; x++)
                {
                    // Kiểm tra SDT
                    if (!char.IsDigit(SDT[x])        // Là số
                        || SDT.Length != 10          // 10 ký tự
                        || SDT[0] != '0'             // Bắt đầu bằng số 0
                        || khBUS.checkSDT(SDT) == 1) // Kiểm tra đã tồn tại chưa
                    {
                        Console.Write("Nhập lại: ");
                        SDT = Console.ReadLine();
                        x = -1;
                    }
                }
                if (SDT == "")
                {
                    Console.Write("Nhập lại: ");
                    SDT = Console.ReadLine();
                }
                else
                    break;
            }
            return SDT;
        }

        public DateTime date(string tmp)
        {
            DateTime date = new DateTime();
            bool c = false;
            while (!c)
            {

                try
                {
                    date = DateTime.Parse(tmp);
                }
                catch
                {
                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                    tmp = Console.ReadLine();
                }
                if (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > 2002)
                {
                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                    tmp = Console.ReadLine();
                }
                else
                    c = true;
            }
            return date;
        }

        public string Capitalize(string name)
        {
            name = name.Trim().ToLower().Replace("  ", " ");
            string[] tmp = name.Split(' ');
            string result = "";
            for (int x = 0; x < tmp.Length; x++)
            {
                result += tmp[x][0].ToString().ToUpper();
                for (int i = 1; i < tmp[x].Length; i++)
                    result += tmp[x][i];
                result += " ";
            }
            result = result.Trim();
            return result;
        }
    }
}
