using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Constraint;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Presentation
{
    
    class QuanLyPre
    {
        private QLKhachHang qlK = new QLKhachHang();
        private QLHangHoa qlHH = new QLHangHoa();
        private QLHoaDon qlHD = new QLHoaDon();
        private QLNhanVien qlNV = new QLNhanVien();

        public void MenuQuanLy()
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
                Console.Write("\n\t\t║ ║                             QUẢN LÝ                               ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║      QUẢN LÝ KHÁCH HÀNG      ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║      QUẢN LÝ NHÂN VIÊN       ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║      QUẢN LÝ HÀNG HÓA        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║       QUẢN LÝ HÓA ĐƠN        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 9.║         QUAY LẠI             ║                 ║ ║");
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
                        qlK.MenuKH();
                        break;
                    case '2':
                        qlNV.MenuNV();
                        break;
                    case '3':
                        qlHH.MenuHH();
                        break;
                    case '4':
                        qlHD.MenuHD();
                        break;
                    case '9':
                        TaiKhoanPre.QuanLy ql = new TaiKhoanPre.QuanLy();
                        ql.HienMenuQL();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuQuanLy();
                        break;
                }
            }
        }
    }

    // Quản lý hóa đơn
    class QLHoaDon
    {
        private HoaDonBUS hdBUS = new HoaDonBUS();
        private constraint conP = new constraint();

        public void MenuHD()
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
                Console.Write("\n\t\t║ ║                             HÓA ĐƠN                               ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║      HIỂN THỊ HÓA ĐƠN        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║        THÊM HÓA ĐƠN          ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║         XÓA HÓA ĐƠN          ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║          THỐNG KÊ            ║                 ║ ║");
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
                Console.SetCursorPosition(65, 32);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        Them();
                        break;
                    case '3':
                        TimKiem();
                        break;
                    case '4':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '5':
                        MenuThongKe();
                        Console.ReadKey();
                        break;
                    //case '6':
                    //    Sua();
                    //    break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuHD();
                        break;
                }
            }
        }

        private void MenuThongKe()
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
                Console.Write("\n\t\t║ ║                             THỐNG KÊ                              ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║        THỐNG KÊ NGÀY         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║       THỐNG KÊ THÁNG         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║        THỐNG KÊ NĂM          ║                 ║ ║");
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
                        ThongKeNgay();
                        Console.ReadKey();
                        break;
                    case '2':
                        ThongKeThang();
                        Console.ReadKey();
                        break;
                    case '3':
                        ThongKeNam();
                        Console.ReadKey();
                        break;
                    case '9':
                        MenuHD();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuThongKe();
                        break;
                }
            }
        }

        private void Show()
        {
            double sum = 0;
            int count = hdBUS.LayDanhSach().Count;

            // Tổng tất cả hóa đơn
            for (int x = 0; x < count; x++)
            {
                string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                sum += double.Parse(tmp[4]);
            }

            int start = 0, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end = count <= 6 ? count : 6;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;

                Console.SetWindowSize(140, 30);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                               HÓA ĐƠN                                           ║");
                Console.WriteLine("\t\t╠═════════╦══════════╦══════════════════════════════════╦═══════════════════╦═════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║ Mã khách ║         Tên khách hàng           ║        Ngày       ║         Tổng        ║");
                Console.WriteLine("\t\t╠═════════╬══════════╬══════════════════════════════════╬═══════════════════╬═════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                    Console.WriteLine("\t\t║ {0,-7} ║ {1,-7}  ║\t{2,-27}     ║  {3,-10}       ║ {4,-15}     ║", tmp[0], tmp[3], tmp[1], tmp[2], double.Parse(tmp[4]).ToString("N0"));
                }
                Console.WriteLine("\t\t╚═════════╩══════════╩══════════════════════════════════╩═══════════════════╩═════════════════════╝");

                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║ Tổng tiền của tất cả hóa đơn:  {0,-24}        ║", sum.ToString("N0"));
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

                Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ESC để thoát, nhấn ENTER để xem chi tiết...");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (curpage < totalpage) curpage++;
                    else curpage = 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (curpage > 1) curpage--;
                    else curpage = totalpage;
                }
                else if (key.Key == ConsoleKey.Escape)
                    return;
                else if(key.Key == ConsoleKey.Enter)
                {
                    HienThiChiTiet();
                    return;
                }

            } while (true);


        }

        //private void Sua()
        //{
        //    Console.Clear();
        //    ConstraintPre conP = new ConstraintPre();
        //    Console.WriteLine("Nhập mã: ");
        //    string maKH = Console.ReadLine().ToUpper();
        //    Console.Write("Nhập ngày: ");
        //    string date = Console.ReadLine();
        //    double total = hdBUS.TongTien(maKH, date);
        //    string[] tmp3 = hdBUS.LayThongTin(maKH).Split('\n');
        //    for (int x = 0; x < tmp3.Length - 1; x++)
        //    {
        //        string[] tmp4 = tmp3[x].Split('\t');
        //        if(maKH == tmp4[3] && tmp4[2] == date)
        //            hdBUS.Sua(tmp4[0], conP.Capitalize(tmp4[1]), DateTime.Parse(tmp4[2]), tmp4[3], total);
        //    }
        //}

        private void HienThiChiTiet()
        {
            //Console.Clear();
            //Show();
            Console.WriteLine();
            Console.Write("\t\tNhập mã hóa đơn để xem chi tiết (Nhấp 'Enter' để thoát): ");
            string maHD = Console.ReadLine().ToUpper();
            if (maHD != "")
            {
                bool c = false;
                while (!c)
                {
                    if(hdBUS.TimKiem(maHD) != "")
                    {
                        if (hdBUS.HienChiTiet(maHD).Count != 0)
                        {
                            Console.Clear();
                            int count = hdBUS.HienChiTiet(maHD).Count;
                            int total = 0;

                            for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                            {
                                string[] tmp = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                total += int.Parse(tmp[2]) * int.Parse(tmp[3]);
                            }

                            int start = 0, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                            int end = count <= 6 ? count : 6;
                            do
                            {
                                Console.Clear();
                                start = (curpage - 1) * 6;
                                end = curpage * 6 < count ? curpage * 6 : count;

                                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
                                Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
                                Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
                                Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
                                for (int x = start; x < end; x++)
                                {
                                    string[] tmp = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                    Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║ {2,-9}         ║     {3,-5}   ║ {4,-12}       ║", tmp[0], tmp[1], double.Parse(tmp[2]).ToString("N0"), tmp[3], (int.Parse(tmp[2]) * int.Parse(tmp[3])).ToString("N0"));

                                }
                                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");
                                //Console.WriteLine();
                                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}                                    ║", total.ToString("N2"));
                                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");


                                Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ESC để thoát, nhấn ENTER để trở về MENU...");
                                ConsoleKeyInfo key = Console.ReadKey();
                                if (key.Key == ConsoleKey.RightArrow)
                                {
                                    if (curpage < totalpage) curpage++;
                                    else curpage = 1;
                                }
                                else if (key.Key == ConsoleKey.LeftArrow)
                                {
                                    if (curpage > 1) curpage--;
                                    else curpage = totalpage;
                                }
                                else if (key.Key == ConsoleKey.Escape)
                                    return;
                                else if (key.Key == ConsoleKey.Enter)
                                {
                                    Show();
                                    return;
                                }

                            } while (true);


                        }
                        else
                        {
                            Console.Write("\t\tKhách hàng này chưa mua gì! Mời nhập lại (Nhấp 'Enter' để thoát): ");
                            maHD = Console.ReadLine().ToUpper();
                            if (maHD == "")
                                c = true;
                        }
                    }
                    else
                    {
                        Console.Write("\t\tMã hóa đơn không tồn tại! Mời nhập lại (Nhấp 'Enter' để thoát): ");
                        maHD = Console.ReadLine().ToUpper();
                        if (maHD == "")
                            c = true;
                    }
                        
                }
            }
            else
                Console.Write("\t\tĐã thoát!");
        }

        private void Them()
        {
            Console.Clear();
            KhachHangBUS khBUS = new KhachHangBUS();
            HangHoaBUS hhBUS = new HangHoaBUS();
            QLHangHoa qlHH = new QLHangHoa();
            Console.Clear();
            Console.Write("Nhấn 'Enter' để tiếp tục hoặc nhấn phím khác để thoát!: ");
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Mã khách hàng: ");
                string maKH = Console.ReadLine().ToUpper();
                if (khBUS.Laythongtin(maKH) != "")
                {
                    Console.Clear();
                    string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
                    DateTime date = DateTime.Now;

                    qlHH.Show();

                    Console.Write("\t\tNhập mã hàng hóa hoặc nhấn 'Enter' để thoát: ");
                    string ID = Console.ReadLine().ToUpper();

                    if (ID != "")
                    {
                        bool c = false;
                        double total = 0;
                        while (!c)
                        {
                            if (hhBUS.Laythongtin(ID) != "")
                            {
                                int SL = 0;
                                while (SL <= 0)
                                {
                                    try
                                    {
                                        Console.Write("\t\tSố lượng: ");
                                        SL = Int16.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\t\tDữ liệu là số!");
                                    }
                                }
                                // Thêm số lượng
                                int c1 = 0;
                                hdBUS.Them(tmp[1], date, maKH, total);
                                string maHD = hdBUS.LayMaHD(maKH, date);
                                for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                                {
                                    string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                    if (tmp2[0] == ID)
                                    {
                                        SL += int.Parse(tmp2[3]);
                                        c1 = 1;
                                        break;
                                    }
                                }

                                if (c1 == 0)
                                    hdBUS.ThemChiTiet(maHD, ID, SL);
                                else
                                    hdBUS.SuaChiTiet(maHD, ID, SL);
                                Console.Write("\t\tBạn có muốn thêm tiếp không? (Nhấp 'Enter' để tiếp tục): ");
                                string q = Console.ReadLine();
                                if (q != "")
                                    c = true;
                                else
                                {
                                    c = true;
                                    Them();
                                }

                            }
                            else
                            {
                                Console.Write("\t\tMã hàng hóa không tồn tại! Mời nhập lại (Nhấp 'Enter' để bỏ qua): ");
                                ID = Console.ReadLine().ToUpper();
                                if (ID == "")
                                    c = true;
                            }
                        }

                        // Cập nhật lại hóa đơn
                        string[] tmp3 = hdBUS.LayThongTin(maKH).Split('\n');
                        for (int x = 0; x < tmp3.Length - 1; x++)
                        {
                            string[] tmp4 = tmp3[x].Split('\t');
                            if (tmp4[3] == maKH && tmp4[2] == DateTime.Now.ToString("dd/MM/yyyy"))
                            {
                                total = hdBUS.TongTien(maKH, tmp4[2]);
                                hdBUS.Sua(tmp4[0], conP.Capitalize(tmp4[1]), DateTime.Parse(tmp4[2]), tmp4[3], total);
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("\nKhách hàng không tồn tại!");

                Console.Clear();
                Console.Write("Bạn có muốn tiếp tục thêm hóa đơn không? (Enter để tiếp tục): ");
                key = Console.ReadKey();

            }
        }

        private void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tìm kiếm hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã hóa đơn: ");
            string maHD = Console.ReadLine().ToUpper();
            if (maHD != "")
            {
                if (hdBUS.TimKiem(maHD) != "")
                {
                    Console.Clear();
                    string[] tmp = hdBUS.TimKiem(maHD).Split('#');

                    Console.SetWindowSize(140, 30);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║                              Hóa đơn                           ║");
                    Console.WriteLine("\t\t╠═════════╦══════════════════════════════════╦═══════════════════╣");
                    Console.WriteLine("\t\t║    Mã   ║         Tên khách hàng           ║        Ngày       ║");
                    Console.WriteLine("\t\t╠═════════╬══════════════════════════════════╬═══════════════════╣");
                    Console.WriteLine("\t\t║ {0,-7} ║\t{1,-27}  ║  {2,-10}       ║", tmp[0], tmp[1], tmp[2]);
                    Console.WriteLine("\t\t╚═════════╩══════════════════════════════════╩═══════════════════╝");

                    Console.Write("\t\tNhập ký tự bất kỳ để xem chi tiết hoặc nhấp 'Enter' để thoát: ");
                    string check = Console.ReadLine().ToUpper();
                    if (check != "")
                    {
                        Console.Clear();
                        bool c = false;
                        while (!c)
                        {
                            if (hdBUS.HienChiTiet(maHD).Count != 0)
                            {
                                int total = 0;

                                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
                                Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
                                Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
                                Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
                                for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                                {
                                    string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                    Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║  {2,-9}        ║     {3,-5}   ║ {4,-12}       ║", tmp2[0], tmp2[1], double.Parse(tmp2[2]).ToString("N0"), tmp2[3], (int.Parse(tmp2[2]) * int.Parse(tmp2[3])).ToString("N0"));
                                    total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
                                }
                                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");

                                Console.WriteLine();
                                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}                                    ║", total.ToString("N2"));
                                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
                                c = true;
                            }
                        }
                    }
                    else
                        Console.Write("\t\tĐã thoát!");
                }
                else
                    Console.Write("Đã thoát!");
            }
            else
                Console.Write("Đã thoát!");
            Console.ReadKey();
        }

        private void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xóa hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã hóa đơn: ");
            string maHD = Console.ReadLine().ToUpper();
            if (maHD != "")
            {
                if (hdBUS.TimKiem(maHD) != "")
                {
                    Console.Write("Xác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("Không hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        hdBUS.Xoa(maHD);
                        Console.WriteLine("Đã xóa thành công!!!");
                    }
                    else
                        Console.WriteLine("Đã hủy xóa!!!");
                }
                else
                    Console.WriteLine("Không thành công!");
            }
            else
                Console.WriteLine("Đã thoát!");
        }

        private void ThongKeNgay()
        {
            Console.Clear();
            Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập ngày muốn thống kê (dd/MM/yyyy): ");
            string ngay = Console.ReadLine();
            if (ngay != "")
            {
                DateTime date = new DateTime();
                bool check = false;
                while (!check)
                {

                    try
                    {
                        date = DateTime.Parse(ngay);
                    }
                    catch
                    {
                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                        ngay = Console.ReadLine();
                    }
                    if (date.ToString("dd/MM/yyyy") == "01/01/0001")
                    {
                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                        ngay = Console.ReadLine();
                    }
                    else
                        check = true;
                }
                Console.Clear();
                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║ Thống kê ngày '{0, -10}':  {1,-12}VND                   ║", date.ToString("dd/MM/yyyy"), hdBUS.ThongKeNgay(date).ToString("N2"));
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
            }


        }

        private void ThongKeThang()
        {
            Console.Clear();
            Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập tháng muốn thống kê (MM/yyyy): ");
            string thang = Console.ReadLine();
            if (thang != "")
            {
                DateTime date = new DateTime();
                bool check = false;
                while (!check)
                {

                    try
                    {
                        date = DateTime.Parse(thang);
                    }
                    catch
                    {
                        Console.Write("Không hợp lệ! Nhập lại (MM/yyyy): ");
                        thang = Console.ReadLine();
                    }
                    if (date.ToString("MM/yyyy") == "01/0001")
                    {
                        Console.Write("Không hợp lệ! Nhập lại (MM/yyyy): ");
                        thang = Console.ReadLine();
                    }
                    else
                        check = true;
                }

                Console.Clear();
                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║ Thống kê tháng {0, -10}:  {1,-12}VND                    ║", date.ToString("MM/yyyy"), hdBUS.ThongKeThang(date).ToString("N2"));
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
            }
        }

        private void ThongKeNam()
        {
            Console.Clear();
            Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập năm muốn thống kê (yyyy): ");
            string nam = "01/" + Console.ReadLine();
            if (nam != "")
            {
                DateTime date = new DateTime();
                bool check = false;
                while (!check)
                {

                    try
                    {
                        date = DateTime.Parse(nam);
                    }
                    catch
                    {
                        Console.Write("Không hợp lệ! Nhập lại (yyyy): ");
                        nam = "01/" + Console.ReadLine();
                    }
                    if (date.ToString("yyyy") == "0001")
                    {
                        Console.Write("Không hợp lệ! Nhập lại (yyyy): ");
                        nam = "01/" + Console.ReadLine();
                    }
                    else
                        check = true;
                }

                Console.Clear();
                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║ Thống kê năm {0, -10}:  {1,-12}VND                      ║", date.ToString("yyyy"), hdBUS.ThongKeNam(date).ToString("N2"));
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
            }
        }
    }

    // Quản lý hàng hóa
    class QLHangHoa
    {
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private constraint conP = new constraint();

        public void MenuHH()
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
                Console.Write("\n\t\t║ ║                             HÀNG HÓA                              ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH HÀNG HÓA  ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║       THÊM HÀNG HÓA          ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║         XÓA HÀNG HÓA         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║           TÌM KIẾM           ║                 ║ ║");
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
                Console.SetCursorPosition(65, 32);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        Them();
                        Console.ReadKey();
                        break;
                    case '3':
                        Sua();
                        break;
                    case '4':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '5':
                        TimKiem();
                        Console.ReadKey();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuHH();
                        break;
                }
            }
        }

        public void Show()
        {
            int count = hhBUS.Laydanhsach().Count;
            int start = 0, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end = count <= 6 ? count : 6;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;

                Console.SetWindowSize(140, 30);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
                Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
                Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = hhBUS.Laydanhsach()[x].Split('\t');
                    Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9} VND    ║", tmp[0], tmp[1], tmp[2]);
                }
                Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");


                Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để thoát...");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (curpage < totalpage) curpage++;
                    else curpage = 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (curpage > 1) curpage--;
                    else curpage = totalpage;
                }
                else if (key.Key == ConsoleKey.Enter)
                    break;

            } while (true);

        }

        private void Them()
        {
            Console.Clear();
            Console.Write("Nhấn 'Enter' để tiếp tục hoặc nhấn phím khác để thoát!: ");
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Nhập tên hàng hóa: ");
                string tenHH = Console.ReadLine();
                while (tenHH == "" || tenHH.Length > 30)
                {
                    Console.Write("Nhập lại (dưới 30 ký tự): ");
                    tenHH = Console.ReadLine();
                }

                int price = 0;
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
                hhBUS.Them(conP.Capitalize(tenHH), price);
                Console.WriteLine("Đã thêm thành công!");

                Console.Write("Bạn có muốn tiếp tục thêm hàng hóa không? (Enter để tiếp tục): ");
                key = Console.ReadKey();
            }
        }

        private void Sua()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Nhập mã hàng hóa muốn sửa (Nhập mã sai sẽ thoát!): ");
                string maHH = Console.ReadLine().ToUpper();
                if (hhBUS.Laythongtin(maHH) == "")
                    break;
                Console.Clear();
                string[] tmp = hhBUS.Laythongtin(maHH).Split('\t');
                string tenHH = tmp[1];
                int Gia = int.Parse(tmp[2]);
                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA THÔNG TIN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Tên: {0,-30}║", tenHH);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Giá: {0,-9}VND                  ║                 ", Gia);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 3.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 18);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                string t;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Tên mới (Enter để thoát): ");
                        t = Console.ReadLine();
                        if(t != "")
                        {
                            tenHH = t;
                            while (tenHH == "" || tenHH.Length > 30)
                            {
                                Console.Write("Nhập lại (dưới 30 ký tự): ");
                                tenHH = Console.ReadLine();
                            }
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Gia = 0;
                        while (Gia <= 0)
                        {
                            try
                            {
                                Console.Write("Nhập giá: ");
                                Gia = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Dữ liệu là số!");
                            }
                        }
                        
                        break;
                    case '3':
                        MenuHH();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }

                hhBUS.Sua(maHH, conP.Capitalize(tenHH), Gia);
            }

        }

        private void Xoa()
        {
            Console.Clear();
            Console.Write("Nhấp 'Enter' để xem danh sách hàng hóa: ");
            string check = Console.ReadLine();
            if (check == "")
                Show();
            Console.WriteLine("Xóa hàng hóa hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã hàng hóa muốn xóa: ");
            string maHH = Console.ReadLine().ToUpper();
            if (maHH != "")
            {
                Console.Write("Xác nhận xóa? (Y/N): ");
                string check2 = Console.ReadLine().ToUpper();
                while (check2 != "Y" && check2 != "N")
                {
                    Console.Write("Không hợp lệ! Nhập lại: ");
                    check2 = Console.ReadLine().ToUpper();
                }
                if (check2 == "Y")
                {
                    hhBUS.Xoa(maHH);
                    Console.WriteLine("Đã xóa thành công!!!");
                }
                else
                    Console.WriteLine("Đã hủy xóa!!!");
            }
            else
                Console.WriteLine("Đã thoát.");
        }

        private void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tìm kiếm hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã hàng hóa muốn tìm: ");
            string maHH = Console.ReadLine().ToUpper();
            if (maHH != "")
            {
                if (hhBUS.Laythongtin(maHH) != "")
                {
                    Console.Clear();
                    string[] tmp = hhBUS.Laythongtin(maHH).Split('\t');
                    Console.SetWindowSize(140, 30);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
                    Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
                    Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
                    Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
                    Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9} VND    ║", tmp[0], tmp[1], tmp[2]);
                    Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");
                    Console.Write("\t\tNhấn phím bất kì để kết thúc!");
                }
                else
                    Console.WriteLine("Hàng hóa không tồn tại!");
            }
            else
                Console.Write("Đã thoát.");
        }
    }

    // Quản lý nhân viên
    class QLNhanVien
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();

        public void MenuNV()
        {
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(103, 42);
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
                Console.Write("\n\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH NHÂN VIÊN ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║       THÊM NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║        XÓA NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 6.║    TẠO TÀI KHOẢN NHÂN VIÊN   ║                 ║ ║");
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
                Console.SetCursorPosition(65, 35);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        Them();
                        Console.ReadKey();
                        break;
                    case '3':
                        TimKiem();
                        Console.ReadKey();
                        break;
                    case '4':
                        Sua();
                        Console.ReadKey();
                        break;
                    case '5':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '6':
                        TaoTK();
                        Console.ReadKey();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuNV();
                        break;
                }
            }
        }

        private void Show()
        {
            int count = nvBUS.Laydanhsach().Count;
            int start = 0, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end = count <= 6 ? count : 6;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t║                                                                DANH SÁCH NHÂN VIÊN                                                                ║");
                Console.WriteLine("\t╠═════════╦════════════════════════════════╦═════════════════════╦═══════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
                Console.WriteLine("\t║    Mã   ║             Họ tên             ║       Ngày sinh     ║ Giới tính ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
                Console.WriteLine("\t╠═════════╬════════════════════════════════╬═════════════════════╬═══════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = nvBUS.Laydanhsach()[x].Split('\t');
                    Console.WriteLine("\t║  {0,-7}║\t{1,-27}║  {2,-10}         ║     {3,-3}   ║  {4,-17}║   {5,-10}       ║  {6,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6]);
                }
                Console.WriteLine("\t╚═════════╩════════════════════════════════╩═════════════════════╩═══════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
                Console.Write("\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để thoát...");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (curpage < totalpage) curpage++;
                    else curpage = 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (curpage > 1) curpage--;
                    else curpage = totalpage;
                }
                else if (key.Key == ConsoleKey.Enter)
                    break;

            } while (true);



            Console.Write("\tNhấn phím bất kì để kết thúc!");

        }

        private void TimKiem()
        {
            Console.Write("Nhập mã hoặc tên nhân viên (Nhấn Enter để thoát): ");
            string name = Console.ReadLine();
            if (name != "")
            {
                if (nvBUS.TimKiem(name) != "")
                {
                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    string[] tmp = nvBUS.TimKiem(name).Split('#');
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t║                                                                  TÌM THẤY {0,-2} KẾT QUẢ                                                              ║", tmp.Length - 1);
                    Console.WriteLine("\t╠═════════╦════════════════════════════════╦═════════════════════╦═══════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
                    Console.WriteLine("\t║    Mã   ║             Họ tên             ║       Ngày sinh     ║ Giới tính ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
                    Console.WriteLine("\t╠═════════╬════════════════════════════════╬═════════════════════╬═══════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
                    for (int i = 0; i < tmp.Length - 1; i++)
                    {
                        string[] tmp2 = tmp[i].Split('#');
                        Console.WriteLine("\t║  {0,-7}║\t{1,-27}║  {2,-10}         ║     {3,-3}   ║  {4,-17}║   {5,-10}       ║  {6,-27}║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], tmp2[4], tmp2[5], tmp2[6]);

                    }
                    Console.WriteLine("\t╚═════════╩════════════════════════════════╩═════════════════════╩═══════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
                    Console.Write("\tNhấn phím bất kì để kết thúc!");
                }
                else
                    Console.Write("Không có dữ liệu!");
            }
            else
                Console.Write("Đã thoát!");
        }

        private void Them()
        {
            Console.Clear();
            Console.Write("Nhấn 'Enter' để tiếp tục hoặc nhấn phím khác để thoát!: ");
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                string[] tmp = nvBUS.ThemTK().Split('#');
                Console.Write(
                    "Tài khoản được tạo thành công!\n" +
                    "TÀI KHOẢN      : " + tmp[0] +
                    "\nMẬT KHẨU     : " + tmp[1] +
                    "\nMÃ NHÂN VIÊN : " + tmp[2]);
                Console.ReadKey();
                Console.Clear();
                NhanVienPre nvP = new NhanVienPre();
                nvP.ThemThongTin(tmp[2]);
                Console.WriteLine("Thêm nhân viên thành công!");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Bạn có muốn tiếp tục thêm nhân viên không? (Enter để tiếp tục): ");
                key = Console.ReadKey();
            }
        }

        private void Sua()
        {
            Console.Clear();
            Console.Write("Nhập mã nhân viên muốn sửa (Hoặc nhấn Enter để thoát!): ");
            string maNV = Console.ReadLine().ToUpper();
            if (maNV != "")
            {
                if (nvBUS.TimKiem(maNV) != "")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.SetWindowSize(103, 35);
                        Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║   ║          SỬA NHÂN VIÊN              ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 1.║          Sửa thông tin              ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 2.║          Sửa tài khoản              ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 9.║             Quay lại                ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                        Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                        Console.SetCursorPosition(61, 18);
                        char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                        switch (chose)
                        {
                            case '1':
                                NhanVienPre nv = new NhanVienPre();
                                nv.SuaThongTin(maNV);
                                break;
                            case '2':
                                SuaTK(maNV);
                                break;
                            case '9':
                                MenuNV();
                                break;
                            case '0':
                                Environment.Exit(0);
                                break;
                            default:

                                break;
                        }
                    }
                }
                else
                    Console.Write("Khách hàng không tồn tại!");
            }
        }

        private void SuaTK(string maNV)
        {
            bool c = false;
            while (!c)
            {
                Console.Clear();

                string[] tmp = nvBUS.LaythongtinTK(maNV).Split('\t');
                string tenTK = tmp[0], MK = tmp[1];
                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA TÀI KHOẢN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Tài khoản: {0,-24}║", tenTK);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Mật khẩu: {0,-17}        ║                 ", MK);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 18);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Tài khoản mới (Dưới 24 ký tự): ");
                        tenTK = Console.ReadLine();
                        while(tenTK == "" || tenTK.Length > 27)
                        {
                            Console.Write("Nhập lại (Dưới 24 ký tự): ");
                            tenTK = Console.ReadLine();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Mật khẩu mới (Dưới 17 ký tự): ");
                        MK = Console.ReadLine();
                        while (MK == "" || MK.Length > 17)
                        {
                            Console.Write("Nhập lại (Dưới 17 ký tự): ");
                            MK = Console.ReadLine();
                        }
                        break;
                    case '9':
                        c = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        SuaTK(maNV);
                        break;
                }
            }
        }

        private void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xóa nhân viên hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã nhân viên muốn xóa: ");
            string maNV = Console.ReadLine().ToUpper();
            if (maNV != "")
            {
                if (nvBUS.TimKiem(maNV) != "")
                {
                    Console.Write("Xác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("Không hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        nvBUS.Xoa(maNV);
                        Console.WriteLine("Đã xóa thành công!!!");
                    }
                    else
                        Console.WriteLine("Đã hủy xóa!!!");
                }
                else
                    Console.WriteLine("Khách hàng không tồn tại!");
            }
            else
                Console.WriteLine("Đã thoát!");
        }

        private void TaoTK()
        {
            Console.Clear();
            string[] tmp = nvBUS.ThemTK().Split('#');
            Console.WriteLine("Tài khoản: {0}\nMật khẩu: {1}\nMã nhân viên: {2}", tmp[0], tmp[1], tmp[2]);
            Console.WriteLine("Tạo tài khoản thành công");
        }
    }

    // Quản lý khách hàng
    class QLKhachHang
    {
        private KhachHangBUS khBUS = new KhachHangBUS();

        public void MenuKH()
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
                Console.Write("\n\t\t║ ║                       TÀI KHOẢN KHÁCH HÀNG                        ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║     HIỂN THỊ KHÁCH HÀNG      ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║       THÊM KHÁCH HÀNG        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║        XÓA KHÁCH HÀNG        ║                 ║ ║");
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
                Console.SetCursorPosition(65, 32);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        Them();
                        Console.ReadKey();
                        break;
                    case '3':
                        TimKiem();
                        Console.ReadKey();
                        break;
                    case '4':
                        Sua();
                        Console.ReadKey();
                        break;
                    case '5':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuKH();
                        break;
                }
            }
        }

        private void Show()
        {
            int count = khBUS.Laydanhsach().Count;
            int start = 0, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end = count <= 6 ? count : 6;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(140, 30);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                       DANH SÁCH KHÁCH HÀNG                                                      ║");
                Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
                Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = khBUS.Laydanhsach()[x].Split('\t');
                    Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);

                }

                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");

                Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để thoát...");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (curpage < totalpage) curpage++;
                    else curpage = 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (curpage > 1) curpage--;
                    else curpage = totalpage;
                }
                else if (key.Key == ConsoleKey.Enter)
                    break;

            } while (true);
        }

        private void Them()
        {
            Console.Clear();
            Console.Write("Nhấn 'Enter' để tiếp tục hoặc nhấn phím khác để thoát!: ");
            ConsoleKeyInfo key = Console.ReadKey();
            
            while(key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Tạo tài khoản tự động (Enter)\n" +
                              "Tạo thủ công nhấn phím khác: ");
                key = Console.ReadKey();
                if(key.Key == ConsoleKey.Enter)
                {
                    string acc = khBUS.ThemTKTuDong();
                    string[] tmp = acc.Split('#');
                    Console.WriteLine(
                        "Tài khoản được tạo thành công!\n" +
                        "TÀI KHOẢN  : " + tmp[1] +
                        "\nMẬT KHẨU : " + tmp[2] );
                    Console.ReadKey();
                    KhachHangPre khP = new KhachHangPre();
                    khP.ThemThongTin(tmp[2]);
                    Console.Clear();
                }
                else
                {
                    do
                    {
                        Console.Clear();

                        Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                        Console.Write("\n\t║                               TẠO TÀI KHOẢN                           ║");
                        Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                        Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                        Console.Write("\n\t║ TẠO TÀI KHOẢN HOẶC NHẤN 'ENTER' ĐỂ QUAY LẠI!                          ║");
                        Console.Write("\n\t║                                                                       ║");
                        Console.Write("\n\t║      TÀI KHOẢN       :                                                ║");
                        Console.Write("\n\t║                                                                       ║");
                        Console.Write("\n\t║      MẬT KHẨU        :                                                ║");
                        Console.Write("\n\t║                                                                       ║");
                        Console.Write("\n\t║  NHẬP LẠI MẬT KHẨU   :                                                ║");
                        Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");

                        Console.SetCursorPosition(34, 7);
                        string TK = Console.ReadLine();
                        if (TK == "")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(34, 9);
                            string MK1 = Console.ReadLine();
                            Console.SetCursorPosition(34, 11);
                            string MK2 = Console.ReadLine();


                            if (MK1 == MK2)
                            {
                                if (khBUS.CheckTK(TK) == true)
                                    Console.Write("\n\n\tTài khoản đã tồn tại!");
                                else
                                {
                                    khBUS.ThemTK(TK, MK1);
                                    Console.WriteLine("\n\n\tTạo tài khoản thành công!");
                                    Console.ReadKey();

                                    // Lấy mã
                                    Console.Clear();
                                    string[] tmp = khBUS.LaythongtinTK(TK).Split('\t');
                                    string maKH = tmp[2];

                                    KhachHangPre khP = new KhachHangPre();
                                    khP.ThemThongTin(maKH);
                                    Console.Clear();
                                    break;

                                }
                            }

                        }
                        Console.ReadKey();
                    } while (true);
                    
                }

                Console.Write("Bạn có muốn tiếp tục thêm khách hàng không? (Enter để tiếp tục): ");
                key = Console.ReadKey();
            }

        }

        private void TimKiem()
        {
            Console.Clear();
            Console.Write("Nhập mã hoặc tên khách hàng (Nhấn 'Enter' để thoát): ");
            string name = Console.ReadLine();
            if (name != "")
            {
                if (khBUS.TimKiem(name) != "")
                {
                    Console.Clear();
                    string[] tmp = khBUS.TimKiem(name).Split('\n');
                    Console.SetWindowSize(140, 30);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║                                             TÌM THẤY {0,-2} KẾT QUẢ                                                 ║", tmp.Length - 1);
                    Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
                    Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
                    Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
                    for (int i = 0; i < tmp.Length - 1; i++)
                    {
                        string[] tmp2 = tmp[i].Split('#');
                        Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], tmp2[4]);

                    }
                    Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
                    Console.Write("\t\tNhấn phím bất kì để kết thúc!");
                    
                }
                Console.Write("Không có dữ liệu!");
            }
            else
                Console.Write("Đã thoát!");
        }

        private void Sua()
        {
            Console.Clear();
            Console.Write("Nhập mã khách hàng muốn sửa (Nhấn Enter để thoát!): ");
            string maKH = Console.ReadLine().ToUpper();
            if (maKH != "")
            {
                if (khBUS.TimKiem(maKH) != "")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.SetWindowSize(103, 35);
                        Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║   ║          SỬA KHÁCH HÀNG             ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 1.║          Sửa thông tin              ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 2.║          Sửa tài khoản              ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                        Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                        Console.SetCursorPosition(61, 18);
                        char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                        switch (chose)
                        {
                            case '1':
                                KhachHangPre kh = new KhachHangPre();
                                kh.SuaThongTin(maKH);
                                break;
                            case '2':
                                SuaTK(maKH);
                                break;
                            case '9':
                                MenuKH();
                                break;
                            case '0':
                                Environment.Exit(0);
                                break;
                            default:
                                
                                break;
                        }
                    }
                }
                else
                    Console.Write("Khách hàng không tồn tại!");
            }

        }

        private void SuaTK(string maKH)
        {
            bool c = false;
            while (!c)
            {
                Console.Clear();

                string[] tmp = khBUS.LaythongtinTK(maKH).Split('\t');
                string tenTK = tmp[0], MK = tmp[1];
                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA TÀI KHOẢN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Tài khoản: {0,-24}║", tenTK);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Mật khẩu: {0,-17}        ║                 ", MK);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 18);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Tài khoản mới (Dưới 24 ký tự): ");
                        tenTK = Console.ReadLine();
                        while (tenTK == "" || tenTK.Length > 27)
                        {
                            Console.Write("Nhập lại (Dưới 24 ký tự): ");
                            tenTK = Console.ReadLine();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Mật khẩu mới (Dưới 17 ký tự): ");
                        MK = Console.ReadLine();
                        while (MK == "" || MK.Length > 17)
                        {
                            Console.Write("Nhập lại (Dưới 17 ký tự): ");
                            MK = Console.ReadLine();
                        }
                        break;
                    case '9':
                        c = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        SuaTK(maKH);
                        break;
                }
            }
        }

        private void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xóa khách hàng hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập mã khách hàng muốn xóa: ");
            string maKH = Console.ReadLine().ToUpper();
            if (maKH != "")
            {
                if (khBUS.Laythongtin(maKH) != "")
                {
                    Console.Write("Xác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("Không hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        khBUS.Xoa(maKH);
                        Console.WriteLine("Đã xóa thành công!!!");
                    }
                    else
                        Console.WriteLine("Đã hủy xóa!!!");
                }
                else
                    Console.WriteLine("Khách hàng không tồn tại!");
            }
            else
                Console.WriteLine("Đã thoát!");
        }
    }
}
