// Bai01NV - 2001240040 - Trần Gia Bảo - 15DHTH02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLyNV
{
    public class NhanVien
    {
        private string maNV, hoTen;
        private int namVaoLam;
        private double HeSoLuong;

        public static double MLTT = 1490;

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

        public double hsl
        {
            get
            { 
                return HeSoLuong; 
            }
            set
            {
                HeSoLuong = value;
            }
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

        //public NhanVien(string MaNV, string Hoten, DateTime NgaySinh, bool GioiTinh, int NamVaoLam, string SoDienThoai)
        //{
        //    this.MaNV = MaNV;
        //    this.HoTen = Hoten;
        //    this.NgaySinh = NgaySinh;
        //    this.GioiTinh = GioiTinh; // true: Nam
        //    this.NamVaoLam = NamVaoLam;
        //    this.SoDienThoai = SoDienThoai;
        //}

        public void NhapThongTinNV()
        {
            Console.Write("Nhap Ma NV: ");
            MaNV = Console.ReadLine();

            Console.Write("Ten NV: ");
            HoTen = Console.ReadLine();

            Console.Write("True: Nam\nFalse:Nu\nNhap gioi tinh: ");
            GioiTinh = bool.Parse(Console.ReadLine());

            Console.Write("Nam vao lam: ");
            NamVaoLam = int.Parse(Console.ReadLine());

            Console.WriteLine("So dien thoai: ");
            SoDienThoai = Console.ReadLine();

            Console.Write("Nhap he so luong: ");
            hsl = double.Parse(Console.ReadLine());
        }

        public void xuatThongTinNV()
        {
            Console.WriteLine("Ma NV: {0}", MaNV);
            Console.WriteLine("Ten NV: {0}", HoTen);
            if (GioiTinh == true)
                Console.WriteLine("Gioi Tinh: Nam");
            else
                Console.WriteLine("Gioi Tinh: Nu");
            Console.WriteLine("Nam vao lam: {0}", NamVaoLam);
            Console.WriteLine("So dien thoai: {0}", SoDienThoai);
            Console.WriteLine("Luong: {0}", tinhLuong());
        }

        public double HSPCTN()
        {
            return DateTime.Now.Year - namVaoLam;
        }

        public double LCB()
        {
            return HeSoLuong * MLTT;
        }

        public double tinhLuong()
        {
            return LCB() * HSPCTN();
        }
    }
}
