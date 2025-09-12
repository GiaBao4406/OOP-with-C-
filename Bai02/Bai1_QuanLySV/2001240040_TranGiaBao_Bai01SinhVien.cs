// Bai01SV - 2001240040 - Trần Gia Bảo - 15DHTH02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    public class SinhVien
    {
        string Ma, Hoten;
        double Diem;

        public double DiemSV
        {
            get { return Diem; }
            set { Diem = value; }
        }
        public string HoTenSV
        {
            get { return Hoten; }
            set { Hoten = value; }
        }

        public string MaSV
        {
            get { return Ma; }
            set { Ma = value; }
        }

        public void NhapTTSV()
        {
            Console.Write("Nhap ma sv: ");
            MaSV = Console.ReadLine();

            Console.Write("Nhap ho ten sv: ");
            HoTenSV = Console.ReadLine();

            Console.Write("Nhap diem: ");
            DiemSV = double.Parse(Console.ReadLine());
        }

        public void XuatTTSV()
        {
            Console.WriteLine("Ma SV: {0}", MaSV);
            Console.WriteLine("Ho ten SV: {0}", Hoten);
            Console.WriteLine("Diem: {0}", Diem);
        }
    }
}
