using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.SHOW
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
                Console.Write("\n\t\t║ ║              ║ 1.║     QUẢN LÝ KHÁCH HÀNG       ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║     QUẢN LÝ HÀNG HÓA         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║     QUẢN LÝ HÓA ĐƠN          ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║     QUẢN LÝ NHÂN VIÊN        ║                 ║ ║");
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
                        qlHH.MenuHH();
                        break;
                    case '3':
                        qlHD.MenuHD();
                        break;
                    case '4':
                        qlNV.MenuNV();
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
                Console.Write("\n\t\t║ ║              ║ 3.║           TÌM KIẾM           ║                 ║ ║");
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
                        HienThiChiTiet();
                        break;
                    case '2':
                        Them();
                        break;
                    case '3':
                        TimKiem();
                        Console.ReadKey();
                        break;
                    case '4':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '5':
                        MenuThongKe();
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
                Console.Write("\n\t\t║ ║              ║ 1.║       THỐNG KÊ NGÀY          ║                 ║ ║");
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

        private void HienThi()
        {
            Console.Clear();

            Console.SetWindowSize(140, 30);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                              Hóa đơn                           ║");
            Console.WriteLine("\t\t╠═════════╦══════════════════════════════════╦═══════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║         Tên khách hàng           ║        Ngày       ║");
            Console.WriteLine("\t\t╠═════════╬══════════════════════════════════╬═══════════════════╣");
            for (int x = 0; x < hdBUS.LayDanhSach().Count; x++)
            {
                string[] tmp = hdBUS.LayDanhSach()[x].Split('\t');
                Console.WriteLine("\t\t║ {0,-7} ║\t{1,-27}  ║  {2,-10}       ║", tmp[0], tmp[1], tmp[2]);
            }
            Console.WriteLine("\t\t╚═════════╩══════════════════════════════════╩═══════════════════╝");

        }

        private void HienThiChiTiet()
        {
            Console.Clear();

            HienThi();
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
                            int total = 0;

                            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
                            Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
                            Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
                            Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
                            for (int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                            {
                                string[] tmp = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║  {2,-9}VND     ║     {3,-5}   ║   {4,-12}VND  ║", tmp[0], tmp[1], tmp[2], tmp[3], int.Parse(tmp[2]) * int.Parse(tmp[3]));
                                total += int.Parse(tmp[2]) * int.Parse(tmp[3]);
                            }
                            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");

                            Console.WriteLine();
                            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}VND                                 ║", total.ToString("N2"));
                            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

                            Console.Write("\t\tXem tiếp nhấn 'Enter' hoặc nhấn bất kỳ phím khác để thoát : ");
                            string check = Console.ReadLine();
                            if (check == "")
                            {
                                Console.Clear();
                                HienThi();
                                Console.Write("\t\tNhập mã hóa đơn (Nhấp 'Enter' để bỏ qua): ");
                                maHD = Console.ReadLine().ToUpper();
                                if (maHD == "")
                                {
                                    Console.Write("\t\tĐã thoát!");
                                    c = true;
                                }
                            }
                            else
                                c = true;
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
            Console.WriteLine("Thêm hóa đơn hoặc nhấn 'Enter' để thoát.");
            Console.Write("Mã khách hàng: ");
            string maKH = Console.ReadLine().ToUpper();
            if (maKH != "")
            {
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
                                int c1 = 0;
                                hdBUS.Them(tmp[1], date, maKH);
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
                    }
                }
                else
                    Console.WriteLine("\t\tKhách hàng không tồn tại!");
            }
            else
                Console.WriteLine("\t\tĐã thoát.");
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
                                    Console.WriteLine("\t\t║  {0,-7}║  {1,-30}║  {2,-9}VND     ║     {3,-5}   ║   {4,-12}VND  ║", tmp2[0], tmp2[1], tmp2[2], tmp2[3], int.Parse(tmp2[2]) * int.Parse(tmp2[3]));
                                    total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
                                }
                                Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");

                                Console.WriteLine();
                                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-12}VND                                 ║", total.ToString("N2"));
                                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                                Console.Write("\t\tNhấn phím bất kì để kết thúc!");
                                c = true;
                            }
                            else
                            {
                                Console.Write("\t\tMã hóa đơn không tồn tại! Mời nhập lại (Nhấp 'Enter' để bỏ qua): ");
                                maHD = Console.ReadLine().ToUpper();
                                if (maHD == "")
                                {
                                    c = true;
                                    Console.WriteLine("\t\tĐã thoát!");
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.Write("\t\tĐã thoát.");
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
                        Console.Write("\t\tNhấn phím bất kì để kết thúc!");
                        Console.ReadKey();
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
            Console.Clear();

            Console.SetWindowSize(140, 30);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                              THỰC ĐƠN                                    ║");
            Console.WriteLine("\t\t╠═════════╦════════════════════════════════════════════╦═══════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║                    Tên Món                 ║        Giá        ║");
            Console.WriteLine("\t\t╠═════════╬════════════════════════════════════════════╬═══════════════════╣");
            for (int x = 0; x < hhBUS.Laydanhsach().Count; x++)
            {
                string[] tmp = hhBUS.Laydanhsach()[x].Split('\t');
                Console.WriteLine("\t\t║ {0,-7} ║\t{1,-30}         ║  {2,-9} VND    ║", tmp[0], tmp[1], tmp[2]);
            }
            Console.WriteLine("\t\t╚═════════╩════════════════════════════════════════════╩═══════════════════╝");

        }

        private void Them()
        {
            Console.Clear();
            Console.WriteLine("Thêm thông tin hoặc nhấn 'Enter' để thoát.");
            Console.Write("Nhập tên hàng hóa: ");
            string tenHH = Console.ReadLine();
            if (tenHH != "")
            {
                while (tenHH.Length > 30)
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
                hhBUS.Them(tenHH, price);
                Console.WriteLine("Đã thêm thành công!");
            }
            else
                Console.WriteLine("Đã thoát.");
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

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Tên mới: ");
                        tenHH = Console.ReadLine();
                        while (tenHH == "" || tenHH.Length > 30)
                        {
                            Console.Write("Nhập lại (dưới 30 ký tự): ");
                            tenHH = Console.ReadLine();
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

                hhBUS.Sua(maHH, tenHH, Gia);
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
                Console.Write("\n\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH NHÂN VIÊN ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║       THÊM NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║        XÓA NHÂN VIÊN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║    TẠO TÀI KHOẢN NHÂN VIÊN   ║                 ║ ║");
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
                        Console.ReadKey();
                        break;
                    case '2':
                        Them();
                        Console.ReadKey();
                        break;
                    case '3':
                        Sua();
                        Console.ReadKey();
                        break;
                    case '4':
                        Xoa();
                        Console.ReadKey();
                        break;
                    case '5':
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
            Console.Clear();

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                                DANH SÁCH NHÂN VIÊN                                                                ║");
            Console.WriteLine("\t╠═════════╦════════════════════════════════╦═════════════════════╦═══════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
            Console.WriteLine("\t║    Mã   ║             Họ tên             ║       Ngày sinh     ║ Giới tính ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
            Console.WriteLine("\t╠═════════╬════════════════════════════════╬═════════════════════╬═══════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
            for (int x = 0; x < nvBUS.Laydanhsach().Count; x++)
            {
                string[] tmp = nvBUS.Laydanhsach()[x].Split('\t');
                Console.WriteLine("\t║  {0,-7}║\t{1,-27}║  {2,-10}         ║     {3,-3}   ║  {4,-17}║   {5,-10}       ║  {6,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6]);
            }

            Console.WriteLine("\t╚═════════╩════════════════════════════════╩═════════════════════╩═══════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
            Console.Write("\tNhấn phím bất kì để kết thúc!");

        }

        private void Them()
        {
            Console.Clear();
            Console.WriteLine("Nhấn 'Enter' để thoát hoặc nhấn phím khác để tiếp tục thêm nhân viên!");
            string check = Console.ReadLine();
            if (check != "")
            {
                string[] tmp = nvBUS.ThemTK().Split('#');
                Console.WriteLine("Tài khoản: {0}\nMật khẩu: {1}\nMã nhân viên: {2}", tmp[0], tmp[1], tmp[2]);
                Console.WriteLine("Tạo tài khoản thành công");

                Console.Write("Họ tên: ");
                string tenNV = Console.ReadLine();
                while (tenNV == "" || tenNV.Length > 27)
                {
                    Console.Write("Nhập lại (dưới 27 ký tự): ");
                    tenNV = Console.ReadLine();
                }
                Console.Write("Sinh nhật (dd/MM/yyyy): ");
                string tmp2 = Console.ReadLine();
                DateTime date = new DateTime();
                bool check2 = false;
                while (!check2)
                {

                    try
                    {
                        date = DateTime.Parse(tmp2);
                    }
                    catch
                    {
                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                        tmp2 = Console.ReadLine();
                    }
                    if (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > 2002)
                    {
                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
                        tmp2 = Console.ReadLine();
                    }
                    else
                        check2 = true;
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
                            Console.Write("Nhập lại (...@gmail.com): ");
                            e = Console.ReadLine();
                        }
                    }
                    email = e + "@gmail.com";
                    c = true;
                }
                nvBUS.ThemNV(tmp[2], tenNV, date, GT, dchi, SDT, email);
                Console.WriteLine("Thêm nhân viên thành công!");
            }
            else
                Console.WriteLine("Đã thoát!");
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
        KhachHangBUS khBUS = new KhachHangBUS();

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
                Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║        XÓA KHÁCH HÀNG        ║                 ║ ║");
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
                        Show();
                        Console.ReadKey();
                        break;
                    case '2':
                        Them();
                        Console.ReadKey();
                        break;
                    case '3':
                        Sua();
                        Console.ReadKey();
                        break;
                    case '4':
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
            Console.Clear();

            Console.SetWindowSize(140, 30);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                       DANH SÁCH KHÁCH HÀNG                                                      ║");
            Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
            Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
            for (int x = 0; x < khBUS.Laydanhsach().Count; x++)
            {
                string[] tmp = khBUS.Laydanhsach()[x].Split('\t');
                Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);

            }

            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
        }

        private void Them()
        {
            Console.Clear();
            Console.WriteLine("Thêm khách hàng hoặc nhấn 'Enter' để thoát.");
            Console.Write("Tài khoản: ");
            string TK = Console.ReadLine();
            if (TK != "")
            {
                Console.Write("Mật khẩu: ");
                string MK1 = Console.ReadLine();
                Console.Write("Nhập lại mật khẩu: ");
                string MK2 = Console.ReadLine();


                if (MK1 == MK2)
                {
                    if (khBUS.CheckTK(TK) == true)
                        Console.WriteLine("Tài khoản đã tồn tại!");
                    else
                    {
                        khBUS.ThemTK(TK, MK1);
                        Console.WriteLine("Tạo tài khoản thành công");
                        // Lấy mã
                        string[] tmp = khBUS.LaythongtinTK(TK).Split('\t');
                        string maKH = tmp[2];

                        Console.Write("Họ tên: ");
                        string tenKH = Console.ReadLine();
                        while (tenKH == "" || tenKH.Length > 27)
                        {
                            Console.Write("Nhập lại (dưới 27 ký tự): ");
                            tenKH = Console.ReadLine();
                        }
                        Console.Write("Địa chỉ: ");
                        string dchi = Console.ReadLine();
                        while (dchi == "" || dchi.Length > 17)
                        {
                            Console.Write("Nhập lại (dưới 17 ký tự): ");
                            dchi = Console.ReadLine();
                        }
                        Console.Write("Số điện thoại: ");
                        string SDT = Console.ReadLine();
                        while (true)
                        {

                            for (int x = 0; x < SDT.Length; x++)
                            {
                                if (!char.IsDigit(SDT[x])
                                    || SDT.Length != 10
                                    || SDT[0] != '0'
                                    || khBUS.checkSDT(SDT) == 1)
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

                        Console.Write("Email (Nếu có, ...@gmail.com): ");
                        string e = Console.ReadLine(), email = "<Trống>";
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
                                        Console.Write("Mời bạn nhập lại (...@gmail.com): ");
                                        e = Console.ReadLine();
                                    }
                                }
                                email = e + "@gmail.com";
                                c = true;
                            }
                        khBUS.Them(maKH, tenKH, dchi, SDT, email);
                    }
                }
            }
            else
                Console.WriteLine("Đã thoát!");
        }

        private void Sua()
        {
            Console.Clear();
            Console.Write("Nhập mã khách hàng muốn sửa (Hoặc nhấn Enter để thoát!): ");
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
