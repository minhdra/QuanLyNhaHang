using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using QuanLyNhaHang.Constraint;
using QuanLyNhaHang.Presentation;

namespace QuanLyNhaHang.Presentation
{
    class TaiKhoanPre
    {

        public class KhachHang
        {
            private KhachHangBUS khBUS = new KhachHangBUS();
            private KhachHangPre khShow = new KhachHangPre();
            private constraint conP = new constraint();

            public void HienMenuKhach()
            {
                string s;
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\n\t\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                       TÀI KHOẢN KHÁCH HÀNG                        ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 2.║          ĐĂNG KÝ             ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 3.║       QUÊN MẬT KHẨU          ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(89, 29);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                    switch (chose)
                    {
                        case '1':

                            if ((s = DangNhapK()) != "")
                                khShow.HienMenuKH(s);
                            else
                            {
                                Console.Write("\n\n\t\t\t\t\tĐăng nhập không thành công!");
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
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║                          ĐĂNG NHẬP KHÁCH HÀNG                         ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(41, 6);
                string TK = Console.ReadLine();
                string MK = conP.Password(41, 8);
                string result = "";
                string[] tmp = khBUS.LaythongtinTK(TK).Split('\t');
                if (khBUS.DangNhap(TK, MK) == 1)
                    result = tmp[2];
                return result;
            }

            private void DangKyK()
            {
                Console.Clear();
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║                          ĐĂNG KÝ TÀI KHOẢN                            ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t║ NHẤN ENTER ĐỂ THOÁT                                                   ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║     TÀI KHOẢN        :                                                ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║     MẬT KHẨU         :                                                ║");
                Console.Write("\n\t║                                                                       ║");
                Console.Write("\n\t║ NHẬP LẠI MẬT KHẨU    :                                                ║");
                Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                
                Console.SetCursorPosition(34, 7);
                string TK = Console.ReadLine();
                if (TK == "") return;
                TK = conP.CheckStr2(TK, 20, 34, 7, 28, 13);

                Console.SetCursorPosition(34, 9);
                string MK1 = Console.ReadLine();
                MK1 = conP.CheckStr2(MK1, 10, 34, 9, 28, 13);

                Console.SetCursorPosition(34, 11);
                string MK2 = Console.ReadLine();
                MK2 = conP.CheckStr2(MK2, 10, 34, 11, 28, 13);


                if (MK1 == MK2)
                {
                    if (khBUS.CheckTK(TK) == true)
                        Console.Write("\n\n\tTài khoản đã tồn tại!");
                    else
                    {
                        khBUS.ThemTK(TK, MK1);
                        Console.Write("\n\n\tTạo tài khoản thành công");
                    }
                }
                else
                    Console.Write("\n\n\tMật khẩu không giống nhau");
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
            private constraint conP = new constraint();
            
            public void HienMenuNV()
            {
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\n\t\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                       TÀI KHOẢN NHÂN VIÊN                         ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 2.║        QUÊN MẬT KHẨU         ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(89, 26);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);
                    string s;

                    switch (chose)
                    {
                        case '1':
                            if ((s = DangNhapNV()) != "")
                                nvShow.HienMenuNV(s);
                            else
                            {
                                Console.Write("\n\n\t\t\t\t\tĐăng nhập không thành công!");
                                Console.ReadKey();
                            }
                            break;
                        case '2':
                            QuenMkNv();
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
                            HienMenuNV();
                            break;
                    }
                }
            }

            private string DangNhapNV()
            {
                Console.Clear();
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║                         ĐĂNG NHẬP NHÂN VIÊN                           ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(41, 6);
                string TK = Console.ReadLine().ToUpper();
                string MK = conP.Password(41, 8);
                string result = "";
                string[] tmp = nvBUS.LaythongtinTK(TK).Split('\t');
                if (nvBUS.DangNhap(TK, MK) == 1)
                    result = tmp[2];
                return result;
            }

            private void QuenMkNv()
            {
                Console.Clear();
                Console.Write("Nhập số điện thoại : ");
                string SDT = Console.ReadLine();
                if (nvBUS.QuenMK(SDT) != "")
                {
                    Console.Clear();
                    Console.WriteLine(nvBUS.QuenMK(SDT));
                }
                else
                {
                    Console.Write("Không thành công!");
                }
            }
        }
        
        public class QuanLy
        {
            private QuanLyPre qlShow = new QuanLyPre();
            private NhanVienBUS nvBUS = new NhanVienBUS();
            private constraint conP = new constraint();
            public void HienMenuQL()
            {
                while (true)
                {
                    Console.Clear();

                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\n\t\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                    Console.Write("\n\t\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                    Console.Write("\n\t\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                       TÀI KHOẢN QUẢN LÝ                           ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 1.║         ĐĂNG NHẬP            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ║                                                                   ║ ║");
                    Console.Write("\n\t\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                    Console.Write("\n\t\t\t\t\t║                                                                       ║");
                    Console.Write("\n\t\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(89, 23);

                    char chose = char.ToUpper(Console.ReadKey(true).KeyChar);
                    switch (chose)
                    {
                        case '1':
                            if (DangNhapQL() != "")
                                qlShow.MenuQuanLy();
                            else
                                Console.Write("\n\n\t\t\t\t\tĐăng nhập không thành công!");
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
            private string DangNhapQL()
            {
                Console.Clear();
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║                          ĐĂNG NHẬP QUẢN LÝ                            ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.Write("\n\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t║  TÀI KHOẢN   :                                                        ║");
                Console.Write("\n\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t║  MẬT KHẨU    :                                                        ║");
                Console.Write("\n\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(41, 6);
                string TK = Console.ReadLine();
                string MK = conP.Password(41, 8);

                string result = "";

                if (nvBUS.DangNhap(TK, MK) == 1)
                {
                    string[] tmp = nvBUS.LaythongtinTK(TK).Split('\t');
                    string[] tmp2 = nvBUS.Laythongtin(tmp[2]).Split('#');
                    QLNhanVien qlnv = new QLNhanVien();
                    /*
                     * Những nhân viên có chức vụ để đăng nhập vào chức năng quản lý
                     * Giám đốc
                     * Quản lý
                     * Giám sát
                     * Lễ tân
                     */
                    if (
                    tmp2[8] == qlnv.listPosition[0]
                    || tmp2[8] == qlnv.listPosition[1]
                    || tmp2[8] == qlnv.listPosition[2]
                    || tmp2[8] == qlnv.listPosition[3])
                        result = tmp[2];
                }
                return result;
            }
        }
    }
}
