using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDon
{
    public class HoaDonBanHang
    {
        string MaKH, tenKH, MaSP;
        int SL;
        double GiaBan;
        public static double TLT = 0.08;

        public string MaKhach
        {
            get { return MaKH; }
            set
            {
                if (value.StartsWith("KH") && value.Length == 6)
                {
                    MaKH = value;
                }

                else
                {
                    throw new Exception("Sai ma");
                }
            }
        }

        public int SoLuong
        {
            get { return SL; }
            set
            {
                if (value < 0)
                    throw new Exception("So luong phai lon hon hoac bang 0");
                else
                    SL = value;
            }
        }

        public HoaDonBanHang()
        {
            MaKhach = "KH0001";
            tenKH = "Bao";
            MaSP = "MLToshiba01";
            SoLuong = 0;
            GiaBan = 4300000;
        }

        public HoaDonBanHang(string Makhach, string tenKH, string MaSP, int SoLuong,
                             double GiaBan)
        {
            this.MaKhach = Makhach;
            this.tenKH = tenKH;
            this.MaKH = MaSP;
            this.SoLuong = SoLuong;
            this.GiaBan = GiaBan;
        }

        public double TinhTien()
        {
            double ThueVAT = TLT * (SoLuong * GiaBan);
            return SoLuong * GiaBan - ThueVAT;
        }

        public void Xuat()
        {
            Console.WriteLine("Thong Tin Khach:");
            Console.WriteLine("Ma KH: "+ MaKhach);
            Console.WriteLine("Ten KH: "+tenKH);
            Console.WriteLine("Ma SP: "+MaSP);
            Console.WriteLine("So luong: {0}\nGia Ban: {1}", SoLuong, GiaBan);
            Console.WriteLine("Thanh tien: "+TinhTien());
        }
    }

    public class chuongTrinh
    { 
        static void Main(string[] args)
        {
            HoaDonBanHang HD = new HoaDonBanHang();
            HD.Xuat();
        }
    }
}
