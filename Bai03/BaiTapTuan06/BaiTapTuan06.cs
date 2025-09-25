using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuyenXe
{
    public class ChuyenXe
    {
        protected string MaChuyen, HoTenTX;
        protected int SoXe;
        protected double DoanhThu;
        public ChuyenXe ()
        {
            MaChuyen = "Chua co";
            HoTenTX = "Chua co";
            SoXe = 0;
            DoanhThu = 0;
        }
        public ChuyenXe (string MaChuyen, string HoTenTX, int SoXe, double DoanhThu)
        {
            this.MaChuyen = MaChuyen;
            this.HoTenTX = HoTenTX;
            this.SoXe = SoXe;
            this.DoanhThu = DoanhThu;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma chuyen: ");
            MaChuyen = Console.ReadLine();

            Console.Write("Nhap ten tai xe: ");
            HoTenTX = Console.ReadLine();

            Console.Write("Nhap so xe: ");
            SoXe = int.Parse(Console.ReadLine());

            Console.Write("Nhap doanh thu: ");
            DoanhThu = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ma chuyen: "+MaChuyen);
            Console.WriteLine("Ten tai xe: "+HoTenTX);
            Console.WriteLine("So xe: "+SoXe);
            Console.WriteLine("Doanh Thu: "+DoanhThu);
        }
    }
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        int SoTuyen;
        double SoKm;
        public ChuyenXeNoiThanh():base()
        {
            SoTuyen = 0;
            SoKm = 0;
        }
        public ChuyenXeNoiThanh(string MaChuyen, string HoTenTX, int SoXe, double DoanhThu, int SoTuyen, double SoKm) : base(MaChuyen, HoTenTX, SoXe, DoanhThu)
        {
            this.SoTuyen = SoTuyen;
            this.SoKm = SoKm;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so tuyen: ");
            SoTuyen = int.Parse(Console.ReadLine());
            Console.Write("Nhap so km: ");
            SoKm = double.Parse(Console.ReadLine());
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So tuyen: "+ SoTuyen);
            Console.WriteLine("So Km: "+SoKm);
        }
    }
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        string NoiDen;
        double SoNgayDiDuoc;
        public ChuyenXeNgoaiThanh() : base()
        {
            NoiDen = "Chua co";
            SoNgayDiDuoc = 0;
        }
        public ChuyenXeNgoaiThanh(string MaChuyen, string HoTenTX, int SoXe, double DoanhThu, string NoiDen, double SoNgayDiDuoc) : base(MaChuyen, HoTenTX, SoXe, DoanhThu)
        {
            this.NoiDen = NoiDen;
            this.SoNgayDiDuoc = SoNgayDiDuoc;
        }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap noi den: ");
            NoiDen = Console.ReadLine();
            Console.Write("Nhap so ngay di duoc: ");
            SoNgayDiDuoc = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Noi den: " + NoiDen);
            Console.WriteLine("So ngay di duoc: "+SoNgayDiDuoc);
        }
    }
    public class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Chuyen xe noi thanh ---");
            ChuyenXeNoiThanh CXNoiT = new ChuyenXeNoiThanh();
            CXNoiT.Nhap();
            CXNoiT.Xuat();
            Console.WriteLine("--- Chuyen xe nogai  thanh ---");
            ChuyenXeNgoaiThanh CXNgoaiT = new ChuyenXeNgoaiThanh();
            CXNgoaiT.Nhap();
            CXNgoaiT.Xuat();
        }
    }
}
