using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Code by Trần Gia Bảo 15DHTH02 2001240040

namespace xayDungNgayThang
{
    public class NgayThang
    {
        private int ngay, thang, nam;

        public int Ngay
        {
            get { return this.ngay; }
            set
            {
                if (value <= SoNgayTrongThang(Thang, Nam) && value > 1)
                    this.ngay = value;
                else
                    throw new Exception("Loi! Ngay roi pe !!");
            }
        }
        public int Thang
        {
            get { return this.thang; }
            set
            {
                if (value >= 1 && value <= 12)
                    this.thang = value;
                else
                    throw new Exception("Loi! Thang roi pe!!");
            }
        }
        public int Nam
        {
            get { return this.nam; }
            set { this.nam = value; }
        }

        // Constructor mặc định
        public NgayThang()
        {
            this.ngay = 1;
            this.thang = 1;
            this.nam = 2025;
        }

        // Constructor 3 tham số
        public NgayThang(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        // Kiểm tra năm nhuận
        public bool kiemTraNamNhuan(int nam)
        {
            return (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0));
        }

        // Lấy số ngày trong tháng
        public int SoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    {
                        if (!kiemTraNamNhuan(nam))
                            return 28;
                        else
                            return 29;
                    }
                default:
                    return 0;
            }
        }

        // Xác định ngày hôm trước
        public NgayThang HomTruoc()
        {
            
            int d = ngay - 1;
            int m = thang;
            int y = nam;

            if (d == 0)
            {
                m--;
                if (m == 0)
                {
                    m = 12;
                    y--;
                }
                d = SoNgayTrongThang(m, y);
            }

            NgayThang ntNew = new NgayThang(d,m,y);
            return ntNew;
        }

        // Xác định ngày hôm sau
        public NgayThang HomSau()
        {
            int d = ngay + 1;
            int m = thang;
            int y = nam;

            if (d > SoNgayTrongThang(m, y))
            {
                d = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                    y++;
                }
            }
            return new NgayThang(d, m, y);
        }

        public class chuongTrinh
        {
            public static void Main(string[] args)
            {
                NgayThang nt = new NgayThang(4, 9, 2025);
                Console.WriteLine("Ngay hien tai: {0}/{1}/{2}", nt.Ngay, nt.Thang, nt.Nam);
                if (nt.kiemTraNamNhuan(nt.Nam))
                    Console.WriteLine("Nam nhuan");
                else
                    Console.WriteLine("Nam khong nhuan");
                Console.WriteLine("Hom truoc: {0}/{1}/{2}",nt.HomTruoc().Ngay ,nt.HomTruoc().Thang, nt.HomTruoc().Nam);
                Console.WriteLine("Hom truoc: {0}/{1}/{2}", nt.HomSau().Ngay, nt.HomSau().Thang, nt.HomSau().Nam);
            }
        }
    }
}
// Code by Trần Gia Bảo 15DHTH02 2001240040