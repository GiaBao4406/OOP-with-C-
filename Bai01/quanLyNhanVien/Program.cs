using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhanVien
{
    public class NhanVien
    {
        private string maNV, hoTen, soDienThoai;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private int namVaoLam;

        public string MaNV
        {
            get
            {
                return this.maNV;
            }
            set
            {
                if (value.Length == 6 && value.StartsWith("NV")
                    && value.Substring(2).All(char.IsDigit))
                    this.maNV = value;
                else
                    throw new Exception("Sai ma nhan vien!");
            }
        }

        public string HoTen
        {
            get; set;
        }

        public string SoDienThoai
        {
            get; set;
        }

        public bool GioiTinh
        {
            get; set;
        }

        public DateTime NgaySinh
        {
            get; set;
        }

        public int NamVaoLam
        {
            get
            {
                return this.namVaoLam;
            }
            set
            {
                if (value <= 1970)
                    throw new Exception("Loi nam vao lam!");
                else
                    this.namVaoLam = value;
            }
        }

        public NhanVien()
        {
            this.MaNV = "NV0012";
            this.HoTen = "Ly Thanh Thien";
            this.GioiTinh = true; // true: Nam
            this.NgaySinh = new DateTime(1960,01,20);
            this.NamVaoLam = 2010;
            this.SoDienThoai = "0909123456";
        }

        public NhanVien(string MaNV, string Hoten, DateTime NgaySinh)
        {
            this.MaNV = MaNV;
            this.HoTen = Hoten;
            this.NgaySinh = NgaySinh;
            this.GioiTinh= true; // true: Nam
            this.NamVaoLam = DateTime.Now.Year - 10;
            this.SoDienThoai = "0916321432";
        }

        public void xuatThongTinNV()
        {
            Console.WriteLine("Ma NV: {0}", MaNV);
            Console.WriteLine("Ten NV: {0}",HoTen);
            if (GioiTinh == true)
                Console.WriteLine("Gioi Tinh: Nam");
            else
                Console.WriteLine("Gioi Tinh: Nu");
            Console.WriteLine("Nam vao lam: {0}",NamVaoLam);
            Console.WriteLine("So dien thoai: {0}", SoDienThoai);
        }
    }

    public class chuongTrinh
    {
        public static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nv.xuatThongTinNV();
            Console.WriteLine("");
            DateTime ns = new DateTime(2006, 04, 04);
            NhanVien NV = new NhanVien("NV0102", "Tran Gia Bao", ns);
            NV.xuatThongTinNV();
        }       
    }
}
