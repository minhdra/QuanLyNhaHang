using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.SHOW
{
    // 1 Nhân viên
    class NhanVienPre
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();

        public void HienMenuNV(string maNV)
        {

            while (true)
            {
                // Kiểm tra khách có tồn tại
                int check = 0;
                if (nvBUS.TimKiem(maNV) != "")
                {
                    check = 1;
                }

                Console.Clear();

                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                             CHÀO BẠN                              ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║       THÊM THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║        XEM THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║         ĐỔI MẬT KHẨU         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(65, 29);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        if (check == 0)
                            ThemThongTin(maNV);
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN ĐÃ THÊM THÔNG TIN RỒI                     ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                        }
                        Console.ReadKey();
                        break;
                    case '2':
                        if (check == 0)
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN CHƯA THÊM THÔNG TIN                       ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                            SuaThongTin(maNV);
                        break;
                    case '3':
                        if (check == 0)
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN CHƯA THÊM THÔNG TIN                       ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                        }
                        else
                            XemThongTin(maNV);
                        Console.ReadKey();
                        break;
                    case '4':
                        DoiMatKhau(maNV);
                        Console.ReadKey();
                        break;
                    case '9':
                        TaiKhoanPre.NhanVien tknv = new TaiKhoanPre.NhanVien();
                        tknv.HienMenuNV();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        HienMenuNV(maNV);
                        break;
                }
            }
        }

        private void ThemThongTin(string maNV)
        {
            Console.Clear();
            Console.WriteLine("Thêm thông tin hoặc nhấn 'Enter' để thoát!");
            Console.Write("Họ tên: ");
            string tenNV = Console.ReadLine();
            if (tenNV != "")
            {
                while (tenNV.Length > 27)
                {
                    Console.Write("Nhập lại (dưới 27 ký tự): ");
                    tenNV = Console.ReadLine();
                }
                Console.Write("Sinh nhật (dd/MM/yyyy): ");
                string tmp = Console.ReadLine();
                DateTime date = new DateTime();
                bool check = false;
                while (!check)
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
                        check = true;
                }

                Console.Write("Giới tính (1 : Nam, 0: Nữ): ");
                string chose = Console.ReadLine();
                bool GT = false;
                while (chose != "0" && chose != "1")
                {
                    Console.Write("Không hợp lệ! Nhập lại: ");
                    chose = Console.ReadLine().ToUpper();
                }
                if (chose == "1")
                    GT = true;

                Console.Write("Địa chỉ: ");
                string dchi = Console.ReadLine();
                while (dchi == "" || dchi.Length > 17)
                {
                    Console.Write("Nhập lại (dưới 17 ký tự): ");
                    dchi = Console.ReadLine();
                }

                // SDT có 10 ký tự và bắt đầu bằng số 0
                Console.Write("Số điện thoại: ");
                string SDT = Console.ReadLine();
                while (true)
                {

                    for (int x = 0; x < SDT.Length; x++)
                    {
                        if (!char.IsDigit(SDT[x])
                            || SDT.Length != 10
                            || SDT[0] != '0'
                            || nvBUS.checkSDT(SDT) == 1)
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

                Console.Write("Email (...@gmail.com): ");
                string e = Console.ReadLine(), email = "";
                bool c = false;
                while (!c)
                {
                    for (int x = 0; x < e.Length; x++)
                    {
                        while (e.Length > 17)
                        {
                            Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
                            e = Console.ReadLine();
                        }
                        if ((e[x] >= 0 && e[x] < 48)
                            || (e[x] > 57 && e[x] < 65)
                            || (e[x] > 90 && e[x] < 97) || e[x] > 122)
                        {
                            x = -1;
                            Console.Write("Mời bạn nhập lại (...@gmail.com): ");
                            e = Console.ReadLine();
                        }
                    }
                    email = e + "@gmail.com";
                    c = true;
                }
                nvBUS.ThemNV(maNV, tenNV, date, GT, dchi, SDT, email);

                Console.WriteLine("Bạn đã thêm thông tin thành công!");
            }
            else
                Console.WriteLine("Đã thoát!");
        }

        public void SuaThongTin(string maNV)
        {
            bool check = false;

            while (!check)
            {
                Console.Clear();

                string[] tmp = nvBUS.TimKiem(maNV).Split('#');
                DateTime birth = DateTime.Parse(tmp[2]);
                bool gen = true;
                if (tmp[3] == "Nu")
                    gen = false;
                string tenNV = tmp[1], dchi = tmp[4], SDT = tmp[5], email = tmp[6];
                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA THÔNG TIN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Họ Tên: {0,-27}║", tenNV);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Ngày sinh: {0,-10}              ║                 ", birth.ToString("dd/MM/yyyy"));
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 3.║  Giới tính: {0,-3}                     ║                 ", tmp[3]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 4.║  Địa chỉ: {0,-17}         ║                 ", dchi);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 5.║  SDT: {0,-10}                    ║                 ", SDT);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 6.║  Email: {0,-27} ║                 ", email);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 30);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Họ tên mới: ");
                        tenNV = Console.ReadLine();
                        while (tenNV == "" || tenNV.Length > 27)
                        {
                            Console.Write("Nhập lại (dưới 27 ký tự): ");
                            tenNV = Console.ReadLine();
                        }
                        break;
                    case '2':
                        Console.Write("Sinh nhật (dd/MM/yyyy): ");
                        string TMPbirth = Console.ReadLine();
                        birth = new DateTime();
                        while (true)
                        {

                            try
                            {
                                birth = DateTime.Parse(TMPbirth);
                            }
                            catch
                            {
                                Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                                TMPbirth = Console.ReadLine();
                            }
                            if (birth.ToString("dd/MM/yyyy") == "01/01/0001" || birth.Year > 2002)
                            {
                                Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                                TMPbirth = Console.ReadLine();
                            }
                            else
                                break;
                        }
                        break;
                    case '3':
                        Console.Write("Giới tính (1 : Nam, 0: Nữ): ");
                        string chose = Console.ReadLine();
                        gen = false;
                        while (chose != "0" && chose != "1")
                        {
                            Console.Write("Không hợp lệ! Nhập lại: ");
                            chose = Console.ReadLine().ToUpper();
                        }
                        if (chose == "1")
                            gen = true;
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Địa chỉ: ");
                        dchi = Console.ReadLine();
                        while (dchi == "" || dchi.Length > 17)
                        {
                            Console.Write("Nhập lại (dưới 17 ký tự): ");
                            dchi = Console.ReadLine();
                        }
                        break;
                    case '5':
                        Console.Write("Số điện thoại: ");
                        SDT = Console.ReadLine();
                        while (true)
                        {

                            for (int x = 0; x < SDT.Length; x++)
                            {
                                if (!char.IsDigit(SDT[x])
                                    || SDT.Length != 10
                                    || SDT[0] != '0'
                                    || nvBUS.checkSDT(SDT) == 1)
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
                        break;
                    case '6':
                        Console.Clear();
                        Console.Write("Email (Nếu có, ...@gmail.com): ");
                        string e = Console.ReadLine();
                        bool c = false;
                        if (e != "")
                            while (!c)
                            {
                                for (int x = 0; x < e.Length; x++)
                                {
                                    while (e.Length > 17)
                                    {
                                        Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
                                        e = Console.ReadLine();
                                    }
                                    if ((e[x] >= 0 && e[x] < 48)
                                        || (e[x] > 57 && e[x] < 65)
                                        || (e[x] > 90 && e[x] < 97) || e[x] > 122)
                                    {
                                        x = -1;
                                        Console.Write("Nhập lại (...@gmail.com): ");
                                        e = Console.ReadLine();
                                    }
                                }
                                email = e + "@gmail.com";
                                c = true;
                            }
                        break;
                    case '9':
                        //HienMenuNV(maNV);
                        check = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }

                nvBUS.SuaNV(maNV, tenNV, birth, gen, dchi, SDT, email);
            }

        }

        private void XemThongTin(string maNV)
        {
            Console.Clear();

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            string[] tmp = nvBUS.TimKiem(maNV).Split('#');
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                                THÔNG TIN CỦA BẠN,   {0, -27}                                   ║", tmp[1]);
            Console.WriteLine("\t╠═════════╦════════════════════════════════╦═════════════════════╦═══════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
            Console.WriteLine("\t║    Mã   ║             Họ tên             ║       Ngày sinh     ║ Giới tính ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
            Console.WriteLine("\t╠═════════╬════════════════════════════════╬═════════════════════╬═══════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
            Console.WriteLine("\t║  {0,-7}║\t{1,-27}║  {2,-10}         ║     {3,-3}   ║  {4,-17}║   {5,-10}       ║  {6,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6]);
            Console.WriteLine("\t╚═════════╩════════════════════════════════╩═════════════════════╩═══════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
            Console.Write("\tNhấn phím bất kì để kết thúc!");
        }
        
        private void DoiMatKhau(string maNV)
        {
            Console.Clear();
            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
            Console.Write("\n\t║                               ĐỔI MẬT KHẨU                            ║");
            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
            Console.Write("\n\t║ ĐỔI MẬT KHẨU HOẶC NHẤN 'ENTER' ĐỂ THOÁT!                              ║");
            Console.Write("\n\t║                                                                       ║");
            Console.Write("\n\t║     MẬT KHẨU MỚI     :                                                ║");
            Console.Write("\n\t║                                                                       ║");
            Console.Write("\n\t║  NHẬP LẠI MẬT KHẨU   :                                                ║");
            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(34, 7);
            string MK1 = Console.ReadLine();
            if (MK1 != "")
            {
                Console.SetCursorPosition(34, 9);
                string MK2 = Console.ReadLine();
                if(MK2 != MK1)
                {
                    Console.Write("\n\tMật khẩu không giống nhau!");
                    return;
                }
                nvBUS.DoiMK(maNV, MK1);
                Console.WriteLine("\n\tBạn đổi mật khẩu thành công!");
            }
            else
                Console.Write("\n\n\n\n\tĐã thoát!");
        }

    }

   
}
