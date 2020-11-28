using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.SHOW
{
    //class QLHangHoa
    //{
    //    private HangHoaBUS hhBUS = new HangHoaBUS();

    //    public void MenuHH()
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
    //            Console.Write("\n\t\t║ ║                             HÀNG HÓA                              ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH HÀNG HÓA  ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 2.║       THÊM HÀNG HÓA          ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 4.║         XÓA HÀNG HÓA         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 5.║           TÌM KIẾM           ║                 ║ ║");
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
    //            Console.SetCursorPosition(65, 32);

    //            char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

    //            switch (chose)
    //            {
    //                case '1':
    //                    Show();
    //                    Console.Write("\t\tNhấn phím bất kì để kết thúc!");
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
    //                case '5':
    //                    TimKiem();
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
    //                    MenuHH();
    //                    break;
    //            }
    //        }
    //    }

    //    public void Show()
    //    {
    //        Console.Clear();

    //        Console.SetWindowSize(140, 30);
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
    //        Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
    //        Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
    //        Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
    //        Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
    //        for (int x = 0; x < hhBUS.Laydanhsach().Count; x++)
    //        {
    //            string[] tmp = hhBUS.Laydanhsach()[x].Split('\t');
    //            Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9} VND    ║", tmp[0], tmp[1], tmp[2]);
    //        }
    //        Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");
            
    //    }

    //    private void Them()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Thêm thông tin hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập tên hàng hóa: ");
    //        string tenHH = Console.ReadLine();
    //        if (tenHH != "")
    //        {
    //            while (tenHH.Length > 30)
    //            {
    //                Console.Write("Nhập lại (dưới 30 ký tự): ");
    //                tenHH = Console.ReadLine();
    //            }
    //            int price = 0;
    //            while (price == 0)
    //            {
    //                try
    //                {
    //                    Console.Write("Nhập giá: ");
    //                    price = int.Parse(Console.ReadLine());
    //                }
    //                catch
    //                {
    //                    Console.WriteLine("Dữ liệu là số!");
    //                }
    //            }
    //            hhBUS.Them(tenHH, price);
    //            Console.WriteLine("Đã thêm thành công!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát.");
    //    }

    //    private void Sua()
    //    {
    //        Console.Clear();
    //        Console.Write("Nhấp 'Enter' để xem danh sách hàng hóa: ");
    //        string check = Console.ReadLine();
    //        if (check == "")
    //            Show();
    //        Console.WriteLine("Sửa thông tin hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã hàng hóa muốn sửa: ");
    //        string maHH = Console.ReadLine().ToUpper();
    //        if (maHH != "")
    //        {
    //            if (hhBUS.Laythongtin(maHH) != "")
    //            {
    //                Console.Write("Nhập tên hàng hóa: ");
    //                string tenHH = Console.ReadLine();
    //                while (tenHH == "" || tenHH.Length > 30)
    //                {
    //                    Console.Write("Nhập lại (dưới 30 ký tự): ");
    //                    tenHH = Console.ReadLine();
    //                }

    //                int price = 0;
    //                while (price == 0)
    //                {
    //                    try
    //                    {
    //                        Console.Write("Nhập giá: ");
    //                        price = int.Parse(Console.ReadLine());
    //                    }
    //                    catch
    //                    {
    //                        Console.WriteLine("Dữ liệu là số!");
    //                    }
    //                }
    //                hhBUS.Sua(maHH, tenHH, price);
    //                Console.WriteLine("Đã sửa thành công!");
    //            }
    //            else
    //                Console.WriteLine("Hàng hóa không tồn tại!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát.");
    //    }

    //    private void Xoa()
    //    {
    //        Console.Clear();
    //        Console.Write("Nhấp 'Enter' để xem danh sách hàng hóa: ");
    //        string check = Console.ReadLine();
    //        if (check == "")
    //            Show();
    //        Console.WriteLine("Xóa hàng hóa hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã hàng hóa muốn xóa: ");
    //        string maHH = Console.ReadLine().ToUpper();
    //        if (maHH != "")
    //        {
    //            Console.Write("Xác nhận xóa? (Y/N): ");
    //            string check2 = Console.ReadLine().ToUpper();
    //            while (check2 != "Y" && check2 != "N")
    //            {
    //                Console.Write("Không hợp lệ! Nhập lại: ");
    //                check2 = Console.ReadLine().ToUpper();
    //            }
    //            if (check2 == "Y")
    //            {
    //                hhBUS.Xoa(maHH);
    //                Console.WriteLine("Đã xóa thành công!!!");
    //            }
    //            else
    //                Console.WriteLine("Đã hủy xóa!!!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát.");
    //    }

    //    private void TimKiem()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Tìm kiếm hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã hàng hóa muốn tìm: ");
    //        string maHH = Console.ReadLine().ToUpper();
    //        if (maHH != "")
    //        {
    //            if (hhBUS.Laythongtin(maHH) != "")
    //            {
    //                Console.Clear();
    //                string[] tmp = hhBUS.Laythongtin(maHH).Split('\t');
    //                Console.SetWindowSize(140, 30);
    //                Console.WriteLine();
    //                Console.WriteLine();
    //                Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
    //                Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
    //                Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
    //                Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
    //                Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
    //                Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9} VND    ║", tmp[0], tmp[1], tmp[2]);
    //                Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");
    //                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //            }
    //            else
    //                Console.WriteLine("Hàng hóa không tồn tại!");
    //        }
    //        else
    //            Console.Write("Đã thoát.");
    //    }
    //}
}
