using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Constraint;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Presentation
{
    // 1 Nhân viên
    class NhanVienPre
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private constraint conP = new constraint();

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

        public void ThemThongTin(string maNV)
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
                DateTime date = conP.Date(tmp);

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
                SDT = conP.NumberPhone(SDT);

                Console.Write("Email (...@gmail.com): ");
                string e = Console.ReadLine();
                string email = conP.Email(e);
                
                nvBUS.ThemNV(maNV, conP.Capitalize(tenNV), date, GT, conP.Capitalize(dchi), SDT, email);

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
                Console.Write("\n\t\t             ║ 6.║  Email: {0,-27} ║  ", email);
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
                string t;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Họ tên mới (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                        {
                            tenNV = t;
                            while (tenNV == "" || tenNV.Length > 27)
                            {
                                Console.Write("Nhập lại (dưới 27 ký tự): ");
                                tenNV = Console.ReadLine();
                            }
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Sinh nhật (dd/MM/yyyy) (Enter để thoát): ");
                        t = Console.ReadLine();
                        if(t != "")
                            birth = conP.Date(t);

                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("Giới tính (1 : Nam, 0: Nữ) (Enter để thoát): ");
                        t = Console.ReadLine();
                        if(t != "")
                        {
                            gen = false;
                            while (t != "0" && t != "1")
                            {
                                Console.Write("Không hợp lệ! Nhập lại: ");
                                t = Console.ReadLine().ToUpper();
                            }
                            if (t == "1")
                                gen = true;
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Địa chỉ (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                        {
                            dchi = t;
                            while (dchi == "" || dchi.Length > 17)
                            {
                                Console.Write("Nhập lại (dưới 17 ký tự): ");
                                dchi = Console.ReadLine();
                            }
                        }
                        break;
                    case '5':
                        Console.Clear();
                        Console.Write("Số điện thoại (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                        {
                            SDT = t;
                            SDT = conP.NumberPhone(SDT);
                        }
                        break;
                    case '6':
                        Console.Clear();
                        Console.Write("Email (...@gmail.com hoặc Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                        {
                            email = t;
                            email = conP.Email(email);
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

                nvBUS.SuaNV(maNV, conP.Capitalize(tenNV), birth, gen, conP.Capitalize(dchi), SDT, email);
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
