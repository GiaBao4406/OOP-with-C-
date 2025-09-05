// Bai02 - 2001240040 - Trần Gia Bảo - 15DHTH02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xayDungPHANSO
{
    public class PHANSO
    {
        private int tu, mau;

        public int Tu
        {
            get { return this.tu; }
            set { this.tu = value; }
        }

        public int Mau
        {
            get { return this.mau; }
            set
            {
                if (value <= 0)
                    throw new Exception("Mau lon hon 0 nha pe!");
                this.mau = value;
            }
        }

        //Constructor mac dinh
        public PHANSO()
        {
            this.tu = 0;
            this.mau = 1;
        }

        //Constructor co tham so
        public PHANSO(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        // Rút gọn phân số
        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(this.tu), Math.Abs(this.mau));
            this.tu /= ucln;
            this.mau /= ucln;
            if (this.mau < 0)
            {
                this.tu = -tu;
                this.mau = -mau;
            }
        }

        // Hàm tính UCLN
        private int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public PHANSO Cong(PHANSO ps)
        {
            int tuMoi = this.tu * ps.mau + ps.tu * this.mau;
            int mauMoi = this.mau * ps.mau;
            PHANSO kq = new PHANSO(tuMoi, mauMoi);
            kq.RutGon();
            return kq;
        }

        public PHANSO Cong(int x)
        {
            int tuMoi = this.tu + x * this.mau;
            int mauMoi = this.mau;
            PHANSO kq = new PHANSO(tuMoi, mauMoi);
            kq.RutGon();
            return kq;
        }
    }

    public class nhap
    {
        private int n;
        public int soNguyenN
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public void nhapSoNguyen()
        {
            Console.Write("Nhap so nguyen can tinh: ");
            this.soNguyenN = int.Parse(Console.ReadLine());
        }
    }


    public class chuongTrinh
    {
        public static void Main(string[] args)
        {
            PHANSO ps1 = new PHANSO(1, 2);   // 1/2
            PHANSO ps2 = new PHANSO(2, 3);   // 2/3

            Console.WriteLine("Phan so 1: {0}/{1}", ps1.Tu,ps1.Mau);
            Console.WriteLine("Phan so 2: {0}/{1}", ps2.Tu,ps2.Mau);
            Console.WriteLine("Tong 2 phan so: {0}/{1}", ps1.Cong(ps2).Tu, ps1.Cong(ps2).Mau);
            
            nhap Nhap = new nhap();
            PHANSO ps = new PHANSO();
            
            Nhap.nhapSoNguyen();
            int N = Nhap.soNguyenN;

            Console.WriteLine("Nhap phan so muon tinh: ");
            Console.Write("Nhap tu: ");
            ps.Tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            ps.Mau = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong phan so voi so nguyen 3: {0}/{1}", ps.Cong(N).Tu, ps.Cong(N).Mau);
        }
    }
}
