using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class HoaDon
    {
        string hangSX, soSeries, tenSP, loaiSP;
        double giaBan;
        public static double ThueVAT = 0.1;

        public string SoSeries
        {
            get 
            {
                return soSeries;
            }
            set
            {
                if (value.StartsWith("S"))
                    soSeries = value;
                else
                    soSeries = "S000";
            }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value > 4000000)
                    giaBan = value;
                else
                    throw new Exception("Gia ban phai lon hon 4tr");
            }
        }

        public string LoaiSP
        {
            get { return loaiSP; }
            set
            {
                if (value == "May tinh de ban" || value == "May tinh xach tay" || value == "Dien thoai di dong")
                    loaiSP = value;
                else
                    loaiSP = "Dien thoai di dong";
            }
        }

        public double PhiBaoHanh()
        {
            if (LoaiSP == "May tinh de ban")
                return 0.08 * GiaBan;
            else if (LoaiSP == "May tinh xach tay")
                return 0.05 * GiaBan;
            else
            {
                if (0.1 * GiaBan > 2000000)
                    return 2000000;
                else
                    return 0.1 * GiaBan;
            }
        }

        public double UuDai()
        {
            if (LoaiSP == "Dien thoai di dong" && hangSX == "SamSung")
                return 500000;
            return 0;
        }

        public double Thue()
        {
            return GiaBan * ThueVAT;
        }

        public double TinhTien()
        { 
           return GiaBan + PhiBaoHanh() - UuDai() + Thue();
        }

        public HoaDon()
        { 
            this.hangSX = "SamSung";
            this.SoSeries = "S001";
            this.tenSP = "SmartPhone";
            this.LoaiSP = "Dien thoai di dong";
            this.GiaBan = 7000000;
        }

        public HoaDon(string hangSX, string SoSeries, string tenSP, string LoaiSP, double GiaBan)
        {
           
            this.hangSX = hangSX;
            this.SoSeries = SoSeries;
            this.tenSP = tenSP;
            this.LoaiSP = LoaiSP;
            this.GiaBan = GiaBan;
        }
        public HoaDon(HoaDon HD)
        {

            this.hangSX = HD.hangSX;
            this.SoSeries = HD.SoSeries;
            this.tenSP = HD.tenSP;
            this.LoaiSP = HD.LoaiSP;
            this.GiaBan = HD.GiaBan;
        }
        public void Nhap()
        {
            Console.Write("Nhap hang: ");
            hangSX = Console.ReadLine();
            Console.Write("Nhap SoSeries: ");
            SoSeries = Console.ReadLine();
            Console.Write("Nhap ten sp: ");
            tenSP = Console.ReadLine();
            Console.Write("Nhap loai sp: ");
            LoaiSP = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            GiaBan = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Nhap hang: "+ hangSX);
            Console.WriteLine("Nhap SoSeries: "+ SoSeries);
            Console.WriteLine("Nhap ten sp: "+ tenSP);
            Console.WriteLine("Nhap loai sp: " + LoaiSP);
            Console.WriteLine("Nhap gia ban: "+GiaBan);
        }
    }
}
