using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class KhoaHoc
    {
        string maKH,tenKH, gioHoc, tenGV;
        int soBuoi, soHV;
        public static double HocPhi = 100000;
        public static double ThuLaoGV = 500000;

        public string MaKH
        {
            get { return maKH; }
            set
            {
                if (value.Length == 5 && value.StartsWith("KH") && (value.Substring(2).Equals("1")
                   || value.Substring(2).Equals("2")
                   || value.Substring(2).Equals("3")
                   && value.Substring(3).All(char.IsDigit)))
                    maKH = value;
                else
                    throw new Exception("Loi ma");
            }
        }
        public int SoBuoi
        {
            get { return soBuoi; }
            set
            {
                if (value < 0)
                    throw new Exception("So buoi lon hon 0");
                else
                    soBuoi = value;
            }
        }

        public string GioHoc
        {
            get { return gioHoc; }
            set
            {
                if (value.Equals("2, 4, 6") == true 
                    || value.Equals("3, 5, 7") == true 
                    || value.Equals("7, CN") == true)
                    gioHoc = value;
                else
                    gioHoc = "2, 4, 6";
            }
        }

        public int SoHV
        {
            get { return soHV; }
            set
            {
                if (value >= 10 && value <= 20)
                    soHV = value;
                else
                    throw new Exception("Loi so hoc vien");
            }
        }

        public KhoaHoc()
        {
            maKH = "KH100";
            tenKH = "Toan";
            SoBuoi = 1;
            gioHoc = "7, CN";
            SoHV = 10;
            tenGV = "Vinh DC";
        }

        public KhoaHoc(string MaKH, string tenKH, int SoBuoi, string GioHoc, int SoHV, string tenGV)
        {
            this.MaKH = MaKH;
            this.tenKH = tenKH;
            this.SoBuoi = SoBuoi;
            this.GioHoc = GioHoc;
            this.SoHV = SoHV;
            this.tenGV = tenGV;
        }

        public KhoaHoc(KhoaHoc KH)
        {
            this.MaKH = KH.MaKH;
            this.tenKH = KH.tenKH;
            this.SoBuoi = KH.SoBuoi;
            this.GioHoc = KH.GioHoc;
            this.SoHV = KH.SoHV;
            this.tenGV = KH.tenGV;
        }

        public double TinhHocPhi()
        {
            double HocPhi = SoBuoi * KhoaHoc.HocPhi;
            if(GioHoc.Equals("2, 4, 6") == true || GioHoc.Equals("3, 5, 7") == true)
                return HocPhi;
            else
                return HocPhi * 1.2;
        }

        public double TinhThuLao()
        {
            double ThuLao = SoBuoi * KhoaHoc.ThuLaoGV;
            if (SoHV >= 15)
                return ThuLao + (10000 * SoBuoi);
            else
                return ThuLao;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma khoa hoc: ");
            MaKH = Console.ReadLine();
            Console.Write("Nhap ten khoa hoc: ");
            tenKH = Console.ReadLine();
            Console.Write("Nhap so buoi: ");
            SoBuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap gio hoc: ");
            GioHoc = Console.ReadLine();
            Console.Write("Nhap so luong hoc vien");
            SoHV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten giang vien: ");
            tenGV = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Nhap ma khoa hoc: "+ MaKH);
            Console.WriteLine("Nhap ten khoa hoc: "+ tenKH);
            Console.WriteLine("Nhap so buoi: "+ SoBuoi);
            Console.WriteLine("Nhap gio hoc: "+ GioHoc);
            Console.WriteLine("Nhap so luong hoc vien"+ SoHV);
            Console.WriteLine("Nhap ten giang vien: "+ tenGV);
            Console.WriteLine("Gia hoc phi 1 buoi: "+KhoaHoc.HocPhi);
            Console.WriteLine("Gia hoc phi khoa hoc: " + TinhHocPhi());
            Console.WriteLine("Thu lao 1 buoi: "+ KhoaHoc.ThuLaoGV);
            Console.WriteLine("So tien giao vien nhan: "+TinhThuLao());
        }
    }
}
