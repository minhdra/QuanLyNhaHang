using System;
using QuanLyNhaHang.BUS;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Constraint
{
    class constraint
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        
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

        public string Email2(string email, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;
            while (true)
            {
                tmp = "Không hợp lệ!";
                int x = 0;
                do
                {
                    while (email.Length > 17 || email == "")
                    {
                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(tmp);

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        Console.Write(new string(' ', email.Length));

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        email = Console.ReadLine();

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(new string(' ', tmp.Length));
                    }
                    if ((email[x] >= 0 && email[x] < 48)
                        || (email[x] > 57 && email[x] < 65)
                        || (email[x] > 90 && email[x] < 97) || email[x] > 122)
                    {
                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(tmp);

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        Console.Write(new string(' ', email.Length));

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        email = Console.ReadLine();

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(new string(' ', tmp.Length));
                        x = -1;
                    }
                } while (x >= email.Length);
                email = email + "@gmail.com";
                break;
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
                        || khBUS.checkNum(SDT) == 1
                        || nvBUS.checkNum(SDT) == 1) // Kiểm tra đã tồn tại chưa
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

        public string NumberPhone2(string SDT, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;

            while (true)
            {

                tmp = "Không hợp lệ!";
                for (int x = 0; x < SDT.Length; x++)
                {
                    // Kiểm tra SDT
                    if (!char.IsDigit(SDT[x])        // Là số
                        || SDT.Length != 10          // 10 ký tự
                        || SDT[0] != '0'             // Bắt đầu bằng số 0
                        || khBUS.checkNum(SDT) == 1
                        || nvBUS.checkNum(SDT) == 1) // Kiểm tra đã tồn tại chưa
                    {
                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(tmp);

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        Console.Write(new string(' ', SDT.Length));

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        SDT = Console.ReadLine();
                        x = -1;

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(new string(' ', tmp.Length));
                    }
                }
                if (SDT == "")
                {
                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(tmp);

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    Console.Write(new string(' ', SDT.Length));

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    SDT = Console.ReadLine();

                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(new string(' ', tmp.Length));
                }
                else
                    break;
            }
            return SDT;
        }

        public string CheckStr(string name, int len)
        {
            while (name == "" || name.Length > len)
            {
                Console.Write("Nhập lại (dưới {0} ký tự): ", len);
                name = Console.ReadLine();
            }
            return name;
        }

        public string CheckStr2(string name, int Len, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;
            while (name.Length > Len || name == "")
            {
                tmp = "Không hợp lệ! Không thể quá " + Len + " ký tự";
                Console.SetCursorPosition(cursorL2, cursorT2);
                Console.Write(tmp);

                //Xóa những gì đã nhập
                Console.SetCursorPosition(cursorL1, cursorT1);
                Console.Write(new string(' ', name.Length));

                Console.SetCursorPosition(cursorL1, cursorT1);
                name = Console.ReadLine();

                Console.SetCursorPosition(cursorL2, cursorT2);
                Console.Write(new string(' ', tmp.Length));
            }
            return name;
        }

        public bool Gender(string genStr)
        {
            bool result = false;
            while (genStr != "0" && genStr != "1" && genStr != "nam" && genStr != "nu")
            {
                Console.Write("Không hợp lệ! Mời nhập lại: ");
                genStr = Console.ReadLine().ToLower();
            }
            if (genStr == "1" || genStr == "nam")
                result = true;
            return result;
        }

        public bool Gender2(string genStr, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            bool result = false;
            string tmp;
            while (genStr != "0" && genStr != "1" && genStr != "nam" && genStr != "nu")
            {
                tmp = "Không hợp lệ!";
                Console.SetCursorPosition(cursorL2, cursorT2);
                Console.Write(tmp);

                //Xóa những gì đã nhập
                Console.SetCursorPosition(cursorL1, cursorT1);
                Console.Write(new string(' ', genStr.Length));

                Console.SetCursorPosition(cursorL1, cursorT1);
                genStr = Console.ReadLine().ToLower();

                Console.SetCursorPosition(cursorL2, cursorT2);
                Console.Write(new string(' ', tmp.Length));
            }
            if (genStr == "1" || genStr == "nam")
                result = true;
            return result;
        }

        public DateTime Date(string DateStr)
        {
            //Create a DateTime, default is "01/01/0001"
            DateTime date = new DateTime();
            while (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > DateTime.Now.Year - 18)
            {

                try
                {
                    date = DateTime.Parse(DateStr);
                }
                catch
                {
                    Console.Write("Không hợp lệ! Mời nhập lại: ");
                    DateStr = Console.ReadLine();
                }
                if (date.Year > DateTime.Now.Year - 18)
                {
                    Console.Write("Không đủ 18 tuổi! Mời nhập lại: ");
                    DateStr = Console.ReadLine();
                }
            }
            return date;
        }

        public DateTime Date2(string DateStr, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;
            DateTime date = new DateTime();
            while (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > DateTime.Now.Year - 18)
            {

                try
                {
                    date = DateTime.Parse(DateStr);
                }
                catch
                {
                    tmp = "Không hợp lệ!";
                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(tmp);

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    Console.Write(new string(' ', DateStr.Length));

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    DateStr = Console.ReadLine();

                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(new string(' ', tmp.Length));
                }
                if(date.Year > DateTime.Now.Year - 18)
                {
                    tmp = "Không đủ 18 tuổi!";
                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(tmp);

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    Console.Write(new string(' ', DateStr.Length));

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    DateStr = Console.ReadLine();

                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(new string(' ', tmp.Length));
                }
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

        public string CMT(string CMTstr)
        {
            while (true)
            {
                for (int x = 0; x < CMTstr.Length; x++)
                {
                    // Kiểm tra CCCD
                    if (!char.IsDigit(CMTstr[x])        // Là số
                        || CMTstr.Length != 12          // 12 ký tự
                        || CMTstr[0] != '0'             // Bắt đầu bằng số 0
                        || khBUS.checkNum(CMTstr) == 1
                        || nvBUS.checkNum(CMTstr) == 1) // Kiểm tra đã tồn tại chưa
                    {
                        Console.Write("Nhập lại: ");
                        CMTstr = Console.ReadLine();
                        x = -1;
                    }
                }
                if (CMTstr == "")
                {
                    Console.Write("Nhập lại: ");
                    CMTstr = Console.ReadLine();
                }
                else
                    break;
            }
            return CMTstr;
        }

        public string CMT2(string CMTstr, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;
            while (true)
            {
                tmp = "Không hợp lệ!";
                for (int x = 0; x < CMTstr.Length; x++)
                {
                    // Kiểm tra CCCD
                    if (!char.IsDigit(CMTstr[x])        // Là số
                        || CMTstr.Length != 12          // 12 ký tự
                        || CMTstr[0] != '0'             // Bắt đầu bằng số 0
                        || khBUS.checkNum(CMTstr) == 1
                        || nvBUS.checkNum(CMTstr) == 1) // Kiểm tra đã tồn tại chưa
                    {

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(tmp);

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        Console.Write(new string(' ', CMTstr.Length));

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        CMTstr = Console.ReadLine();

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(new string(' ', tmp.Length));

                        x = -1;
                    }
                }
                if (CMTstr == "")
                {
                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(tmp);

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    Console.Write(new string(' ', CMTstr.Length));

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    CMTstr = Console.ReadLine();

                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(new string(' ', tmp.Length));
                }
                else
                    break;
            }
            return CMTstr;
        }

        public string Price2(string price, int cursorL1, int cursorT1, int cursorL2, int cursorT2)
        {
            string tmp;

            while (true)
            {

                tmp = "Không hợp lệ!";
                for (int x = 0; x < price.Length; x++)
                {
                    // Kiểm tra
                    if (!char.IsDigit(price[x])        // Là số
                         ) 
                    {
                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(tmp);

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        Console.Write(new string(' ', price.Length));

                        Console.SetCursorPosition(cursorL1, cursorT1);
                        price = Console.ReadLine();
                        x = -1;

                        Console.SetCursorPosition(cursorL2, cursorT2);
                        Console.Write(new string(' ', tmp.Length));
                    }
                }
                if (price == "")
                {
                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(tmp);

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    Console.Write(new string(' ', price.Length));

                    Console.SetCursorPosition(cursorL1, cursorT1);
                    price = Console.ReadLine();

                    Console.SetCursorPosition(cursorL2, cursorT2);
                    Console.Write(new string(' ', tmp.Length));
                }
                else
                    break;
            }
            return price;
        }

        public double Price(double price)
        {
            while (price <= 0)
            {
                try
                {
                    Console.Write("Nhập giá: ");
                    price = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dữ liệu là số!");
                }
            }
            return price;
        }
    }
}
