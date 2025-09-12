// Bai01DSSV - 2001240040 - Trần Gia Bảo - 15DHTH02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    public class DSSinhVien
    {
        List<SinhVien> lstSV = new List<SinhVien>();
        public List<SinhVien> LstSV
        {
            get
            {
                return lstSV;
            }
            set
            {
                lstSV = value;
            }
        }

        public void NhapDS()
        {
            Console.Write("Nhap si so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. ", i + 1);
                SinhVien SV = new SinhVien();
                SV.NhapTTSV();
                LstSV.Add(SV);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (SinhVien sv in LstSV)
            {
                sv.XuatTTSV();
            }
        }
        public void XuatDSSVDiemHon8()
        {
            Console.WriteLine("Danh sach sinh vien diem lon hon 8:");
            foreach (SinhVien sv in LstSV)
            {
                if (sv.DiemSV > 8)
                    sv.XuatTTSV();
                else
                    Console.WriteLine("Khong tim thay");
            }
        }

        public void XuatDSSVTheoTen()
        {
            string Ten;
            Console.Write("Nhap ho ten can tim:");
            Ten = Console.ReadLine();
            Console.WriteLine("Danh sach sinh vien tim duoc: ");
            foreach (SinhVien sv in LstSV)
            {
                if (string.Compare(sv.HoTenSV, Ten) == 0)
                    sv.XuatTTSV();
                else
                    Console.WriteLine("Khong tim thay");
            }
        }

        public void XuatDSSVTheoMa()
        {
            string Ma;
            Console.Write("Nhap ma sv can tim:");
            Ma = Console.ReadLine();
            Console.WriteLine("Danh sach sinh vien tim duoc: ");
            foreach (SinhVien sv in LstSV)
            {
                if (string.Compare(sv.MaSV, Ma) == 0)
                    sv.XuatTTSV();
                else
                    Console.WriteLine("Khong tim thay");
            }
        }
    }
    public class chuongTrinh
    {
        public static void Main(string[] args)
        {
            DSSinhVien dssv = new DSSinhVien();
            dssv.NhapDS();
            dssv.XuatDS();
            dssv.XuatDSSVDiemHon8();
            dssv.XuatDSSVTheoTen();
            dssv.XuatDSSVTheoMa();
        }
    }
}
