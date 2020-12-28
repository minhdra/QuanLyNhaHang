using QuanLyNhaHang.BUS;
using QuanLyNhaHang.DAL;
using QuanLyNhaHang.Presentation;
using System;
using System.Buffers.Text;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyNhaHang
{
    class MenuChinh
    {
        public void Menu()
        {
            while (true)
            {
                Console.Title = ("CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN - LÊ ĐÌNH MINH").ToUpper();
                Console.Clear();

                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║               GIẢNG VIÊN HƯỚNG DẪN : NGUYỄN VĂN HẬU                   ║");
                Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                           NHÀ HÀNG @                              ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║          QUẢN LÝ             ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║         NHÂN VIÊN            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║         KHÁCH HÀNG           ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║ Phone: 0964-xxx-841                                               ║ ║");
                Console.Write("\n\t\t║ ║                                                 Địa chỉ: xxx      ║ ║");
                Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(65, 23);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        TaiKhoanPre.QuanLy ql = new TaiKhoanPre.QuanLy();
                        ql.HienMenuQL();
                        break;
                    case '2':
                        TaiKhoanPre.NhanVien nv = new TaiKhoanPre.NhanVien();
                        nv.HienMenuNV();
                        break;
                    case '3':
                        TaiKhoanPre.KhachHang kh = new TaiKhoanPre.KhachHang();
                        kh.HienMenuKhach();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            //Console.BackgroundColor = ConsoleColor.Gray;
            //Console.ForegroundColor = ConsoleColor.Black;
            MenuChinh menu = new MenuChinh();
            menu.Menu();
            
        }
    }
}
