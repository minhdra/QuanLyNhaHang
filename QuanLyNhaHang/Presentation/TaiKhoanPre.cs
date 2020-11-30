using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace QuanLyNhaHang.Presentation
{
    class TaiKhoanPre
    {

        public class KhachHang
        {
            private KhachHangBUS khBUS = new KhachHangBUS();
            private KhachHangPre khShow = new KhachHangPre();

            public void HienMenuKhach()
            {
                string s;
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(103, 35);
                    Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t║                                                                       ║");
                    Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║                       TÀI KHOẢN KHÁCH HÀNG                        ║ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║ 2.║          ĐĂNG KÝ             ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║ 3.║       QUÊN MẬT KHẨU          ║                 ║ ║");
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
                    Console.SetCursorPosition(65, 26);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                    switch (chose)
                    {
                        case '1':

                            if ((s = DangNhapK()) != "")
                                khShow.HienMenuKH(s);
                            else
                            {
                                Console.WriteLine("\n\n\t\tĐăng nhập không thành công!");
                                Console.ReadKey();
                            }
                            break;
                        case '2':
                            DangKyK();
                            Console.ReadKey();
                            break;
                        case '3':
                            QuenmkK();
                            Console.ReadKey();
                            break;
                        case '9':
                            MenuChinh menu = new MenuChinh();
                            menu.Menu();
                            break;
                        case '0':
                            Environment.Exit(0);
                            break;
                        default:
                            HienMenuKhach();
                            break;
                    }
                }

            }

            private string DangNhapK()
            {
                Console.Clear();
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║                          ĐĂNG NHẬP KHÁCH HÀNG                         ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(26, 5);
                string TK = Console.ReadLine();
                Console.SetCursorPosition(26, 7);
                string MK = Console.ReadLine();
                string result = "";
                string[] tmp = khBUS.LaythongtinTK(TK).Split('\t');
                if (khBUS.DangNhap(TK, MK) == 1)
                    result = tmp[2];
                return result;
            }

            private void DangKyK()
            {
                Console.Clear();
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║                          ĐĂNG NHẬP QUẢN LÝ                            ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║     TÀI KHOẢN        :                                                ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║     MẬT KHẨU         :                                                ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║ NHẬP LẠI MẬT KHẨU    :                                                ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(34, 5);
                string TK = Console.ReadLine();
                Console.SetCursorPosition(34, 7);
                string MK1 = Console.ReadLine();
                Console.SetCursorPosition(34, 9);
                string MK2 = Console.ReadLine();


                if (MK1 == MK2)
                {
                    if (khBUS.CheckTK(TK) == true)
                        Console.WriteLine("\n\n\t\tTài khoản đã tồn tại!");
                    else
                    {
                        khBUS.ThemTK(TK, MK1);
                        Console.WriteLine("\n\n\t\tTạo tài khoản thành công");
                    }
                }
            }


            private void QuenmkK()
            {
                Console.Clear();
                Console.Write("Nhập số điện thoại : ");
                string SDT = Console.ReadLine();
                if (khBUS.QuenMK(SDT) != "")
                {
                    Console.Clear();
                    Console.WriteLine(khBUS.QuenMK(SDT));
                }
                else
                {
                    Console.Write("Không thành công!");
                }
            }
        }
        
        public class NhanVien
        {
            private NhanVienBUS nvBUS = new NhanVienBUS();
            private NhanVienPre nvShow = new NhanVienPre();
            public void HienMenuNV()
            {
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(103, 35);
                    Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t║                                                                       ║");
                    Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║                       TÀI KHOẢN NHÂN VIÊN                         ║ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
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
                    Console.SetCursorPosition(65, 20);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);
                    string s;

                    switch (chose)
                    {
                        case '1':
                            if ((s = DangNhapNV()) != "")
                                nvShow.HienMenuNV(s);
                            else
                            {
                                Console.WriteLine("\n\n\t\tĐăng nhập không thành công!");
                                Console.ReadKey();
                            }
                            break;
                        case '9':
                            MenuChinh menu = new MenuChinh();
                            menu.Menu();
                            break;
                        case '0':
                            Environment.Exit(0);
                            break;
                        default:
                            HienMenuNV();
                            break;
                    }
                }
            }

            private string DangNhapNV()
            {
                Console.Clear();

                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║                         ĐĂNG NHẬP NHÂN VIÊN                           ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(26, 5);
                string TK = Console.ReadLine().ToUpper();
                Console.SetCursorPosition(26, 7);
                string MK = Console.ReadLine();
                string result = "";
                string[] tmp = nvBUS.LaythongtinTK(TK).Split('\t');
                if (nvBUS.DangNhap(TK, MK) == 1)
                    result = tmp[2];
                return result;
            }
        }
        
        public class QuanLy
        {
            private QuanLyPre qlShow = new QuanLyPre();
            public void HienMenuQL()
            {
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(103, 35);
                    Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t║                                                                       ║");
                    Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║                       TÀI KHOẢN QUẢN LÝ                           ║ ║");
                    Console.Write("\n\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
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
                    Console.SetCursorPosition(65, 20);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                    switch (chose)
                    {
                        case '1':
                            if (DangNhapQL() == 1)
                                qlShow.MenuQuanLy();
                            else
                                Console.WriteLine("\n\n\t\tĐăng nhập không thành công!");
                            Console.ReadKey();
                            break;
                        case '9':
                            MenuChinh menu = new MenuChinh();
                            menu.Menu();
                            break;
                        case '0':
                            Environment.Exit(0);
                            break;
                        default:
                            HienMenuQL();
                            break;
                    }
                }
            }
            private int DangNhapQL()
            {
                Console.Clear();
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║                          ĐĂNG NHẬP QUẢN LÝ                            ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(26, 5);
                string TK = Console.ReadLine();
                Console.SetCursorPosition(26, 7);
                string MK = Console.ReadLine();
                int check = 0;
                if (TK == "" && MK == "")
                    check = 1;
                return check;
            }
        }
    }
}
