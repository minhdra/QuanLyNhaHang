using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Object_Properties
{
    class Person
    {
        private string id, name, diachi, sdt, cmt, email;
        private DateTime ngaysinh;
        private bool gioitinh;

        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string SDT { get { return sdt; } set { sdt = value; } }
        public string CMT { get { return cmt; } set { cmt = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime NgaySinh { get { return ngaysinh; } set { ngaysinh = value; } }
        public bool GioiTinh { get { return gioitinh; } set { gioitinh = value; } }
    }
}
