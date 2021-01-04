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
        private NhanVienBUS nvBUS = new NhanVienBUS();

        public void MenuQuanLy(string maNV)
        {
            string[] tmp = nvBUS.Laythongtin(maNV).Split('#');
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                             QUẢN LÝ                               ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║      QUẢN LÝ KHÁCH HÀNG      ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║      QUẢN LÝ NHÂN VIÊN       ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║      QUẢN LÝ HÀNG HÓA        ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║       QUẢN LÝ HÓA ĐƠN        ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 9.║         QUAY LẠI             ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(80, 29);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        qlK.MenuKH(maNV);
                        break;
                    case '2':
                        if(tmp[8] != qlNV.listPosition[3]) // Lễ tân không thể quản lý nhân viên
                            qlNV.MenuNV(maNV);
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                      BẠN KHÔNG CÓ QUYỀN TRUY CẬP                      ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        
                        qlHH.MenuHH(maNV);
                        break;
                    case '4':
                        qlHD.MenuHD(maNV);
                        break;
                    case '9':
                        TaiKhoanPre.QuanLy ql = new TaiKhoanPre.QuanLy();
                        ql.HienMenuQL();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuQuanLy(maNV);
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
        private NhanVienBUS nvBUS = new NhanVienBUS();

        public void MenuHD(string maNV)
        {
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                             HÓA ĐƠN                               ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║      HIỂN THỊ HÓA ĐƠN        ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║        THÊM HÓA ĐƠN          ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║         XÓA HÓA ĐƠN          ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 5.║          THỐNG KÊ            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(80, 32);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        Them(maNV);
                        break;
                    case '3':
                        TimKiem();
                        break;
                    case '4':
                        Xoa();
                        break;
                    case '5':
                        MenuThongKe(maNV);
                        Console.ReadKey();
                        break;
                    //case '6':
                    //    Sua();
                    //    break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuHD(maNV);
                        break;
                }
            }
        }

        private void MenuThongKe(string maNV)
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
                        break;
                    case '2':
                        ThongKeThang();
                        break;
                    case '3':
                        ThongKeNam();
                        break;
                    case '9':
                        MenuHD(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuThongKe(maNV);
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

            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                                         DANH SÁCH HÓA ĐƠN                                                                     ║");
                Console.WriteLine("\t\t╠═════════╦══════════╦══════════════════════════════════╦═══════════════════╦═════════════════════╦══════════╦══════════════════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║ Mã khách ║         Tên khách hàng           ║        Ngày       ║       Đơn giá       ║   Mã NV  ║        Nhân viên giao dịch       ║");
                Console.WriteLine("\t\t╠═════════╬══════════╬══════════════════════════════════╬═══════════════════╬═════════════════════╬══════════╬══════════════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                    string[] tmp2 = nvBUS.Laythongtin(tmp[5]).Split('#'); // Lấy thông tin nhân viên
                    Console.WriteLine("\t\t║ {0,-7} ║ {1,-7}  ║\t{2,-27}     ║  {3,-10}       ║ {4,-15}     ║ {5,-7}  ║\t{6,-27}     ║", tmp[0], tmp[3], tmp[1], tmp[2], double.Parse(tmp[4]).ToString("N0"), tmp[5], tmp2[1]);
                }
                Console.WriteLine("\t\t╚═════════╩══════════╩══════════════════════════════════╩═══════════════════╩═════════════════════╩══════════╩══════════════════════════════════╝");

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
                    if(hdBUS.LayThongTin(maHD) != "")
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

                            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                            int end;
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
                            Console.Write("\t\tMã hóa đơn không tồn tại! Mời nhập lại (Nhấp 'Enter' để thoát): ");
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

        private void Them(string maNV)
        {
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
                    // Get Date Now
                    DateTime date = DateTime.Now;
                    // Menu
                    qlHH.Show();

                    Console.Write("\n\t\tNhập mã hàng hóa hoặc nhấn 'Enter' để thoát: ");
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
                                int c1 = 0;// Check hóa đơn chi tiết
                                // Thêm hóa đơn với tên khách, ngày, mã khách, tổng hóa đơn = 0
                                // Nếu như mã khách hàng và ngày bị trùng thì hóa đơn không được thêm nữa
                                hdBUS.Them(tmp[1], date, maKH, total, maNV);
                                // Lấy mã hóa đơn
                                string maHD = hdBUS.LayMaHD(maKH, date);
                                // Cập nhật số lượng 
                                for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                                {
                                    string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                    //Nếu khách hàng order lần tiếp theo là mã đã nhập rồi thì cộng thêm số lượng
                                    if (tmp2[0] == ID)
                                    {
                                        SL += int.Parse(tmp2[3]);
                                        c1 = 1;
                                        break;
                                    }
                                }
                                // c1 == 0 Hóa đơn chi tiết chưa tồn tại
                                if (c1 == 0)
                                    hdBUS.ThemChiTiet(maHD, ID, SL);
                                // c1 == 1 Hóa đơn đã tồn tại
                                else
                                    hdBUS.SuaChiTiet(maHD, ID, SL); //Cập nhật lại hóa đơn chi tiết
                                Console.Write("\t\tBạn có muốn thêm tiếp không? (Nhấp 'Enter' để tiếp tục): ");
                                string q = Console.ReadLine();
                                if (q != "")
                                    c = true;
                                else
                                {
                                    Them(maNV);
                                    return;
                                    
                                }

                            }
                            else
                            {
                                Console.Write("\t\tMã hàng hóa không tồn tại! Mời nhập lại (Nhấp 'Enter' để thoát: ");
                                ID = Console.ReadLine().ToUpper();
                                if (ID == "")
                                    c = true;
                            }
                        }

                        // Lấy thông tin của hóa đơn
                        string[] tmp3 = hdBUS.LayThongTin(maKH).Split('\n');
                        for (int x = 0; x < tmp3.Length - 1; x++)
                        {
                            string[] tmp4 = tmp3[x].Split('\t');
                            // Nếu mã khách hàng và ngày có trong hệ thống
                            if (tmp4[3] == maKH && tmp4[2] == DateTime.Now.ToString("dd/MM/yyyy"))
                            {
                                // Tính tổng tiền những gì khách hàng đã nhập
                                total = hdBUS.TongTien(maKH, tmp4[2]);
                                // Cập nhật hóa đơn
                                hdBUS.Sua(tmp4[0], conP.Capitalize(tmp4[1]), DateTime.Parse(tmp4[2]), tmp4[3], total, maNV);
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("\nKhách hàng không tồn tại!");
                Console.Clear();
                Console.WriteLine("\nĐặt hàng thành công!!!");
                Console.Write("Bạn có muốn tiếp tục thêm hóa đơn không? (Enter để tiếp tục): ");
                key = Console.ReadKey();

            }
        }

        private void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tTìm kiếm hoặc nhấn 'Enter' để thoát.");
            Console.Write("\t\tNhập mã hóa đơn hoặc tên khách hàng: ");
            string name = Console.ReadLine().ToUpper();
            List<string> list = new List<string>();
            if (name != "" && hdBUS.TimKiem(name) != "")
            {
                Console.Clear();
                string[] tmp = hdBUS.TimKiem(name).Split('\n');

                foreach(string x in tmp)
                {
                    string[] tmpID = x.Split('\t');
                    list.Add(tmpID[0]);
                }

                int count = tmp.Length - 1;
                int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                int end;
                do
                {
                    Console.Clear();
                    start = (curpage - 1) * 6;
                    end = curpage * 6 < count ? curpage * 6 : count;

                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║                                       TÌM THẤY {0,-5} KẾT QUẢ                                    ║", count);
                    Console.WriteLine("\t\t╠═════════╦══════════╦══════════════════════════════════╦═══════════════════╦═════════════════════╣");
                    Console.WriteLine("\t\t║    Mã   ║ Mã khách ║         Tên khách hàng           ║        Ngày       ║     Thành tiền      ║");
                    Console.WriteLine("\t\t╠═════════╬══════════╬══════════════════════════════════╬═══════════════════╬═════════════════════╣");
                    for (int x = start; x < end; x++)
                    {
                        string[] tmp2 = tmp[x].Split('#');
                        Console.WriteLine("\t\t║ {0,-7} ║ {1,-7}  ║\t{2,-27}     ║  {3,-10}       ║ {4,-15}     ║", tmp2[0], tmp2[3], tmp2[1], tmp2[2], double.Parse(tmp2[4]).ToString("N0"));
                        
                    }
                    Console.WriteLine("\t\t╚═════════╩══════════╩══════════════════════════════════╩═══════════════════╩═════════════════════╝");

                    Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, nhấn ENTER để thoát...");
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


                do 
                {
                    
                    Console.Write("\n\t\tNhập mã hóa đơn để xem chi tiết hoặc nhấp 'Enter' để thoát: ");
                    string maHD = Console.ReadLine().ToUpper();
                    if (maHD != "" && hdBUS.LayThongTin(maHD) != "")
                    {
                        int c = 0;
                        //check mã hóa đơn trong những kết quả đã tìm
                        foreach (string ID in list) { if (ID != maHD) c = 1; }
                        if (c == 0)
                        {
                            if (hdBUS.HienChiTiet(maHD).Count != 0)
                            {
                                Console.Clear();
                                int count2 = hdBUS.HienChiTiet(maHD).Count;
                                double total = 0;

                                for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                                {
                                    string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                    total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
                                }

                                int start2, curpage2 = 1, totalpage2 = count2 % 6 == 0 ? count2 / 6 : count2 / 6 + 1;
                                int end2;


                                do
                                {
                                    Console.Clear();
                                    start2 = (curpage - 1) * 6;
                                    end2 = curpage * 6 < count ? curpage * 6 : count;

                                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
                                    Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
                                    Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
                                    Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
                                    for (int x = start2; x < end2; x++)
                                    {
                                        string[] tmp3 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                        Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║ {2,-9}         ║     {3,-5}   ║ {4,-12}       ║", tmp3[0], tmp3[1], double.Parse(tmp3[2]).ToString("N0"), tmp3[3], (int.Parse(tmp3[2]) * int.Parse(tmp3[3])).ToString("N0"));

                                    }
                                    Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");
                                    //Console.WriteLine();
                                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}                                    ║", total.ToString("N2"));
                                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");




                                    Console.Write("\t\tTrang " + curpage2 + "/" + totalpage2 + "          Ấn <-, -> để xem tiếp, ENTER để tiếp tục...");
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    if (key.Key == ConsoleKey.RightArrow)
                                    {
                                        if (curpage2 < totalpage2) curpage2++;
                                        else curpage2 = 1;
                                    }
                                    else if (key.Key == ConsoleKey.LeftArrow)
                                    {
                                        if (curpage2 > 1) curpage2--;
                                        else curpage2 = totalpage2;
                                    }
                                    else if (key.Key == ConsoleKey.Enter)
                                    {
                                        TimKiem();
                                        return;
                                    }

                                } while (true);
                            }
                            else
                                Console.Write("\n\t\tKhông có dữ liệu!");

                        }
                        else
                        {
                            Console.Write("\n\t\tNhập mã theo bảng đã hiển thị!");
                            
                        }
                    }
                    else
                        return;
                } while (true);
                
            }
            else
                Console.Write("\t\tĐã thoát!");
            Console.ReadKey();
        }

        private void Xoa()
        {
            while (true) 
            {
                Console.Clear();
                Show();
                Console.WriteLine("\n\t\tXóa hóa đơn hoặc nhấn 'Enter' để thoát.");
                Console.Write("\t\tNhập mã hóa đơn: ");
                string maHD = Console.ReadLine().ToUpper();
                if (maHD != "" && hdBUS.LayThongTin(maHD) != "")
                {
                    Console.Write("\t\tXác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("\t\tKhông hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        hdBUS.Xoa(maHD);
                        Console.Write("\t\tĐã xóa thành công!!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\t\tĐã hủy xóa!!!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (maHD == "") return;
                    Console.Write("\n\t\tMã {0} không tồn tại!", maHD);
                }

            }
        }

        private void ThongKeNgay()
        {
            while (true)
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
                }
                else break;


                double sum = 0;

                List<string> list = new List<string>();
                // Tổng hóa đơn theo ngày
                for (int x = 0; x < hdBUS.LayDanhSach().Count; x++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                    if(ngay == tmp[2])
                    {
                        list.Add(hdBUS.LayDanhSach()[x]);
                        sum += double.Parse(tmp[4]);
                    }
                }
                int i = DanhSachThongKe(list, sum);
                if (i == 0) return;
                
            }

        }

        private int DanhSachThongKe(List<string> list, double sum)
        {
            int count = list.Count;

            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;

                Console.SetWindowSize(140, 30);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                             DANH SÁCH HÓA ĐƠN                                   ║");
                Console.WriteLine("\t\t╠═════════╦══════════╦══════════════════════════════════╦═══════════════════╦═════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║ Mã khách ║         Tên khách hàng           ║        Ngày       ║     Thành tiền      ║");
                Console.WriteLine("\t\t╠═════════╬══════════╬══════════════════════════════════╬═══════════════════╬═════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = list[x].Split('\t');
                    Console.WriteLine("\t\t║ {0,-7} ║ {1,-7}  ║\t{2,-27}     ║  {3,-10}       ║ {4,-15}     ║", tmp[0], tmp[3], tmp[1], tmp[2], double.Parse(tmp[4]).ToString("N0"));
                }
                Console.WriteLine("\t\t╚═════════╩══════════╩══════════════════════════════════╩═══════════════════╩═════════════════════╝");

                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║ Tổng tiền của tất cả hóa đơn:  {0,-24}        ║", sum.ToString("N0"));
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

                Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ESC để thoát, nhấn ENTER để tiếp tục...");
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
                    return 0;
                else if (key.Key == ConsoleKey.Enter)
                {
                    return 1;
                }

            } while (true);

        }

        private void ThongKeThang()
        {
            while (true)
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
                }
                else break;


                double sum = 0;
                DateTime DateMM = DateTime.Parse(thang);
                List<string> list = new List<string>();
                // Tổng hóa đơn theo ngày
                for (int x = 0; x < hdBUS.LayDanhSach().Count; x++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                    DateTime DateTMP = DateTime.Parse(tmp[2]);
                    

                    if (DateMM.Month == DateTMP.Month && DateMM.Year == DateMM.Year)
                    {
                        list.Add(hdBUS.LayDanhSach()[x]);
                        sum += double.Parse(tmp[4]);
                    }
                }

                int i = DanhSachThongKe(list, sum);
                if (i == 0) return;

            }
        }

        private void ThongKeNam()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Thống kê hoặc nhấn 'Enter' để thoát.");
                Console.Write("Nhập năm muốn thống kê (yyyy): ");
                string year = Console.ReadLine();
                if (year != "")
                {
                    while (true)
                    {
                        for (int x = 0; x < year.Length; x++)
                        {
                            // Kiểm tra SDT
                            if (!char.IsDigit(year[x])) 
                            {
                                Console.Write("Nhập lại (yyyy): ");
                                year = Console.ReadLine();
                                x = -1;
                            }
                        }
                        if (year == "")
                        {
                            Console.Write("Nhập lại (yyyy): ");
                            year = Console.ReadLine();
                        }
                        else
                            break;
                    }
                }
                else break;


                double sum = 0;

                List<string> list = new List<string>();
                // Tổng hóa đơn theo ngày
                for (int x = 0; x < hdBUS.LayDanhSach().Count; x++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                    if (int.Parse(year) == DateTime.Parse(tmp[2]).Year)
                    {
                        list.Add(hdBUS.LayDanhSach()[x]);
                        sum += double.Parse(tmp[4]);
                    }
                }

                int i = DanhSachThongKe(list, sum);
                if (i == 0) return;
            }
        }
    }

    // Quản lý hàng hóa
    class QLHangHoa
    {
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private constraint conP = new constraint();
        private QLNhanVien qlNV = new QLNhanVien();
        private NhanVienBUS nvBUS = new NhanVienBUS();

        public void MenuHH(string maNV)
        {
            string[] tmp = nvBUS.Laythongtin(maNV).Split('#');
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                             HÀNG HÓA                              ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH HÀNG HÓA  ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║       THÊM HÀNG HÓA          ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║         XÓA HÀNG HÓA         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 5.║           TÌM KIẾM           ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(80, 32);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        Show();
                        break;
                    case '2':
                        // Lễ tân không thể truy cập vào đây
                        if(tmp[8] != qlNV.listPosition[3])
                            Them();
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                      BẠN KHÔNG CÓ QUYỀN TRUY CẬP                      ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        // Lễ tân không thể truy cập vào đây
                        if (tmp[8] != qlNV.listPosition[3])
                            Sua(maNV);
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                      BẠN KHÔNG CÓ QUYỀN TRUY CẬP                      ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        // Lễ tân không thể truy cập vào đây
                        if (tmp[8] != qlNV.listPosition[3])
                            Xoa();
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                      BẠN KHÔNG CÓ QUYỀN TRUY CẬP                      ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        break;
                    case '5':
                        TimKiem();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuHH(maNV);
                        break;
                }
            }
        }

        public void Show()
        {
            int count = hhBUS.Laydanhsach().Count;
            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
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
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Write("Nhấn 'Enter' để tiếp tục hoặc nhấn phím khác để thoát!: ");
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();


                Console.Write("\n\t\t╔═════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║                             THÊM HÀNG HÓA                           ║");
                Console.Write("\n\t\t╠═════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                     ║");
                Console.Write("\n\t\t║ ╔═════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║  NHẤN ENTER ĐỂ THOÁT!                                           ║ ║");
                Console.Write("\n\t\t║ ║                                                                 ║ ║");
                Console.Write("\n\t\t║ ║  Tên hàng hóa :                                                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                 ║ ║");
                Console.Write("\n\t\t║ ║  Giá          :                                                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                 ║ ║");
                Console.Write("\n\t\t║ ╚═════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                     ║");
                Console.Write("\n\t\t╚═════════════════════════════════════════════════════════════════════╝");


                Console.SetCursorPosition(36, 8);
                string tenHH = Console.ReadLine();
                if (tenHH == "") return;
                tenHH = conP.CheckStr2(tenHH, 30, 36, 8, 30, 14);

                Console.SetCursorPosition(36, 10);
                string priceStr = Console.ReadLine();
                priceStr = conP.Price2(priceStr, 36, 10, 35, 14);

                hhBUS.Them(conP.Capitalize(tenHH), Convert.ToDouble(priceStr));

                Console.SetCursorPosition(28, 14);
                Console.Write("Bạn đã thêm thông tin thành công!!!          ");
                Console.ReadKey();

                Console.Write("\n\n\t\tNhấp ENTER để tiếp tục, phím khác để thoát!   ");
                key = Console.ReadKey();
            }
        }

        private void Sua(string maNV)
        {
            Show();
            Console.Write("\n\t\tNhập mã hàng hóa muốn sửa (Nhập mã sai sẽ thoát!): ");
            string maHH = Console.ReadLine().ToUpper();
            if (hhBUS.Laythongtin(maHH) == "")
                return;
            while (true)
            {
                Console.Clear();
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                string[] tmp = hhBUS.Laythongtin(maHH).Split('\t');
                string tenHH = tmp[1];
                double Gia = double.Parse(tmp[2]);
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
                Console.Write("\n\t\t             ║ 2.║  Giá: {0,-9}                     ║                 ", Gia.ToString("N0"));
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
                string t;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Tên mới (Enter để thoát): ");
                        t = Console.ReadLine();
                        if(t != "")
                            tenHH = conP.CheckStr(t, 30);
                        break;
                    case '2':
                        Console.Clear();
                        Gia = 0;
                        Gia = conP.Price(Gia);
                        
                        break;
                    case '9':
                        MenuHH(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.SetCursorPosition(35, 20);
                        Console.Write("Không hợp lệ!!!");
                        break;
                }

                hhBUS.Sua(maHH, conP.Capitalize(tenHH), Gia);
            }

        }

        private void Xoa()
        {
            while (true)
            {
                Console.Clear();
                Show();
                Console.WriteLine("\n\t\tXóa hàng hóa hoặc nhấn 'Enter' để thoát.");
                Console.Write("\t\tNhập mã hàng hóa muốn xóa: ");
                string maHH = Console.ReadLine().ToUpper();
                if (maHH != "" && hhBUS.Laythongtin(maHH) != "")
                {
                    Console.Write("\t\tXác nhận xóa? (Y/N): ");
                    string check2 = Console.ReadLine().ToUpper();
                    while (check2 != "Y" && check2 != "N")
                    {
                        Console.Write("\t\tKhông hợp lệ! Nhập lại: ");
                        check2 = Console.ReadLine().ToUpper();
                    }
                    if (check2 == "Y")
                    {
                        hhBUS.Xoa(maHH);
                        Console.Write("\t\tĐã xóa thành công!!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\t\tĐã hủy xóa!!!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (maHH == "") return;
                    Console.WriteLine("\t\tMã hàng hóa {0} không tồn tại!",maHH); Console.ReadKey();
                }
            }
        }

        private void TimKiem()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tìm kiếm hoặc nhấn 'Enter' để thoát.");
                Console.Write("Nhập mã hàng hóa hoặc tên muốn tìm: ");
                string name = Console.ReadLine().ToUpper();
                if (name != "" && hhBUS.TimKiem(name) != "")
                {
                    Console.Clear();

                    string[] tmp = hhBUS.TimKiem(name).Split('\n');
                    int count = tmp.Length - 1;
                    int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                    int end;
                    do
                    {
                        start = (curpage - 1) * 6;
                        end = curpage * 6 < count ? curpage * 6 : count;
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
                        Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
                        Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
                        Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
                        for (int i = start; i < end; i++)
                        {
                            string[] tmp2 = tmp[i].Split('#');
                            Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9}        ║", tmp2[0], tmp2[1], Convert.ToDouble(tmp2[2]).ToString("N0"));

                        }
                        Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");

                        Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để tiếp tục, ESC để thoát...");

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
                        else if (key.Key == ConsoleKey.Escape)
                            return;
                    } while (true);
                }
                else
                {
                    if (name == "") return;
                    Console.Write("Không tìm thấy kết quả nào!");
                    Console.ReadKey();
                }
            }
        }
    }

    // Quản lý nhân viên
    public class QLNhanVien
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        public List<string> listPosition =
            new List<string> { "Giam doc",
                                "Quan ly",
                                "Giam sat",
                                "Le tan",
                                "Phuc vu",
                                "Dau bep"};

        public void MenuNV(string maNV)
        {
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                       TÀI KHOẢN NHÂN VIÊN                         ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║     DANH SÁCH NHÂN VIÊN      ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║       THÊM NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 5.║        XÓA NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 6.║      DANH SÁCH TÀI KHOẢN     ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 7.║    TẠO TÀI KHOẢN NHÂN VIÊN   ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(80, 38);

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
                        break;
                    case '4':
                        Sua(maNV);
                        break;
                    case '5':
                        Xoa();
                        break;
                    case '7':
                        TaoTK();
                        break;
                    case '6':
                        ShowAcc();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuNV(maNV);
                        break;
                }
            }
        }

        private void Show()
        {
            List<string> list = new List<string>();
            for(int i = 0; i< nvBUS.Laydanhsach().Count; i++)
            {
                string[] t = nvBUS.Laydanhsach()[i].Split('\t');
                if (t[1] != "empty")
                    list.Add(nvBUS.Laydanhsach()[i]);
            }

            int count = list.Count;
            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("  ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("  ║                                                                     DANH SÁCH {0,-4} NHÂN VIÊN                                                                     ║", nvBUS.Count());
                Console.WriteLine("  ╠═════════╦═════════════════════════════╦════════════╦═══════════╦═══════════════════╦═════════════════╦══════════════╦═════════════════════════════╦══════════════╣");
                Console.WriteLine("  ║    Mã   ║            Họ tên           ║ Ngày sinh  ║ Giới tính ║      Địa chỉ      ║  Số điện thoại  ║     CCCD     ║            Email            ║   Chức vụ    ║");
                Console.WriteLine("  ╠═════════╬═════════════════════════════╬════════════╬═══════════╬═══════════════════╬═════════════════╬══════════════╬═════════════════════════════╬══════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = list[x].Split('\t');
                    Console.WriteLine("  ║  {0,-7}║ {1,-27} ║ {2,-10} ║    {3,-3}    ║  {4,-17}║   {5,-10}    ║ {6,-12} ║  {7,-27}║ {8,-12} ║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]);
                }
                Console.WriteLine("  ╚═════════╩═════════════════════════════╩════════════╩═══════════╩═══════════════════╩═════════════════╩══════════════╩═════════════════════════════╩══════════════╝");
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

        }

        public void ShowAcc()
        {
            int count = nvBUS.LaydanhsachAcc().Count;
            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                             DANH SÁCH {0,-4} TÀI KHOẢN KHÁCH HÀNG                                 ║", nvBUS.CountAcc());
                Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═════════════════════════════╦════════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║            Tài khoản           ║            Mật khẩu         ║         Ghi chú        ║");
                Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═════════════════════════════╬════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = nvBUS.LaydanhsachAcc()[x].Split('\t');
                    string Note = "";
                    foreach(string i in nvBUS.Laydanhsach())
                    {
                        string[] checkAcc = i.Split('\t');
                        if(checkAcc[0] == tmp[2])
                            if(checkAcc[1] == "empty" && checkAcc[4] == "empty")
                            {
                                Note = "Chưa nhập thông tin";
                                break;
                            }
                    }
                    Console.WriteLine("\t\t║  {0,-7}║\t{1,-20}       ║\t{2,-10}               ║ {3,-20}   ║", tmp[2], tmp[0], tmp[1],Note);

                }

                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═════════════════════════════╩════════════════════════╝");

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

        private void TimKiem()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Nhập mã hoặc tên nhân viên (Nhấn Enter để thoát): ");
                string name = Console.ReadLine();
                if (name != "" && nvBUS.TimKiem(name) != "")
                {
                    string[] tmp = nvBUS.TimKiem(name).Split('\n');

                    List<string> list = new List<string>();
                    for (int i = 0; i < tmp.Length-1; i++)
                    {
                        string[] t = tmp[i].Split('#');
                        if (t[1] != "empty")
                            list.Add(tmp[i]);
                    }

                    int count = list.Count;
                    int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                    int end;
                    do
                    {
                        start = (curpage - 1) * 6;
                        end = curpage * 6 < count ? curpage * 6 : count;
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("  ║                                                                  TÌM THẤY {0,-2} KẾT QUẢ                                                                             ║", count);
                        Console.WriteLine("  ╠═════════╦═════════════════════════════╦════════════╦═══════════╦═══════════════════╦═════════════════╦══════════════╦═════════════════════════════╦══════════════╣");
                        Console.WriteLine("  ║    Mã   ║            Họ tên           ║ Ngày sinh  ║ Giới tính ║      Địa chỉ      ║  Số điện thoại  ║     CCCD     ║            Email            ║   Chức vụ    ║");
                        Console.WriteLine("  ╠═════════╬═════════════════════════════╬════════════╬═══════════╬═══════════════════╬═════════════════╬══════════════╬═════════════════════════════╬══════════════╣");
                        for (int i = start; i < end; i++)
                        {
                            string[] tmp2 = list[i].Split('#');
                            Console.WriteLine("  ║  {0,-7}║ {1,-27} ║ {2,-10} ║    {3,-3}    ║  {4,-17}║   {5,-10}    ║ {6,-12} ║  {7,-27}║ {8,-12} ║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], tmp2[4], tmp2[5], tmp2[6], tmp2[7], tmp2[8]);
                        }
                        Console.WriteLine("  ╚═════════╩═════════════════════════════╩════════════╩═══════════╩═══════════════════╩═════════════════╩══════════════╩═════════════════════════════╩══════════════╝");

                        Console.Write("\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để tiếp tục, ESC để thoát...");

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
                        else if (key.Key == ConsoleKey.Escape)
                            return;
                    } while (true);
                }
                else
                {
                    if (name == "") return;
                    Console.Write("Không tìm thấy kết quả nào!");
                    Console.ReadKey();
                }

            }
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
                string pos = chosePosition();
                nvBUS.ThemNV(tmp[2], "empty", DateTime.Now, true, "empty", "empty", "empty", "empty", pos);
                NhanVienPre nvP = new NhanVienPre();
                nvP.ThemThongTin(tmp[2]);
                Console.Clear();
                Console.Write("Thêm nhân viên thành công!");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Bạn có muốn tiếp tục thêm nhân viên không? (Enter để tiếp tục): ");
                key = Console.ReadKey();
            }
        }

        private string chosePosition()
        {
            Console.Clear();
            do
            {
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║           CHỌN CHỨC VỤ              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  {0, -20}               ║                 ", listPosition[0]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  {0, -20}               ║                 ", listPosition[1]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 3.║  {0, -20}               ║                 ", listPosition[2]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 4.║  {0, -20}               ║                 ", listPosition[3]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 5.║  {0, -20}               ║                 ", listPosition[4]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 6.║  {0, -20}               ║                 ", listPosition[5]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 24);

                string result;
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':
                        result = listPosition[0];
                        return result;
                    case '2':
                        result = listPosition[1];
                        return result;
                    case '3':
                        result = listPosition[2];
                        return result;
                    case '4':
                        result = listPosition[3];
                        return result;
                    case '5':
                        result = listPosition[4];
                        return result;
                    case '6':
                        result = listPosition[5];
                        return result;

                }
            } while (true);
        }

        private void Sua(string ID)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Nhập mã nhân viên muốn sửa (Hoặc nhấn Enter để thoát!): ");
                string maNV = Console.ReadLine().ToUpper();
                if (maNV != "" && nvBUS.Laythongtin(maNV) != "")
                {
                    while (true)
                    {
                        string[] tmp = nvBUS.Laythongtin(maNV).Split('#');
                        string[] tmp2 = nvBUS.Laythongtin(ID).Split('#');

                        // Nếu người sửa không phải là giám đốc mà muốn sửa giám đốc thì thoát chương trình
                        if(tmp[8] == listPosition[0] && tmp2[8] != listPosition[0])
                        {
                            Console.Write("\nBạn không thể sửa thông tin người này!!!");
                            Console.ReadKey();
                            return;
                        }
                        Console.Clear();
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                        Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║   ║    Tên : {0,-27}║     ", tmp[1]);
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
                                MenuNV(ID);
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
                {
                    if (maNV == "") return;
                    Console.Write("Khách hàng không tồn tại!");
                    Console.ReadKey();
                }
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
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
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
            while (true)
            {
                Show();
                //Console.Clear();
                Console.WriteLine("\n\tXóa nhân viên hoặc nhấn 'Enter' để thoát.");
                Console.Write("\tNhập mã nhân viên muốn xóa: ");
                string maNV = Console.ReadLine().ToUpper();
                if (maNV != "" && nvBUS.Laythongtin(maNV) != "")
                {
                    Console.Write("\tXác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("\tKhông hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        nvBUS.Xoa(maNV);
                        Console.Write("\tĐã xóa thành công!!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\tĐã hủy xóa!!!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (maNV == "") return;
                    Console.Write("\tNhân viên {0} không tồn tại!", maNV);
                }

            }
        }

        private void TaoTK()
        {
            Console.Clear();
            string[] tmp = nvBUS.ThemTK().Split('#');
            Console.WriteLine("Tài khoản: {0}\nMật khẩu: {1}\nMã nhân viên: {2}", tmp[0], tmp[1], tmp[2]);
            Console.Write("Tạo tài khoản thành công");
            Console.ReadKey();
            Console.Clear();
            string pos = chosePosition();
            nvBUS.ThemNV(tmp[2], "empty", DateTime.Now, true, "empty", "empty", "empty", "empty", pos);
        }
    }

    // Quản lý khách hàng
    class QLKhachHang
    {
        private KhachHangBUS khBUS = new KhachHangBUS();

        public void MenuKH(string maNV)
        {
            while (true)
            {
                Console.Clear();

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                       TÀI KHOẢN KHÁCH HÀNG                        ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║     HIỂN THỊ KHÁCH HÀNG      ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║       THÊM KHÁCH HÀNG        ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║          TÌM KIẾM            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 5.║        XÓA KHÁCH HÀNG        ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 6.║     HIỂN THỊ TÀI KHOẢN       ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 9.║          QUAY LẠI            ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 0.║           THOÁT              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(80, 35);

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
                        break;
                    case '4':
                        Sua(maNV);
                        break;
                    case '5':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '6':
                        ShowAcc();
                        break;
                    case '9':
                        QuanLyPre ql = new QuanLyPre();
                        ql.MenuQuanLy(maNV);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        MenuKH(maNV);
                        break;
                }
            }
        }

        private void Show()
        {
            int count = khBUS.Laydanhsach().Count;
            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("  ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("  ║                                                                     DANH SÁCH {0,-4} KHÁCH HÀNG                                                          ║", khBUS.Count());
                Console.WriteLine("  ╠═════════╦════════════════════════════════╦══════════════╦═══════════╦═══════════════════╦═════════════════╦══════════════╦═════════════════════════════╣");
                Console.WriteLine("  ║    Mã   ║             Họ tên             ║   Ngày sinh  ║ Giới tính ║      Địa chỉ      ║  Số điện thoại  ║     CCCD     ║            Email            ║");
                Console.WriteLine("  ╠═════════╬════════════════════════════════╬══════════════╬═══════════╬═══════════════════╬═════════════════╬══════════════╬═════════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = khBUS.Laydanhsach()[x].Split('\t');
                    Console.WriteLine("  ║  {0,-7}║\t{1,-27}  ║  {2,-10}  ║    {3,-3}    ║  {4,-17}║   {5,-10}    ║ {6,-12} ║  {7,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]);
                }
                Console.WriteLine("  ╚═════════╩════════════════════════════════╩══════════════╩═══════════╩═══════════════════╩═════════════════╩══════════════╩═════════════════════════════╝");
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
        }

        public void ShowAcc()
        {
            int count = khBUS.LaydanhsachAcc().Count;
            int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
            int end;
            do
            {
                Console.Clear();
                start = (curpage - 1) * 6;
                end = curpage * 6 < count ? curpage * 6 : count;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                            DANH SÁCH {0,-4} TÀI KHOẢN KHÁCH HÀNG                                  ║", khBUS.CountAcc());
                Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═════════════════════════════╦════════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║            Tài khoản           ║            Mật khẩu         ║         Ghi chú        ║");
                Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═════════════════════════════╬════════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp = khBUS.LaydanhsachAcc()[x].Split('\t');
                    string Note = "Chưa nhập thông tin";
                    foreach(string i in khBUS.Laydanhsach())
                    {
                        string[] checkAcc = i.Split('\t');
                        if(tmp[2] == checkAcc[0])
                        {
                            Note = "";
                            break;
                        }
                    }
                    Console.WriteLine("\t\t║  {0,-7}║\t{1,-20}       ║\t{2,-10}               ║ {3,-20}   ║", tmp[2], tmp[0], tmp[1], Note);
                }

                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═════════════════════════════╩════════════════════════╝");

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
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
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
            while (true)
            {
                Console.Clear();
                Console.Write("Nhập mã hoặc tên khách hàng (Nhấn Enter để thoát): ");
                string name = Console.ReadLine();
                if (name != "" && khBUS.TimKiem(name) != "")
                {
                    string[] tmp = khBUS.TimKiem(name).Split('\n');
                    int count = tmp.Length - 1;
                    int start, curpage = 1, totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                    int end;
                    do
                    {
                        start = (curpage - 1) * 6;
                        end = curpage * 6 < count ? curpage * 6 : count;
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("  ║                                                                  TÌM THẤY {0,-2} KẾT QUẢ                                                                   ║", tmp.Length - 1);
                        Console.WriteLine("  ╠═════════╦════════════════════════════════╦══════════════╦═══════════╦═══════════════════╦═════════════════╦══════════════╦═════════════════════════════╣");
                        Console.WriteLine("  ║    Mã   ║             Họ tên             ║   Ngày sinh  ║ Giới tính ║      Địa chỉ      ║  Số điện thoại  ║     CCCD     ║            Email            ║");
                        Console.WriteLine("  ╠═════════╬════════════════════════════════╬══════════════╬═══════════╬═══════════════════╬═════════════════╬══════════════╬═════════════════════════════╣");
                        for (int i = start; i < end; i++)
                        {
                            string[] tmp2 = tmp[i].Split('#');
                            Console.WriteLine("  ║  {0,-7}║\t{1,-27}  ║  {2,-10}  ║    {3,-3}    ║  {4,-17}║   {5,-10}    ║ {6,-12} ║  {7,-27}║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], tmp2[4], tmp2[5], tmp2[6], tmp2[7]);

                        }
                        Console.WriteLine("  ╚═════════╩════════════════════════════════╩══════════════╩═══════════╩═══════════════════╩═════════════════╩══════════════╩═════════════════════════════╝");

                        Console.Write("\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ENTER để tiếp tục, ESC để thoát...");

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
                        else if (key.Key == ConsoleKey.Escape)
                            return;
                    } while (true);
                }
                else
                {
                    if (name == "") return;
                    Console.Write("Không tìm thấy kết quả nào!");
                    Console.ReadKey();
                }

            }
        }

        private void Sua(string maNV)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Nhập mã khách hàng muốn sửa (Nhấn Enter để thoát!): ");
                string maKH = Console.ReadLine().ToUpper();
                if (maKH != "" && khBUS.Laythongtin(maKH) != "")
                {
                    while (true)
                    {
                        Console.Clear();
                        string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
                        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                        Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                        Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                        Console.Write("\n\t\t             ║   ║                                     ║                 ");
                        Console.Write("\n\t\t             ║   ║    Tên : {0,-27}║     ", tmp[1]);
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
                                MenuKH(maNV);
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
                {
                    if (maKH == "") return;
                    Console.Write("Khách hàng không tồn tại!");
                    Console.ReadKey();
                }
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
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
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
            while (true)
            {
                //Console.Clear();
                Show();
                Console.WriteLine("\n\tXóa khách hàng hoặc nhấn 'Enter' để thoát.");
                Console.Write("\tNhập mã khách hàng muốn xóa: ");
                string maKH = Console.ReadLine().ToUpper();
                if (maKH != "" && khBUS.Laythongtin(maKH) != "")
                {
                    Console.Write("\tXác nhận xóa? (Y/N): ");
                    string check = Console.ReadLine().ToUpper();
                    while (check != "Y" && check != "N")
                    {
                        Console.Write("\tKhông hợp lệ! Nhập lại: ");
                        check = Console.ReadLine().ToUpper();
                    }
                    if (check == "Y")
                    {
                        khBUS.Xoa(maKH);
                        Console.Write("\tĐã xóa thành công!!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\tĐã hủy xóa!!!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (maKH == "") return;
                    Console.WriteLine("\tKhách hàng {0} không tồn tại!", maKH);
                    Console.ReadKey();
                }    

            }
        }

    }
}
