using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuong
{
    public class NhanVienPhongA : NhanVien
    {
        public float PhuCap { get; set; }

        public NhanVienPhongA() { }

        //Hàm tạo có tham số để khởi tạo car thuộc tính phụ cấp
        public NhanVienPhongA(string maNV, string hoTen, float luongCoBan, float phuCap)
            : base(maNV, hoTen, luongCoBan)
        {
            PhuCap = phuCap;
        }
        // Ghi đè nhập thông tin cả phụ cấp
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap phu cap: ");
            PhuCap = float.Parse(Console.ReadLine());
        }

        //Ghi đè tính lương cở bản  + phụ cấp
        public override float TinhLuong()
        {
            return LuongCoBan + PhuCap;
        }
    }

}
