using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ketQuaThi
{
    public class ketQua
    {
        // khai bao
        private string hoTen, soBaoDanh;
        private int namSinh;
        private double diemLT, diemTH;

        public string ketQuaThi()
        {
            if ((diemLT + diemTH > 10) && diemTH >= 2 && diemLT >= 2)
                return "Dau";
            else
                return "Rot";
        }

        public void nhapTTSV()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so bao danh: ");
            soBaoDanh = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem TH: ");
            diemTH = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem LT: ");
            diemLT = double.Parse(Console.ReadLine());
        }
    }

    public class chuongTrinh
    {
        static void Main(string[] args)
        {
            ketQua kqt = new ketQua();
            kqt.nhapTTSV();
            Console.WriteLine("Ket qua: {0}", kqt.ketQuaThi());
        }
    }
}
