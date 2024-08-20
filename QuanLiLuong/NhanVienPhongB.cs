using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuong
{
    public class NhanVienPhongB : NhanVien
    {
        public int SoGioLamThem { get; set; }
        public float LuongGioLamThem { get; set; }

        public NhanVienPhongB() { }

        //Hàm tạo có tham số để khởi tạo giờ lm thêm, lương giờ làm thêm
        public NhanVienPhongB(string maNV, string hoTen, float luongCoBan, int soGioLamThem, float luongGioLamThem)
            : base(maNV, hoTen, luongCoBan)
        {
            SoGioLamThem = soGioLamThem;
            LuongGioLamThem = luongGioLamThem;
        }

        // Ghi đè nhập thông tin giờ lm thêm, lương lm thêm
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap so gio lam them: ");
            SoGioLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong gio lam them: ");
            LuongGioLamThem = float.Parse(Console.ReadLine());
        }

        //Ghi đè tính lương cở bản + lương lm thêm
        public override float TinhLuong()
        {
            return LuongCoBan + (SoGioLamThem * LuongGioLamThem);
        }
    }

}  
