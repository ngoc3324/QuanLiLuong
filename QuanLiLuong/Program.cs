using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuong
{
    public class Program
    {
        static void Main(string[] args)
        {
            BangLuong bangLuong = new BangLuong();

            // Nhập thông tin danh sách nhân viên
            bangLuong.NhapDanhSachNhanVien();

            // Hiển thị bảng lương
            Console.WriteLine("\nBang luong cua cac nhan vien:");
            bangLuong.HienThiBangLuong();


        }
    }
}
