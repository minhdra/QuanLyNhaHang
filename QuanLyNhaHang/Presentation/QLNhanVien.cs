using QuanLyNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.SHOW
{
    //class QLNhanVien
    //{
    //    private NhanVienBUS nvBUS = new NhanVienBUS();

    //    public void MenuNV()
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
    //            Console.Write("\n\t\t║ ║                       TÀI KHOẢN NHÂN VIÊN                         ║ ║");
    //            Console.Write("\n\t\t║ ║                                                                   ║ ║");
    //            Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 1.║ HIỂN THỊ DANH SÁCH NHÂN VIÊN ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 2.║       THÊM NHÂN VIÊN         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 3.║        SỬA THÔNG TIN         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 4.║        XÓA NHÂN VIÊN         ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
    //            Console.Write("\n\t\t║ ║              ║ 5.║    TẠO TÀI KHOẢN NHÂN VIÊN   ║                 ║ ║");
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
    //                    TaoTK();
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
    //                    MenuNV();
    //                    break;
    //            }
    //        }
    //    }

    //    private void Show()
    //    {
    //        Console.Clear();

    //        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
    //        Console.WriteLine("\t║                                                                DANH SÁCH NHÂN VIÊN                                                                ║");
    //        Console.WriteLine("\t╠═════════╦════════════════════════════════╦═════════════════════╦═══════════╦═══════════════════╦════════════════════╦═════════════════════════════╣");
    //        Console.WriteLine("\t║    Mã   ║             Họ tên             ║       Ngày sinh     ║ Giới tính ║       Địa chỉ     ║    Số điện thoại   ║            Email            ║");
    //        Console.WriteLine("\t╠═════════╬════════════════════════════════╬═════════════════════╬═══════════╬═══════════════════╬════════════════════╬═════════════════════════════╣");
    //        for(int x = 0; x < nvBUS.Laydanhsach().Count; x++)
    //        {
    //            string[] tmp = nvBUS.Laydanhsach()[x].Split('\t');
    //            Console.WriteLine("\t║  {0,-7}║\t{1,-27}║  {2,-10}         ║     {3,-3}   ║  {4,-17}║   {5,-10}       ║  {6,-27}║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6]);
    //        }
            
    //        Console.WriteLine("\t╚═════════╩════════════════════════════════╩═════════════════════╩═══════════╩═══════════════════╩════════════════════╩═════════════════════════════╝");
    //        Console.Write("\tNhấn phím bất kì để kết thúc!");

    //    }

    //    private void Them()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Nhấn 'Enter' để thoát hoặc nhấn phím khác để tiếp tục thêm nhân viên!");
    //        string check = Console.ReadLine();
    //        if (check != "")
    //        {
    //            string[] tmp = nvBUS.ThemTK().Split('#');
    //            Console.WriteLine("Tài khoản: {0}\nMật khẩu: {1}\nMã nhân viên: {2}", tmp[0], tmp[1], tmp[2]);
    //            Console.WriteLine("Tạo tài khoản thành công");

    //            Console.Write("Họ tên: ");
    //            string tenNV = Console.ReadLine();
    //            while (tenNV == "" || tenNV.Length > 27)
    //            {
    //                Console.Write("Nhập lại (dưới 27 ký tự): ");
    //                tenNV = Console.ReadLine();
    //            }
    //            Console.Write("Sinh nhật (dd/MM/yyyy): ");
    //            string tmp2 = Console.ReadLine();
    //            DateTime date = new DateTime();
    //            bool check2 = false;
    //            while (!check2)
    //            {

    //                try
    //                {
    //                    date = DateTime.Parse(tmp2);
    //                }
    //                catch
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                    tmp2 = Console.ReadLine();
    //                }
    //                if (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > 2002)
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                    tmp2 = Console.ReadLine();
    //                }
    //                else
    //                    check2 = true;
    //            }

    //            Console.Write("Giới tính (1 : Nam, 0: Nữ): ");
    //            string chose = Console.ReadLine();
    //            bool GT = false;
    //            while (chose != "0" && chose != "1")
    //            {
    //                Console.Write("Không hợp lệ! Nhập lại: ");
    //                chose = Console.ReadLine().ToUpper();
    //            }
    //            if (chose == "1")
    //                GT = true;

    //            Console.Write("Địa chỉ: ");
    //            string dchi = Console.ReadLine();
    //            while (dchi == "" || dchi.Length > 17)
    //            {
    //                Console.Write("Nhập lại (dưới 17 ký tự): ");
    //                dchi = Console.ReadLine();
    //            }

    //            // SDT có 10 ký tự và bắt đầu bằng số 0
    //            Console.Write("Số điện thoại: ");
    //            string SDT = Console.ReadLine();
    //            for (int x = 0; x < SDT.Length; x++)
    //            {
    //                if (!char.IsDigit(SDT[x]) || SDT.Length != 10 || SDT[0] != '0')
    //                {
    //                    Console.Write("Nhập lại: ");
    //                    SDT = Console.ReadLine();
    //                    x = 0;
    //                }
    //            }

    //            Console.Write("Email (...@gmail.com): ");
    //            string e = Console.ReadLine(), email = "";
    //            bool c = false;
    //            while (!c)
    //            {
    //                for (int x = 0; x < e.Length; x++)
    //                {
    //                    while (e.Length > 17)
    //                    {
    //                        Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
    //                        e = Console.ReadLine();
    //                    }
    //                    if ((e[x] >= 0 && e[x] < 48)
    //                        || (e[x] > 57 && e[x] < 65)
    //                        || (e[x] > 90 && e[x] < 97) || e[x] > 122)
    //                    {
    //                        x = -1;
    //                        Console.Write("Nhập lại (...@gmail.com): ");
    //                        e = Console.ReadLine();
    //                    }
    //                }
    //                email = e + "@gmail.com";
    //                c = true;
    //            }
    //            nvBUS.ThemNV(tmp[2], tenNV, date, GT, dchi, SDT, email);
    //            Console.WriteLine("Thêm nhân viên thành công!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát!");
    //    }

    //    private void Sua()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Sửa thông tin nhân viên hoặc nhấn 'Enter' để bỏ qua. ");
    //        Console.Write("Nhập mã nhân viên muốn sửa: ");
    //        string maNV = Console.ReadLine().ToUpper();
    //        if (maNV != "")
    //        {
    //            if (nvBUS.TimKiem(maNV) != "")
    //            {
    //                Console.Write("Họ tên: ");
    //                string tenNV = Console.ReadLine();
    //                while (tenNV == "" || tenNV.Length > 27)
    //                {
    //                    Console.Write("Nhập lại (dưới 27 ký tự): ");
    //                    tenNV = Console.ReadLine();
    //                }
    //                Console.Write("Sinh nhật (dd/MM/yyyy): ");
    //                string tmp2 = Console.ReadLine();
    //                DateTime date = new DateTime();
    //                bool check2 = false;
    //                while (!check2)
    //                {

    //                    try
    //                    {
    //                        date = DateTime.Parse(tmp2);
    //                    }
    //                    catch
    //                    {
    //                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                        tmp2 = Console.ReadLine();
    //                    }
    //                    if (date.ToString("dd/MM/yyyy") == "01/01/0001" || date.Year > 2002)
    //                    {
    //                        Console.Write("Không hợp lệ! Nhập lại (dd/MM/yyyy): ");
    //                        tmp2 = Console.ReadLine();
    //                    }
    //                    else
    //                        check2 = true;
    //                }

    //                Console.Write("Giới tính (1 : Nam, 0: Nữ): ");
    //                string chose = Console.ReadLine();
    //                bool GT = false;
    //                while (chose != "0" && chose != "1")
    //                {
    //                    Console.Write("Không hợp lệ! Nhập lại: ");
    //                    chose = Console.ReadLine().ToUpper();
    //                }
    //                if (chose == "1")
    //                    GT = true;

    //                Console.Write("Địa chỉ: ");
    //                string dchi = Console.ReadLine();
    //                while (dchi == "" || dchi.Length > 17)
    //                {
    //                    Console.Write("Nhập lại (dưới 17 ký tự): ");
    //                    dchi = Console.ReadLine();
    //                }

    //                // SDT có 10 ký tự và bắt đầu bằng số 0
    //                Console.Write("Số điện thoại: ");
    //                string SDT = Console.ReadLine();
    //                for (int x = 0; x < SDT.Length; x++)
    //                {
    //                    if (!char.IsDigit(SDT[x]) || SDT.Length != 10 || SDT[0] != '0')
    //                    {
    //                        Console.Write("Nhập lại: ");
    //                        SDT = Console.ReadLine();
    //                        x = 0;
    //                    }
    //                }

    //                Console.Write("Email (...@gmail.com): ");
    //                string e = Console.ReadLine(), email = "";
    //                bool c = false;
    //                while (!c)
    //                {
    //                    for (int x = 0; x < e.Length; x++)
    //                    {
    //                        while (e.Length > 17)
    //                        {
    //                            Console.Write("Nhập lại (...@gmail.com và dưới 17 ký tự): ");
    //                            e = Console.ReadLine();
    //                        }
    //                        if ((e[x] >= 0 && e[x] < 48)
    //                            || (e[x] > 57 && e[x] < 65)
    //                            || (e[x] > 90 && e[x] < 97) || e[x] > 122)
    //                        {
    //                            x = -1;
    //                            Console.Write("Nhập lại (...@gmail.com): ");
    //                            e = Console.ReadLine();
    //                        }
    //                    }
    //                    email = e + "@gmail.com";
    //                    c = true;
    //                }
    //                nvBUS.SuaNV(maNV, tenNV, date, GT, dchi, SDT, email);
    //                Console.WriteLine("Đã cập nhật thông tin thành công!");
    //            }
    //            else
    //                Console.WriteLine("Nhân viên không tồn tại!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát.");
    //    }

    //    private void Xoa()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Xóa nhân viên hoặc nhấn 'Enter' để thoát.");
    //        Console.Write("Nhập mã nhân viên muốn xóa: ");
    //        string maNV = Console.ReadLine().ToUpper();
    //        if (maNV != "")
    //        {
    //            if (nvBUS.TimKiem(maNV) != "")
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
    //                    nvBUS.Xoa(maNV);
    //                    Console.WriteLine("Đã xóa thành công!!!");
    //                }
    //                else
    //                    Console.WriteLine("Đã hủy xóa!!!");
    //            }
    //            else
    //                Console.WriteLine("Khách hàng không tồn tại!");
    //        }
    //        else
    //            Console.WriteLine("Đã thoát!");
    //    }

    //    private void TaoTK()
    //    {
    //        Console.Clear();
    //        string[] tmp = nvBUS.ThemTK().Split('#');
    //        Console.WriteLine("Tài khoản: {0}\nMật khẩu: {1}\nMã nhân viên: {2}", tmp[0], tmp[1], tmp[2]);
    //        Console.WriteLine("Tạo tài khoản thành công");
    //    }
    //}
}
