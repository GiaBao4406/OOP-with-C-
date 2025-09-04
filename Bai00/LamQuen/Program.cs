using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamQuen
{
    
    public class TinhGiaTriAB
    {
     // Attribute
        // Khai báo biến
        private float a, b;

     // Method
        // get/set
        public float bienA
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public float bienB
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }
        // Hàm nhập 2 số a,b
        public void nhapGiaTriAB()
        {
            Console.WriteLine("Ban hay nhap gia tri a,b:");
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
        }

        // Tính tổng a,b
        public float tinhTongAB(float a, float b)
        {
            return a + b;
        }

        // Tính hiệu a,b
        public float tinhHieuAB(float a, float b)
        {
            return a - b;
        }

        // Tính thương a,b
        public float tinhThuongAB(float a, float b)
        {
            return a / b;
        }

        // Tính tích a,b
        public float tinhTichAB(float a, float b)
        {
            return a * b;
        }
        
    }

    public class chuongTrinh
    {
        static void Main(string[] args)
        {
            // Khai báo
            TinhGiaTriAB tinh = new TinhGiaTriAB();

            // Nhập A,B
            tinh.nhapGiaTriAB();

            // In ra tổng, hiệu, tích, thương
            Console.WriteLine("A = {0} và B = {1}", tinh.bienA, tinh.bienB);
            Console.WriteLine("Tong = {0}", tinh.tinhTongAB(tinh.bienA, tinh.bienB));
            Console.WriteLine("Hieu = {0}", tinh.tinhHieuAB(tinh.bienA, tinh.bienB));
            Console.WriteLine("Tich = {0}", tinh.tinhTichAB(tinh.bienA, tinh.bienB));
            Console.WriteLine("Thuong = {0:0.00}", tinh.tinhThuongAB(tinh.bienA, tinh.bienB));
            Console.ReadLine();

        }
    }
}
