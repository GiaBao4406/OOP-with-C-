//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaiTap
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            string MaSV, HoTen;
//            double DiemTB;

//            Console.Write("Nhap ma sv: ");
//            MaSV = Console.ReadLine();

//            Console.Write("Nhap ho ten: ");
//            HoTen = Console.ReadLine();

//            Console.Write("Nhap diem trung binh: ");
//            DiemTB = double.Parse(Console.ReadLine());

//            string XepLoai;
//            if (DiemTB >= 8)
//                XepLoai = "Gioi";
//            else if (DiemTB >= 6.5)
//                XepLoai = "Kha";
//            else if (DiemTB >= 5)
//                XepLoai = "Trung Binh";
//            else
//                XepLoai = "Yeu";

//            Console.WriteLine("Ma: {0}\tTen: {1}\tDiemTB: {2}\tXep Loai: {3}",MaSV, HoTen, DiemTB, XepLoai);
//        }
//    }
//}
