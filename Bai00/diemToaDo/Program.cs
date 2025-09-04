using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diemToaDo
{
    public class toaDo
    {
        // Toa do x,y
        private double x, y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double tinhKhoangCach(double X, double Y)
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public void nhapToaDo()
        {
            Console.Write("Nhap toa do x: ");
            X = double.Parse(Console.ReadLine());

            Console.Write("Nhap toa do y: ");
            Y = double.Parse(Console.ReadLine());
        }
    }

    public class chuongTrinh
    {
        static void Main(string[] args)
        {
            toaDo dtd = new toaDo();

            dtd.nhapToaDo();
            Console.WriteLine("Khoang cach x,y den toa do O = "+dtd.tinhKhoangCach(dtd.X,dtd.Y));
        }
    }
}


   