using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhTron
{
    public class HinhTron
    {
        /* 
         * Atribute: bán kính (double)
         * Method: tính chu vi, tính diện tích
         */

        private double banKinh;

        public double r
        {
            get 
            {
                return banKinh;
            }

            set
            {
                if (value >= 0)
                    banKinh = value;
                //else
                //    throw new ArgumentException("Du lieu khong hop le");
            }
        }

        // nhập bán kính
        public void nhap()
        {
            do
            {
                Console.Write("Nhap ban kinh: ");
                r = double.Parse(Console.ReadLine());
            }
            while (r<0);
        }

        // tính DT
        private double tinhDTHT(double banKinh)
        {
            return Math.PI * r * r;
        }

        // tính CV
        private double tinhCVHT(double banKinh)
        {
            return 2 * Math.PI * r;
        }

        // In ra màn hình
        public void xuat()
        {
            Console.WriteLine("Ban kinh hinh tron: {0}", r);
            Console.WriteLine("Dien tich = {0:0.00}", tinhDTHT(r));
            Console.WriteLine("Chu vi = {0:0.00}", tinhCVHT(r));
        }
    }

    public class ChuongTrinh
    {
        static void Main (string[] args)
        {
            HinhTron ht = new HinhTron();
            ht.nhap();
            ht.xuat();
        }
    }
}
