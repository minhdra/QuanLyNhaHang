using QuanLyNhaHang.BUS;
using System;

namespace QuanLyNhaHang.SHOW
{
    // 1 Khách hàng
    class KhachHangPre
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private HoaDonBUS hdBUS = new HoaDonBUS();

        public virtual void HienMenuKH(string maKH)
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
                            datMon(maKH);
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

        private void ThemThongTin(string maKH)
        {
            Console.Clear();
            Console.WriteLine("Thêm thông tin hoặc nhấn 'Enter' để thoát!");
            Console.Write("Họ tên: ");
            string tenKH = Console.ReadLine();
            if(tenKH != "")
            {
                while(tenKH.Length > 27)
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
                // SDT có 10 ký tự và bắt đầu bằng số 0
                Console.Write("Số điện thoại (10 số): ");
                string SDT = Console.ReadLine();
                while(true)
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
                            if ((e[x] >=0 && e[x] < 48)
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
                khBUS.Them(maKH, tenKH, dchi, SDT, email);

                Console.WriteLine("Bạn đã thêm thông tin thành công!");
            }
            else
                Console.WriteLine("Đã thoát!");
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

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Họ tên mới: ");
                        tenKH = Console.ReadLine();
                        while (tenKH == "" || tenKH.Length > 27)
                        {
                            Console.Write("Nhập lại (dưới 27 ký tự): ");
                            tenKH = Console.ReadLine();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Địa chỉ: ");
                        dchi = Console.ReadLine();
                        while (dchi == "" || dchi.Length > 17)
                        {
                            Console.Write("Nhập lại (dưới 17 ký tự): ");
                            dchi = Console.ReadLine();
                        }
                        break;
                    case '3':
                        Console.Write("Số điện thoại: ");
                        SDT = Console.ReadLine();
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
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Email (Nếu có, ...@gmail.com): ");
                        string e = Console.ReadLine();
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
                                        Console.Write("Nhập lại (...@gmail.com): ");
                                        e = Console.ReadLine();
                                    }
                                }
                                email = e + "@gmail.com";
                                c = true;
                            }
                        break;
                    case '9':
                        check = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }

                khBUS.Sua(maKH, tenKH, dchi, SDT, email);
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
            Console.WriteLine("\t\t║                                       THÔNG TIN CỦA BẠN,   {0, -27}                          ║", tmp[1].ToUpper());
            Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║             Họ tên             ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
            Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
            Console.WriteLine("\t\t║  {0,-7}║\t{1,-27}║  {2,-17}║     {3,-10}     ║  {4,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);
            Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
        }

        private void datMon(string maKH)
        {
            Console.Clear();
            QLHangHoa qlHH = new QLHangHoa();
            qlHH.Show();
            double tong = 0;
            Console.WriteLine();
            Console.WriteLine("\t\tĐặt món hoặc nhấn 'Enter' để thoát.");
            Console.Write("\t\tMời bạn chọn ID muốn đặt: ");
            string ID = Console.ReadLine().ToUpper();
            if (ID != "")
            {
                if (khBUS.Laythongtin(maKH) != "")
                {
                    // Lay du lieu tong truoc do
                    //string[] temp = hdBUS.LayThongTin(maKH).Split('\n');
                    //for(int x = 0; x < temp.Length; x++)
                    //{
                    //    string[] temp2 = temp[x].Split('\t');
                    //    if (temp2[2] == DateTime.Now.ToString("dd/MM/yyyy")
                    //        && Convert.ToInt32(temp2[4]) != 0)
                    //        tong = Convert.ToInt32(temp2[4]);
                    //}
                    string[] tmp = khBUS.Laythongtin(maKH).Split('\t');
                    DateTime date = DateTime.Now;
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
                            string q = Console.ReadLine();
                            if (q == "")
                                datMon(maKH);

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
                Console.Write("Khách hàng chưa có hóa đơn!");
                Console.ReadKey();
                return;
            }
            // Hiển thị hóa đơn nhưng không hiện mã khách hàng

            Console.SetWindowSize(140, 30);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                    Hóa đơn của {0,-27}     ║",name[1]);
            Console.WriteLine("\t\t╠═════════╦══════════════════════════════════╦═══════════════════╣");
            Console.WriteLine("\t\t║    Mã   ║         Tên khách hàng           ║        Ngày       ║");
            Console.WriteLine("\t\t╠═════════╬══════════════════════════════════╬═══════════════════╣");
            for (int x = 0; x < tmp.Length - 1; x++)
            {
                string[] tmp2 = tmp[x].Split('\t');
                Console.WriteLine("\t\t║ {0,-7} ║\t{1,-27}  ║  {2,-10}       ║", tmp2[0], tmp2[1], tmp2[2]);
            }
            Console.WriteLine("\t\t╚═════════╩══════════════════════════════════╩═══════════════════╝");

            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║ Tổng tiền của tất cả hóa đơn:  {0,-24}        ║", 0);//hdBUS.TongTien(maKH).ToString("N0")
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine();
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
                        Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("\t\t║                                Thông tin chi tiết của hóa đơn {0, -7}                           ║", maHD);
                        Console.WriteLine("\t\t╠═════════╦════════════════════════════════╦═══════════════════╦═════════════╦════════════════════╣");
                        Console.WriteLine("\t\t║  Mã món ║            Tên món             ║        Giá        ║  Số lượng   ║       Tổng         ║");
                        Console.WriteLine("\t\t╠═════════╬════════════════════════════════╬═══════════════════╬═════════════╬════════════════════╣");
                        for(int x = 0; x < hdBUS.HienChiTiet(maHD).Count; x++)
                        {
                            string[] tmp2 = hdBUS.HienChiTiet(maHD)[x].Split('\t');
                            Console.WriteLine("\t\t║ {0,-7} ║ {1,-30} ║ {2,-9}         ║     {3,-5}   ║ {4,-12}       ║", tmp2[0], tmp2[1], int.Parse(tmp2[2]).ToString("N0"), tmp2[3], (int.Parse(tmp2[2]) * int.Parse(tmp2[3])).ToString("N0"));
                            total += int.Parse(tmp2[2]) * int.Parse(tmp2[3]);
                        }
                        Console.WriteLine("\t\t╚═════════╩════════════════════════════════╩═══════════════════╩═════════════╩════════════════════╝");
                        
                        Console.WriteLine();
                        Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("\t\t║ Tổng hóa đơn:  {0,-24}                        ║", total.ToString("N0"));
                        Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════╝");
                        Console.Write("\t\tXem tiếp nhấn 'Enter' hoặc nhấn bất kỳ phím khác để thoát : ");
                        string check = Console.ReadLine();
                        if (check == "")
                        {
                            c = true;
                            LichSu(maKH);
                        }
                        else
                        {
                            c = true;
                            Console.Write("\t\tĐã thoát!");
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
    }
}