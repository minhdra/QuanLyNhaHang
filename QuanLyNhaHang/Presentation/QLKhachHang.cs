using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.SHOW
{
    //class QLKhachHang
    //{
    //    KhachHangBUS khBUS = new KhachHangBUS();

    //    public void MenuKH()
    //    {
    //        while (true)
    //        {
    //            Console.Clear();

    //            Console.SetWindowSize(103, 35);
    //            Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
    //            Console.Write("\n\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
    //            Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
    //            Console.Write("\n\t\t║                                                                       ║");
    //            Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║                       TÀI KHOẢN KHÁCH HÀNG                        ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 1.║     HIỂN THỊ KHÁCH HÀNG      ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 2.║       THÊM KHÁCH HÀNG        ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 4.║        XÓA KHÁCH HÀNG        ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
    //            Console.Write("\n\t\t║                                                                       ║");
    //            Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
    //            Console.SetCursorPosition(65, 29);

    //            char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

    //            switch (chose)
    //            {
    //                case '1':
    //                    Show();
    //                    Console.ReadKey();
    //                    break;
    //                case '2':
    //                    Them();
    //                    Console.ReadKey();
    //                    break;
    //                case '3':
    //                    Sua();
    //                    Console.ReadKey();
    //                    break;
    //                case '4':
    //                    Xoa();
    //                    Console.ReadKey();
    //                    break;
    //                case '9':
    //                    QuanLyShow ql = new QuanLyShow();
    //                    ql.MenuQuanLy();
    //                    break;
    //                case '0':
    //                    Environment.Exit(0);
    //                    break;
    //                default:
    //                    MenuKH();
    //                    break;
    //            }
    //        }
    //    }

    //    private void Show()
    //    {
    //        Console.Clear();

    //        Console.SetWindowSize(140, 30);
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
    //        Console.WriteLine("\t\t║                                       DANH SÁCH KHÁCH HÀNG                                                      ║");
    //        Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
    //        Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
    //        Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
    //        for(int x = 0; x < khBUS.Laydanhsach().Count; x++)
    //        {
    //            string[] tmp = khBUS.Laydanhsach()[x].Split('\t');
    //            Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);

    //        }
            
    //        Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
    //        Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //    }

    //    private void Them()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Thêm khách hàng hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Tài khoản: ");
    //        string TK = Console.ReadLine();
    //        if (TK != "")
    //        {
    //            Console.Write("Mật khẩu: ");
    //            string MK1 = Console.ReadLine();
    //            Console.Write("Nhập lại mật khẩu: ");
    //            string MK2 = Console.ReadLine();


    //            if (MK1 == MK2)
    //            {
    //                if (khBUS.CheckTK(TK) == true)
    //                    Console.WriteLine("Tài khoản đã tồn tại!");
    //                else
    //                {
    //                    khBUS.ThemTK(TK, MK1);
    //                    Console.WriteLine("Tạo tài khoản thành công");
    //                    // Lấy mã
    //                    string[] tmp = khBUS.LaythongtinTK(TK).Split('\t');
    //                    string maKH = tmp[2];

    //                    Console.Write("Họ tên: ");
    //                    string tenKH = Console.ReadLine();
    //                    while (tenKH == "" || tenKH.Length > 27)
    //                    {
    //                        Console.Write("Nhập lại (dưới 27 ký tự): ");
    //                        tenKH = Console.ReadLine();
    //                    }
    //                    Console.Write("Địa chỉ: ");
    //                    string dchi = Console.ReadLine();
    //                    while (dchi == "" || dchi.Length > 17)
    //                    {
    //                        Console.Write("Nhập lại (dưới 17 ký tự): ");
    //                        dchi = Console.ReadLine();
    //                    }
    //                    Console.Write("Số điện thoại: ");
    //                    string SDT = Console.ReadLine();
    //                    for (int x = 0; x < SDT.Length; x++)
    //                    {
    //                        if (!char.IsDigit(SDT[x]) || SDT.Length != 10 || SDT[0] != '0')
    //                        {
    //                            Console.Write("Mời bạn nhập lại: ");
    //                            SDT = Console.ReadLine();
    //                            x = 0;
    //                        }
    //                    }
    //                    Console.Write("Email (Nếu có, ...@gmail.com): ");
    //                    string e = Console.ReadLine(), email = "<Trống>";
    //                    bool c = false;
    //                    if (e != "")
    //                        while (!c)
    //                        {
    //                            for (int x = 0; x < e.Length; x++)
    //                            {
    //                                while (e.Length > 17)
    //                                {
    //                                    Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
    //                                    e = Console.ReadLine();
    //                                }
    //                                if ((e[x] >= 0 && e[x] < 48)
    //                                    || (e[x] > 57 && e[x] < 65)
    //                                    || (e[x] > 90 && e[x] < 97) || e[x] > 122)
    //                                {
    //                                    x = -1;
    //                                    Console.Write("Mời bạn nhập lại (...@gmail.com): ");
    //                                    e = Console.ReadLine();
    //                                }
    //                            }
    //                            email = e + "@gmail.com";
    //                            c = true;
    //                        }
    //                    khBUS.Them(maKH, tenKH, dchi, SDT, email);
    //                }
    //            }
    //        }
    //        else
    //            Console.WriteLine("Đã thoát!");
    //    }

    //    private void Sua()
    //    {
    //        Console.Clear();
    //        Console.WriteLine(
    //            "Sửa thông tin khách hàng hoặc nhấn 'Enter' để bỏ qua. \n" +
    //            "1. Sửa thông tin \n" +
    //            "2. Sửa tài khoản");
    //        Console.Write("Mời bạn chọn: ");
    //        string chose = Console.ReadLine();
    //        if (chose == "")
    //        {
    //            Console.WriteLine("Đã thoát!");
    //            return;
    //        }
    //        else if(chose == "1")
    //        {
    //            Console.Write("Nhập mã khách hàng muốn sửa: ");
    //            string maKH = Console.ReadLine().ToUpper();
    //            if (khBUS.Laythongtin(maKH) != "")
    //            {
    //                Console.Write("Họ tên: ");
    //                string tenKH = Console.ReadLine();
    //                while (tenKH == "" || tenKH.Length > 27)
    //                {
    //                    Console.Write("Nhập lại (dưới 27 ký tự): ");
    //                    tenKH = Console.ReadLine();
    //                }
    //                Console.Write("Địa chỉ: ");
    //                string dchi = Console.ReadLine();
    //                while (dchi == "" || dchi.Length > 17)
    //                {
    //                    Console.Write("Nhập lại (dưới 17 ký tự): ");
    //                    dchi = Console.ReadLine();
    //                }
    //                Console.Write("Số điện thoại: ");
    //                string SDT = Console.ReadLine();
    //                for (int x = 0; x < SDT.Length; x++)
    //                {
    //                    if (!char.IsDigit(SDT[x]) || SDT.Length != 10 || SDT[0] != '0')
    //                    {
    //                        Console.Write("Mời bạn nhập lại: ");
    //                        SDT = Console.ReadLine();
    //                        x = 0;
    //                    }
    //                }
    //                Console.Write("Email (Nếu có, ...@gmail.com): ");
    //                string e = Console.ReadLine(), email = "<Trống>";
    //                bool c = false;
    //                if (e != "")
    //                    while (!c)
    //                    {
    //                        for (int x = 0; x < e.Length; x++)
    //                        {
    //                            while (e.Length > 17)
    //                            {
    //                                Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
    //                                e = Console.ReadLine();
    //                            }
    //                            if ((e[x] >= 0 && e[x] < 48)
    //                                || (e[x] > 57 && e[x] < 65)
    //                                || (e[x] > 90 && e[x] < 97) || e[x] > 122)
    //                            {
    //                                x = -1;
    //                                Console.Write("Mời bạn nhập lại (...@gmail.com): ");
    //                                e = Console.ReadLine();
    //                            }
    //                        }
    //                        email = e + "@gmail.com";
    //                        c = true;
    //                    }
    //                khBUS.Sua(maKH, tenKH, dchi, SDT, email);
    //                Console.WriteLine("Đã sửa thành công!");
    //            }
    //            else
    //                Console.WriteLine("Khách hàng không tồn tại!");
    //        }
    //        else if(chose == "2")
    //        {
    //            Console.Write("Nhập mã khách hàng muốn sửa: ");
    //            string maKH = Console.ReadLine().ToUpper();
    //            if (khBUS.Laythongtin(maKH) != "")
    //            {
    //                Console.Write("Nhập tài khoản khách: ");
    //                string TK = Console.ReadLine();
    //                if (khBUS.CheckTK(TK) == false)
    //                {
    //                    Console.Write("Nhập mật khẩu: ");
    //                    string MK = Console.ReadLine();
    //                    khBUS.SuaTK(TK, MK, maKH);
    //                    Console.WriteLine("Đã sửa thành công!");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Tài khoản đã tồn tại!");
    //                }
    //            }
    //            else
    //                Console.WriteLine("Khách hàng không tồn tại!");
    //        }
    //    }

    //    private void Xoa()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Xóa khách hàng hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã khách hàng muốn xóa: ");
    //        string maKH = Console.ReadLine().ToUpper();
    //        if(maKH != "")
    //        {
    //            if (khBUS.Laythongtin(maKH) != "")
    //            {
    //                Console.Write("Xác nhận xóa? (Y/N): ");
    //                string check = Console.ReadLine().ToUpper();
    //                while(check != "Y" && check != "N")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại: ");
    //                    check = Console.ReadLine().ToUpper();
    //                }
    //                if (check == "Y")
    //                {
    //                    khBUS.Xoa(maKH);
    //                    Console.WriteLine("Đã xóa thành công!!!");
    //                }
    //                else
    //                    Console.WriteLine("Đã hủy xóa!!!");
    //            }
    //            else
    //                Console.WriteLine("Khách hàng không tồn tại!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát!");
    //    }
    //}
}
