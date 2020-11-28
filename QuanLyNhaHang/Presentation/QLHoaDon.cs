using Microsoft.VisualBasic;
using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.SHOW
{
    //class QLHoaDon
    //{
    //    private HoaDonBUS hdBUS = new HoaDonBUS();

    //    public void MenuHD()
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
    //            Console.Write("\n\t\t║ ║                             HÓA ĐƠN                               ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 1.║      HIỂN THỊ HÓA ĐƠN        ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 2.║        THÊM HÓA ĐƠN          ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 3.║           TÌM KIẾM           ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 4.║         XÓA HÓA ĐƠN          ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 5.║          THỐNG KÊ            ║                 ║ ║");
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
    //                    HienThiChiTiet();
    //                    Console.ReadKey();
    //                    break;
    //                case '2':
    //                    Them();
    //                    Console.ReadKey();
    //                    break;
    //                case '3':
    //                    TimKiem();
    //                    Console.ReadKey();
    //                    break;
    //                case '4':
    //                    Xoa();
    //                    Console.ReadKey();
    //                    break;
    //                case '5':
    //                    MenuThongKe();
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
    //                    MenuHD();
    //                    break;
    //            }
    //        }
    //    }

    //    private void MenuThongKe()
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
    //            Console.Write("\n\t\t║ ║                             THỐNG KÊ                              ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 1.║       THỐNG KÊ NGÀY          ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 2.║       THỐNG KÊ THÁNG         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 3.║        THỐNG KÊ NĂM          ║                 ║ ║");
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
    //            Console.SetCursorPosition(65, 26);

    //            char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

    //            switch (chose)
    //            {
    //                case '1':
    //                    ThongKeNgay();
    //                    Console.ReadKey();
    //                    break;
    //                case '2':
    //                    ThongKeThang();
    //                    Console.ReadKey();
    //                    break;
    //                case '3':
    //                    ThongKeNam();
    //                    Console.ReadKey();
    //                    break;
    //                case '9':
    //                    MenuHD();
    //                    break;
    //                case '0':
    //                    Environment.Exit(0);
    //                    break;
    //                default:
    //                    MenuThongKe();
    //                    break;
    //            }
    //        }
    //    }

    //    private void HienThi()
    //    {
    //        Console.Clear();

    //        Console.SetWindowSize(140, 30);
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //        Console.WriteLine("\t\t║                              Hóa đơn                           ║");
    //        Console.WriteLine("\t\t╠═════════╦══════════════════════════════════╦═══════════════════╣");
    //        Console.WriteLine("\t\t║    Mã   ║         Tên khách hàng           ║        Ngày       ║");
    //        Console.WriteLine("\t\t╠═════════╬══════════════════════════════════╬═══════════════════╣");
    //        for (int x = 0; x < hdBUS.LayDanhSach().Count; x++)
    //        {
    //            string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
    //            Console.WriteLine("\t\t║ {0,-7} ║\t{1,-27}  ║  {2,-10}       ║", tmp[0], tmp[1], tmp[2]);
    //        }
    //        Console.WriteLine("\t\t╚═════════╩══════════════════════════════════╩═══════════════════╝");

    //    }

    //    private void HienThiChiTiet()
    //    {
    //        Console.Clear();

    //        HienThi();
    //        Console.Write("\t\tNhập mã hóa đơn để xem chi tiết (Nhấp 'Enter' để bỏ qua): ");
    //        string maHD = Console.ReadLine().ToUpper();
    //        if (maHD != "")
    //        {
    //            bool c = false;
    //            while (!c)
    //            {
    //                if (hdBUS.HienChiTiet(maHD).Count != 0)
    //                {
    //                    Console.Clear();
    //                    int total = 0;

    //                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
    //                    Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
    //                    Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
    //                    Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
    //                    Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
    //                    for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
    //                    {
    //                        string[] tmp = hdBUS.HienChiTiet(maHD)[x].Split('\t');
    //                        Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║  {2,-9}VND     ║     {3,-5}   ║   {4,-12}VND  ║", tmp[0], tmp[1], tmp[2], tmp[3], int.Parse(tmp[2]) * int.Parse(tmp[3]));
    //                        total += int.Parse(tmp[2]) * int.Parse(tmp[3]);
    //                    }
    //                    Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");

    //                    Console.WriteLine();
    //                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //                    Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}VND                                 ║", total);
    //                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

    //                    Console.Write("\t\tXem tiếp nhấn 'Enter' hoặc nhấn bất kỳ phím khác để thoát : ");
    //                    string check = Console.ReadLine();
    //                    if (check == "")
    //                    {
    //                        Console.Clear();
    //                        HienThi();
    //                        Console.Write("\t\tNhập mã hóa đơn (Nhấp 'Enter' để bỏ qua): ");
    //                        maHD = Console.ReadLine().ToUpper();
    //                        if (maHD == "")
    //                            c = true;
    //                    }
    //                    else
    //                        c = true;
    //                }
    //                else
    //                {
    //                    Console.Write("\t\tMã hóa đơn không tồn tại! Mời nhập lại (Nhấp 'Enter' để thoát): ");
    //                    maHD = Console.ReadLine().ToUpper();
    //                    if (maHD == "")
    //                        c = true;
    //                }
    //            }
    //        }
    //        else
    //            Console.Write("\t\tĐã thoát!");
    //    }

    //    private void Them()
    //    {
    //        Console.Clear();
    //        KhachHangBUS khBUS = new KhachHangBUS();
    //        HangHoaBUS hhBUS = new HangHoaBUS();
    //        QLHangHoa qlHH = new QLHangHoa();
    //        Console.WriteLine("Thêm hóa đơn hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Mã khách hàng: ");
    //        string maKH = Console.ReadLine().ToUpper();
    //        if (maKH != "")
    //        {
    //            if (khBUS.Laythongtin(maKH) != "")
    //            {
    //                Console.Clear();
    //                string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
    //                DateTime date = DateTime.Now;

    //                qlHH.Show();

    //                Console.Write("\t\tNhập mã hàng hóa hoặc nhấn 'Enter' để thoát: ");
    //                string ID = Console.ReadLine().ToUpper();

    //                if (ID != "")
    //                {
    //                    bool c = false;
    //                    while (!c)
    //                    {
    //                        if (hhBUS.Laythongtin(ID) != "")
    //                        {
    //                            int SL = 0;
    //                            while (SL == 0)
    //                            {
    //                                try
    //                                {
    //                                    Console.Write("\t\tSố lượng: ");
    //                                    SL = Int16.Parse(Console.ReadLine());
    //                                }
    //                                catch
    //                                {
    //                                    Console.WriteLine("\t\tDữ liệu là số!");
    //                                }
    //                            }
    //                            hdBUS.Them(tmp[1], date, maKH);
    //                            string maHD = hdBUS.LayMaHD(maKH, date);
    //                            hdBUS.ThemChiTiet(maHD, ID, SL);
    //                            Console.Write("\t\tBạn có muốn thêm tiếp không? (Nhấp 'Enter' để tiếp tục): ");
    //                            string q = Console.ReadLine();
    //                            if (q != "")
    //                                c = true;
    //                            else
    //                            {
    //                                Console.Clear();
    //                                qlHH.Show();
    //                                Console.Write("\t\tMời bạn chọn ID muốn đặt: ");
    //                                ID = Console.ReadLine().ToUpper();
    //                            }
    //                            Console.WriteLine("\t\tĐã thêm thành công!");
    //                        }
    //                        else
    //                        {
    //                            Console.Write("\t\tMã hàng hóa không tồn tại! Mời nhập lại (Nhấp 'Enter' để bỏ qua): ");
    //                            ID = Console.ReadLine().ToUpper();
    //                            if (ID == "")
    //                                c = true;
    //                        }
    //                    }
    //                }
    //            }
    //            else
    //                Console.WriteLine("\t\tKhách hàng không tồn tại!");
    //        }
    //        else
    //            Console.WriteLine("\t\tĐã thoát.");
    //    }

    //    private void TimKiem()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Tìm kiếm hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã hóa đơn: ");
    //        string maHD = Console.ReadLine().ToUpper();
    //        if (maHD != "")
    //        {
    //            if (hdBUS.TimKiem(maHD) != "")
    //            {
    //                Console.Clear();
    //                string[] tmp = hdBUS.TimKiem(maHD).Split('#');

    //                Console.SetWindowSize(140, 30);
    //                Console.WriteLine();
    //                Console.WriteLine();
    //                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //                Console.WriteLine("\t\t║                              Hóa đơn                           ║");
    //                Console.WriteLine("\t\t╠═════════╦══════════════════════════════════╦═══════════════════╣");
    //                Console.WriteLine("\t\t║    Mã   ║         Tên khách hàng           ║        Ngày       ║");
    //                Console.WriteLine("\t\t╠═════════╬══════════════════════════════════╬═══════════════════╣");
    //                Console.WriteLine("\t\t║ {0,-7} ║\t{1,-27}  ║  {2,-10}       ║", tmp[0], tmp[1], tmp[2]);
    //                Console.WriteLine("\t\t╚═════════╩══════════════════════════════════╩═══════════════════╝");

    //                Console.Write("\t\tNhập ký tự bất kỳ để xem chi tiết hoặc nhấp 'Enter' để thoát: ");
    //                string check = Console.ReadLine().ToUpper();
    //                if (check != "")
    //                {
    //                    bool c = false;
    //                    while (!c)
    //                    {
    //                        if (hdBUS.HienChiTiet(maHD).Count != 0)
    //                        {
    //                            int total = 0;

    //                            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
    //                            Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
    //                            Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
    //                            Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
    //                            Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
    //                            for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
    //                            {
    //                                string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
    //                                Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║  {2,-9}VND     ║     {3,-5}   ║   {4,-12}VND  ║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], int.Parse(tmp2[2]) * int.Parse(tmp2[3]));
    //                                total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
    //                            }
    //                            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");

    //                            Console.WriteLine();
    //                            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //                            Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}VND                                 ║", total);
    //                            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
    //                            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //                            c = true;
    //                        }
    //                        else
    //                        {
    //                            Console.Write("\t\tMã hóa đơn không tồn tại! Mời nhập lại (Nhấp 'Enter' để bỏ qua): ");
    //                            maHD = Console.ReadLine().ToUpper();
    //                            if (maHD == "")
    //                            {
    //                                c = true;
    //                                Console.WriteLine("\t\tĐã thoát!");
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        else
    //            Console.Write("\t\tĐã thoát.");
    //    }

    //    private void Xoa()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Xóa hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã hóa đơn: ");
    //        string maHD = Console.ReadLine().ToUpper();
    //        if (maHD != "")
    //        {
    //            if (hdBUS.TimKiem(maHD) != "")
    //            {
    //                Console.Write("Xác nhận xóa? (Y/N): ");
    //                string check = Console.ReadLine().ToUpper();
    //                while (check != "Y" && check != "N")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại: ");
    //                    check = Console.ReadLine().ToUpper();
    //                }
    //                if (check == "Y")
    //                {
    //                    hdBUS.Xoa(maHD);
    //                    Console.WriteLine("Đã xóa thành công!!!");
    //                }
    //                else
    //                    Console.WriteLine("Đã hủy xóa!!!");
    //            }
    //            else
    //                Console.WriteLine("Không thành công!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát!");
    //    }

    //    private void ThongKeNgay()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập ngày muốn thống kê (dd/MM/yyyy): ");
    //        string ngay = Console.ReadLine();
    //        if (ngay != "")
    //        {
    //            DateTime date = new DateTime();
    //            bool check = false;
    //            while (!check)
    //            {

    //                try
    //                {
    //                    date = DateTime.Parse(ngay);
    //                }
    //                catch
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                    ngay = Console.ReadLine();
    //                }
    //                if (date.ToString("dd/MM/yyyy") == "01/01/0001")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                    ngay = Console.ReadLine();
    //                }
    //                else
    //                    check = true;
    //            }
    //            Console.Clear();
    //            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //            Console.WriteLine("\t\t║ Thống kê ngày '{0, -10}':  {1,-12}VND                   ║",date.ToString("dd/MM/yyyy"), hdBUS.ThongKeNgay(date));
    //            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
    //            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //        }


    //    }

    //    private void ThongKeThang()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập tháng muốn thống kê (MM/yyyy): ");
    //        string thang = Console.ReadLine();
    //        if (thang != "")
    //        {
    //            DateTime date = new DateTime();
    //            bool check = false;
    //            while (!check)
    //            {

    //                try
    //                {
    //                    date = DateTime.Parse(thang);
    //                }
    //                catch
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (MM/yyyy): ");
    //                    thang = Console.ReadLine();
    //                }
    //                if (date.ToString("MM/yyyy") == "01/0001")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (MM/yyyy): ");
    //                    thang = Console.ReadLine();
    //                }
    //                else
    //                    check = true;
    //            }

    //            Console.Clear();
    //            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //            Console.WriteLine("\t\t║ Thống kê tháng {0, -10}:  {1,-12}VND                    ║", date.ToString("MM/yyyy"), hdBUS.ThongKeThang(date));
    //            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
    //            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //        }
    //    }

    //    private void ThongKeNam()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập năm muốn thống kê (yyyy): ");
    //        string nam = "01/" + Console.ReadLine();
    //        if (nam != "")
    //        {
    //            DateTime date = new DateTime();
    //            bool check = false;
    //            while (!check)
    //            {

    //                try
    //                {
    //                    date = DateTime.Parse(nam);
    //                }
    //                catch
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (yyyy): ");
    //                    nam = "01/" + Console.ReadLine();
    //                }
    //                if (date.ToString("yyyy") == "0001")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (yyyy): ");
    //                    nam = "01/" + Console.ReadLine();
    //                }
    //                else
    //                    check = true;
    //            }

    //            Console.Clear();
    //            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
    //            Console.WriteLine("\t\t║ Thống kê năm {0, -10}:  {1,-12}VND                      ║", date.ToString("yyyy"), hdBUS.ThongKeNam(date));
    //            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
    //            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
    //        }
    //    }
    //}
}
