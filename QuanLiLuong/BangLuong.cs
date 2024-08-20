using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuong
{
    public class BangLuong
    {
        private List<NhanVien> danhSachNhanVien;

        public BangLuong()
        {
            danhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nv)
        {
            danhSachNhanVien.Add(nv);
        }
        //Nhập danh sách từ bàn phím
        public void NhapDanhSachNhanVien()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 1; i <= soLuong; i++)
            {
                Console.WriteLine($"\nNhap thong tin cho nhan vien thu {i}:");
                Console.WriteLine("Chon loai nhan vien: 1 - NhanVien, 2 - NhanVienPhongA, 3 - NhanVienPhongB");
                int loai = int.Parse(Console.ReadLine());

                NhanVien nv;
                if (loai == 1)
                {
                    nv = new NhanVien();
                }
                else if (loai == 2)
                {
                    nv = new NhanVienPhongA();
                }
                else if (loai == 3)
                {
                    nv = new NhanVienPhongB();
                }
                else
                {
                    Console.WriteLine("Loai nhan vien khong hop le!");
                    continue;
                }

                nv.NhapThongTin();
                ThemNhanVien(nv);
            }
        }

        //Lương tất cả của các nhân viên
        public void HienThiBangLuong()
        {
            foreach (var nv in danhSachNhanVien)
            {
                Console.WriteLine(nv.ToString());
            }
        }
    }
}
