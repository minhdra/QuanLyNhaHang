using QuanLyNhaHang.BUS;
using System;
using QuanLyNhaHang.Constraint;

namespace QuanLyNhaHang.Presentation
{
    // 1 Khách hàng
    class KhachHangPre
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private HoaDonBUS hdBUS = new HoaDonBUS();
        private constraint conP = new constraint();

        public void HienMenuKH(string maKH)
        {
            
            while (true)
            {
                // Kiểm tra khách có tồn tại
                int check = 0;
                if (khBUS.Laythongtin(maKH) != "")
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
                Console.Write("\n\t\t║ ║                         XIN CHÀO QUÝ KHÁCH                        ║ ║");
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
                Console.Write("\n\t\t║ ║              ║ 4.║           ĐẶT HÀNG           ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║       LỊCH SỬ GIAO DỊCH      ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 6.║         ĐỔI MẬT KHẨU         ║                 ║ ║");
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
                        if (check == 0)
                            ThemThongTin(maKH);
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN ĐÃ THÊM THÔNG TIN RỒI                     ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
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
                            SuaThongTin(maKH);
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
                            XemThongTin(maKH);
                        Console.ReadKey();
                        break;
                    case '4':
                        if (check == 0)
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN CHƯA THÊM THÔNG TIN                       ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                            Order(maKH);
                        break;
                    case '5':
                        if (check == 0)
                        {
                            Console.Clear();
                            Console.Write("\n\t╔═══════════════════════════════════════════════════════════════════════╗");
                            Console.Write("\n\t║                         BẠN CHƯA THÊM THÔNG TIN                       ║");
                            Console.Write("\n\t╚═══════════════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                        {
                            LichSu(maKH);
                        }
                        break;
                    case '6':
                        DoiMatKhau(maKH);
                        Console.ReadKey();
                        break;
                    case '9':
                        TaiKhoanPre.KhachHang tkkh = new TaiKhoanPre.KhachHang();
                        tkkh.HienMenuKhach();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        HienMenuKH(maKH);
                        break;
                }
            }
        }

        public void ThemThongTin(string maKH)
        {
            Console.Clear();


            Console.Write("\n\t\t╔═══════════════════════════════════════════════════════╗");
            Console.Write("\n\t\t║                  THÊM THÔNG TIN                       ║");
            Console.Write("\n\t\t╠═══════════════════════════════════════════════════════╣");
            Console.Write("\n\t\t║                                                       ║");
            Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════╗ ║");
            Console.Write("\n\t\t║ ║  NHẤN ENTER ĐỂ THOÁT!                             ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Họ Tên         :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Địa chỉ        :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Số điện thoại  :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Email (Nếu có) :                      @gmail.com ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════╝ ║");
            Console.Write("\n\t\t║                                                       ║");
            Console.Write("\n\t\t╚═══════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(38, 8);
            string tenKH = Console.ReadLine();
            if (tenKH == "") return;
            tenKH = conP.CheckStr2(tenKH, 27, 38, 8, 38, 18);

            Console.SetCursorPosition(38, 10);
            string dchi = Console.ReadLine();
            dchi = conP.CheckStr2(dchi, 17, 38, 10, 38, 18);

            Console.SetCursorPosition(38, 12);
            string SDT = Console.ReadLine();
            SDT = conP.NumberPhone2(SDT, 38, 12, 38, 18);

            Console.SetCursorPosition(38, 14);
            string e = Console.ReadLine(), email = "<Trống>";
            if (e != "")
                email = conP.Email2(e, 38, 14, 38, 18);


            khBUS.Them(maKH, conP.Capitalize(tenKH), conP.Capitalize(dchi), SDT, email);

            Console.SetCursorPosition(29, 18);
            Console.Write("Bạn đã thêm thông tin thành công!!!");
            Console.ReadKey();
        }

        public void SuaThongTin(string maKH)
        {
            bool check = false;
            while (!check)
            {
                Console.Clear();

                string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
                string tenKH = tmp[1], dchi = tmp[2], SDT = tmp[3], email = tmp[4];
                Console.SetWindowSize(103, 35);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA THÔNG TIN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Họ Tên: {0,-27}║", tenKH);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Địa chỉ: {0,-17}         ║                 ", dchi);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 3.║  SDT: {0,-10}                    ║                 ", SDT);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 4.║  Email: {0,-27} ║                 ", email);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 24);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                string t;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Họ tên mới (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            tenKH = conP.CheckStr(t, 27);

                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Địa chỉ (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            dchi = conP.CheckStr(t, 17);
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("Số điện thoại (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            SDT = conP.NumberPhone(t);

                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Email (...@gmail.com hoặc Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            email = conP.Email(t);
                        break;
                    case '9':
                        check = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }

                khBUS.Sua(maKH, conP.Capitalize(tenKH), conP.Capitalize(dchi), SDT, email);
                // Cập nhật tên khách hàng vào hóa đơn
                string[] tmp2 = hdBUS.LayThongTin(maKH).Split('\n');
                for(int x = 0; x < tmp2.Length - 1; x++)
                {
                    string[] tmp3 = tmp2[x].Split('\t');
                    hdBUS.Sua(tmp3[0], conP.Capitalize(tenKH), DateTime.Parse(tmp3[2]), tmp3[3], double.Parse(tmp3[4]));
                }
            }
        }

        private void XemThongTin(string maKH)
        {
            Console.Clear();
            string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
            Console.SetWindowSize(140, 30);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                       THÔNG TIN CỦA BẠN,   {0, -27}                          ║", tmp[1]);
            Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
            Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
            Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);
            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
        }

        private void Order(string maKH)
        {
            Console.Clear();
            QLHangHoa qlHH = new QLHangHoa();
            qlHH.Show();
            Console.WriteLine();
            Console.WriteLine("\t\tĐặt món hoặc nhấn 'Enter' để thoát.");
            Console.Write("\t\tMời bạn chọn ID muốn đặt: ");
            string ID = Console.ReadLine().ToUpper();
            if (ID != "")
            {
                if (khBUS.Laythongtin(maKH) != "")
                {
                    string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
                    DateTime date = DateTime.Now;
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
                            int c1 = 0;
                            hdBUS.Them(tmp[1], date, maKH, total);
                            string maHD = hdBUS.LayMaHD(maKH, date);
                            // Cập nhật số lượng 
                            for(int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                            {
                                string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                if(tmp2[0] == ID)
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
                            ConsoleKeyInfo key = Console.ReadKey();
                            if (key.Key == ConsoleKey.Enter)
                                Order(maKH);

                            c = true;
                        }
                        else
                        {
                            Console.Write("\t\tMã hàng hóa không tồn tại! Mời nhập lại (Nhấp 'Enter' để thoát!): ");
                            ID = Console.ReadLine().ToUpper();
                            if (ID == "")
                                c = true;
                        }
                    }
                    // Cập nhật lại hóa đơn
                    string[] tmp3 = hdBUS.LayThongTin(maKH).Split('\n');
                    for(int x = 0; x < tmp3.Length - 1; x++)
                    {
                        string[] tmp4 = tmp3[x].Split('\t');
                        if(tmp4[3] == maKH && tmp4[2] == DateTime.Now.ToString("dd/MM/yyyy"))
                        {
                            total = hdBUS.TongTien(maKH, tmp4[2]);
                            hdBUS.Sua(tmp4[0], conP.Capitalize(tmp4[1]), DateTime.Parse(tmp4[2]), tmp4[3], total);
                        }
                    }
                }
            }
            else
                Console.Write("\t\tĐã thoát!");
        }

        private void DoiMatKhau(string maKH)
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
            if(MK1 != "")
            {
                Console.SetCursorPosition(34, 9);
                string MK2 = Console.ReadLine();
                if (MK2 != MK1)
                {
                    Console.Write("\n\tMật khẩu không giống nhau!");
                    return;
                }
                khBUS.DoiMK(maKH, MK1);
                Console.WriteLine("\n\tBạn đổi mật khẩu thành công!");
            }
            else
                Console.Write("\n\n\n\n\tĐã thoát!");
        }

        private void LichSu(string maKH)
        {
            Console.Clear();
            //Lấy thông tin của hóa đơn 
            string[] tmp = hdBUS.LayThongTin(maKH).Split('\n');
            string[] name = tmp[0].Split('\t');
            if(name[0] == "")
            {
                Console.Write("\n\tBạn chưa có hóa đơn!");
                Console.ReadKey();
                return;
            }

            double sum = 0;
            
            int count = tmp.Length - 1;
            // Tổng tất cả hóa đơn
            for (int x = 0; x < count; x++)
            {
                string[] tmp2 = tmp[x].Split('\t');
                sum += double.Parse(tmp2[4]);
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
                Console.WriteLine("\t\t║                                         Hóa đơn của {0,-27}               ║", name[1]);
                Console.WriteLine("\t\t╠═════════╦══════════╦══════════════════════════════════╦═══════════════════╦═════════════════════╣");
                Console.WriteLine("\t\t║    Mã   ║ Mã khách ║         Tên khách hàng           ║        Ngày       ║     Thành tiền      ║");
                Console.WriteLine("\t\t╠═════════╬══════════╬══════════════════════════════════╬═══════════════════╬═════════════════════╣");
                for (int x = start; x < end; x++)
                {
                    string[] tmp2 = tmp[x].Split('\t');
                    Console.WriteLine("\t\t║ {0,-7} ║ {1,-7}  ║\t{2,-27}     ║  {3,-10}       ║ {4,-15}     ║", tmp2[0], tmp2[3], tmp2[1], tmp2[2], double.Parse(tmp2[4]).ToString("N0"));
                }
                Console.WriteLine("\t\t╚═════════╩══════════╩══════════════════════════════════╩═══════════════════╩═════════════════════╝");

                //Console.WriteLine("\n");
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
                else if (key.Key == ConsoleKey.Enter)
                    break;

            } while (true);
            
            Console.WriteLine("\n");
            Console.Write("\t\tNhập mã hóa đơn để xem chi tiết (Nhấp 'Enter' để thoát): ");
            string maHD = Console.ReadLine().ToUpper();
            if(maHD != "")
            {
                bool c = false;
                while (!c)
                {
                    if(hdBUS.HienChiTiet(maHD).Count != 0)
                    {
                        Console.Clear();
                        int total = 0;

                        count = hdBUS.HienChiTiet(maHD).Count;
                        // Tổng tiền của 1 hóa đơn
                        for (int x = 0; x < count; x++)
                        {
                            string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                            total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
                        }

                        start = 0; curpage = 1; totalpage = count % 6 == 0 ? count / 6 : count / 6 + 1;
                        end = count <= 6 ? count : 6;
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
                                string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                                Console.WriteLine("\t\t║ {0,-7} ║ {1,-30} ║ {2,-9}         ║     {3,-5}   ║ {4,-12}       ║", tmp2[0], tmp2[1], int.Parse(tmp2[2]).ToString("N0"), tmp2[3], (int.Parse(tmp2[2]) * int.Parse(tmp2[3])).ToString("N0"));
                                
                            }
                            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-24}                        ║", total.ToString("N0"));
                            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

                            Console.Write("\t\tTrang " + curpage + "/" + totalpage + "          Ấn <-, -> để xem tiếp, ESC để thoát, nhấn ENTER để quay lại...");
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
                                LichSu(maKH);
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
            }
            else
                Console.Write("\t\tĐã thoát!");
        }
    }
}