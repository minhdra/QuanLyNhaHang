using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Constraint;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Presentation
{
    // 1 Nhân viên
    class NhanVienPre
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private constraint conP = new constraint();

        public void HienMenuNV(string maNV)
        {

            while (true)
            {
                // Kiểm tra khách có tồn tại
                int check = 0;
                if (nvBUS.Laythongtin(maNV) != "")
                {
                    string[] pro = nvBUS.Laythongtin(maNV).Split('#');
                    if(pro[1] != "empty")
                        check = 1;
                }

                Console.Clear();

                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t\t\t║                  CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG ĂN                     ║");
                Console.Write("\n\t\t\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t\t\t║                                                                       ║");
                Console.Write("\n\t\t\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║                             CHÀO BẠN                              ║ ║");
                Console.Write("\n\t\t\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 1.║       THÊM THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 2.║        SỬA THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 3.║        XEM THÔNG TIN         ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t\t\t║ ║              ║ 4.║         ĐỔI MẬT KHẨU         ║                 ║ ║");
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
                Console.SetCursorPosition(80, 29);

                char chose = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (chose)
                {
                    case '1':
                        if (check == 0)
                            ThemThongTin(maNV);
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
                            SuaThongTin(maNV);
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
                            XemThongTin(maNV);
                        Console.ReadKey();
                        break;
                    case '4':
                        DoiMatKhau(maNV);
                        Console.ReadKey();
                        break;
                    case '9':
                        TaiKhoanPre.NhanVien tknv = new TaiKhoanPre.NhanVien();
                        tknv.HienMenuNV();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        HienMenuNV(maNV);
                        break;
                }
            }
        }

        public void ThemThongTin(string maNV)
        {
            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Write("\n\t\t╔═══════════════════════════════════════════════════════╗");
            Console.Write("\n\t\t║                     THÊM THÔNG TIN                    ║");
            Console.Write("\n\t\t╠═══════════════════════════════════════════════════════╣");
            Console.Write("\n\t\t║                                                       ║");
            Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════╗ ║");
            Console.Write("\n\t\t║ ║  NHẤN ENTER ĐỂ THOÁT!                             ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Họ Tên         :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Ngày sinh      :                                 ║ ║");
            Console.Write("\n\t\t║ ║ (dd/MM/yyyy)                                      ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Giới tính      :                                 ║ ║");
            Console.Write("\n\t\t║ ║ (1 : Nam, 2 : Nu)                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Địa chỉ        :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Số điện thoại  :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  CCCD           :                                 ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║  Email          :                      @gmail.com ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ║                                                   ║ ║");
            Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════╝ ║");
            Console.Write("\n\t\t║                                                       ║");
            Console.Write("\n\t\t╚═══════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(38, 8);

            Console.SetCursorPosition(38, 8);
            string tenNV = Console.ReadLine();
            if (tenNV == "") return;
            tenNV = conP.CheckStr2(tenNV, 27, 38, 8, 26, 26);

            Console.SetCursorPosition(38, 10);
            string dateStr = Console.ReadLine();
            DateTime date = conP.Date2(dateStr, 38, 10, 33, 26);

            Console.SetCursorPosition(38, 13);
            string chose = Console.ReadLine().ToLower();
            bool GT = conP.Gender2(chose, 38, 13, 33, 26);

            Console.SetCursorPosition(38, 16);
            string dchi = Console.ReadLine();
            dchi = conP.CheckStr2(dchi, 17, 38, 16, 26, 26);

            Console.SetCursorPosition(38, 18);
            string SDT = Console.ReadLine();
            SDT = conP.NumberPhone2(SDT, 38, 18, 33, 26);

            Console.SetCursorPosition(38, 20);
            string CMT = Console.ReadLine();
            CMT = conP.CMT2(CMT, 38, 20, 33, 26);

            Console.SetCursorPosition(38, 22);
            string email = Console.ReadLine();
            email = conP.Email2(email, 38, 22, 33, 26);

            nvBUS.SuaNV(maNV, conP.Capitalize(tenNV), date, GT, conP.Capitalize(dchi), SDT, CMT, email);

            Console.SetCursorPosition(29, 26);
            Console.Write("Bạn đã thêm thông tin thành công!!!");
            Console.ReadKey();

        }

        public void SuaThongTin(string maNV)
        {
            bool check = false;

            while (!check)
            {
                Console.Clear();

                string[] tmp = nvBUS.Laythongtin(maNV).Split('#');
                DateTime birth = DateTime.Parse(tmp[2]);
                bool gen = true;
                if (tmp[3] == "Nu")
                    gen = false;
                string tenNV = tmp[1], dchi = tmp[4], SDT = tmp[5], CMT = tmp[6], email = tmp[7];
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                Console.Write("\n\t\t             ╔═══╦═════════════════════════════════════╗                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║   ║          SỬA THÔNG TIN              ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 1.║  Họ Tên: {0,-27}║", tenNV);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 2.║  Ngày sinh: {0,-10}              ║                 ", birth.ToString("dd/MM/yyyy"));
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 3.║  Giới tính: {0,-3}                     ║                 ", tmp[3]);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 4.║  Địa chỉ : {0,-17}        ║                 ", dchi);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 5.║  SDT : {0,-10}                   ║                 ", SDT);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 6.║  CCCD : {0,-12}                ║                 ", CMT);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 7.║  Email: {0,-27} ║  ", email);
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 9.║              Quay lại               ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║                                     ║                 ");
                Console.Write("\n\t\t             ║ 0.║               Thoát                 ║                 ");
                Console.Write("\n\t\t             ║___║_____________________________________║                 ");
                Console.Write("\n\t\t             ║   ║ Bấm phím theo số để chọn:           ║                 ");
                Console.Write("\n\t\t             ╚═══╩═════════════════════════════════════╝                 ");
                Console.SetCursorPosition(61, 33);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                string t;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Họ tên mới (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            tenNV = conP.CheckStr(t, 27);
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Sinh nhật (dd/MM/yyyy) (Enter để thoát): ");
                        t = Console.ReadLine();
                        if(t != "")
                            birth = conP.Date(t);

                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("Giới tính (1 : Nam, 0: Nữ) (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            gen = conP.Gender(t);
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Địa chỉ (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            dchi = conP.CheckStr(t, 17);
                        break;
                    case '5':
                        Console.Clear();
                        Console.Write("Số điện thoại (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            SDT = conP.NumberPhone(t);
                        break;
                    case '6':
                        Console.Clear();
                        Console.Write("CCCD (Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            CMT = conP.CMT(t);
                        break;
                    case '7':
                        Console.Clear();
                        Console.Write("Email (...@gmail.com hoặc Enter để thoát): ");
                        t = Console.ReadLine();
                        if (t != "")
                            email = conP.Email(t);
                        break;
                    case '9':
                        //HienMenuNV(maNV);
                        check = true;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }

                nvBUS.SuaNV(maNV, conP.Capitalize(tenNV), birth, gen, conP.Capitalize(dchi), SDT, CMT, email);
            }

        }

        private void XemThongTin(string maNV)
        {
            Console.Clear();

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            string[] tmp = nvBUS.Laythongtin(maNV).Split('#');
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                                                                      THÔNG TIN CỦA BẠN,   {0, -27}                                            ║", tmp[1]);
            Console.WriteLine("  ╠═════════╦═════════════════════════════╦════════════╦═══════════╦═══════════════════╦═════════════════╦══════════════╦═════════════════════════════╦══════════════╣");
            Console.WriteLine("  ║    Mã   ║            Họ tên           ║ Ngày sinh  ║ Giới tính ║      Địa chỉ      ║  Số điện thoại  ║     CCCD     ║            Email            ║   Chức vụ    ║");
            Console.WriteLine("  ╠═════════╬═════════════════════════════╬════════════╬═══════════╬═══════════════════╬═════════════════╬══════════════╬═════════════════════════════╬══════════════╣");
            Console.WriteLine("  ║  {0,-7}║ {1,-27} ║ {2,-10} ║    {3,-3}    ║  {4,-17}║   {5,-10}    ║ {6,-12} ║  {7,-27}║ {8,-12} ║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]);
            Console.WriteLine("  ╚═════════╩═════════════════════════════╩════════════╩═══════════╩═══════════════════╩═════════════════╩══════════════╩═════════════════════════════╩══════════════╝");
            Console.Write("\n  Nhấn phím bất kì để kết thúc!");
        }
        
        private void DoiMatKhau(string maNV)
        {
            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
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
            if (MK1 != "")
            {
                Console.SetCursorPosition(34, 9);
                string MK2 = Console.ReadLine();
                if(MK2 != MK1)
                {
                    Console.Write("\n\tMật khẩu không giống nhau!");
                    return;
                }
                nvBUS.DoiMK(maNV, MK1);
                Console.WriteLine("\n\tBạn đổi mật khẩu thành công!");
            }
            else
                Console.Write("\n\n\n\n\tĐã thoát!");
        }

    }

   
}
