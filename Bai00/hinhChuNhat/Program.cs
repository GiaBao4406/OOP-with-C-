using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hinhChuNhat
{
    public class HCN
    {
        /*
         * Attribute: chiều dài, chiều rộng (double)
         * Method: tính diện tích, tính chu vi
         */

        private double chieuDai;
        private double chieuRong;

        public double CD
        {
            get
            {
                return chieuDai;
            }

            set
            {
                if (value > chieuRong && value >0)
                    chieuDai = value;
                else
                    throw new ArgumentException("Chieu dai phai lon hon chieu rong!");
            }
        }

        public double CR
        {
            get
            {
                return chieuRong;
            }

            set
            {
                if (value > 0)
                    chieuRong = value;
                else
                    throw new ArgumentException("Du lieu khong hop le");
            }
        }
        
        // Nhap chieu dai, chieu rong
        public void nhap()
        {
            Console.Write("Nhap chieu rong: ");
            CR = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            CD = double.Parse(Console.ReadLine());
        }

        private double tinhDT(double CD, double CR)
        {
            return CD * CR;
        }

        private double tinhCV(double CD, double CR)
        {
            return (CD + CR)*2;
        }

        public void xuat()
        {
            Console.WriteLine("Nhap chieu rong: {0}", CR);
            Console.WriteLine("Nhap chieu dai: {0}", CD);
            Console.WriteLine("Dien tich = {0}\nChu vi = {1}", tinhDT(CD,CR), tinhCV(CD, CR));
        }
    }

    public class chuongTrinh
    {
        static void Main(string[] args)
        {
            HCN hcn = new HCN();
            hcn.nhap();
            hcn.xuat();
        }
    }
}
