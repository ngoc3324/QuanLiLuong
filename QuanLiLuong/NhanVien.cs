using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuong
{
    public class NhanVien
    {
        string MaNV { get; set; }
        string HoTen { get; set; }
        public float LuongCoBan { get; set; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, float luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = float.Parse(Console.ReadLine());
        }

        //Phương thức tính lương (chỉ lưởng cơ bản)
        public virtual float TinhLuong()
        {
            return LuongCoBan;
        }

        //Phương thức ghi đè để trả về chuỗi thông tin nhân viên
        public override string ToString()
        {
            return $"MaNV: {MaNV}, HoTen: {HoTen}, Luong: {TinhLuong()}";
        }
    }

}
