using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class NhanVien
    {
        string maNV, hoTen;
        int soNgayCong;
        char xepLoai;
        public static double LuongNgay = 200000;

        public int SoNgayCong
        {
            get
            {
                return soNgayCong;
            }

            set
            {
                if (soNgayCong < 0)
                    value = 0;
                soNgayCong = value;
            }
        }

        public char XepLoai
        {
            get
            {
                if (SoNgayCong > 26)
                    return 'A';
                else if (SoNgayCong >= 22)
                    return 'B';
                else
                    return 'C';
            }
        }

        public NhanVien()
        {
            this.maNV = "QL01";
            this.hoTen = "Bao dep zai";
            this.SoNgayCong = 31;
        }

        public NhanVien(string maNV, string hoTen, int SoNgayCong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.SoNgayCong = SoNgayCong;
        }

        public NhanVien(NhanVien NV)
        {
            this.maNV = NV.maNV;
            this.hoTen = NV.hoTen;
            this.soNgayCong = NV.soNgayCong;
        }

        public double TinhLuong()
        {
            double Luong = SoNgayCong * NhanVien.LuongNgay;
            if (XepLoai == 'A')
                Luong *= 1.05;
            else if (XepLoai == 'B')
                Luong *= 1.02;
            return Luong;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma: ");
            maNV = Console.ReadLine();

            Console.Write("Nhap ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma: {0}\tHo Ten: {1}\tSo ngay cong: {2}\tXep Loai: {3}\tLuong: {4}",maNV, hoTen,SoNgayCong,XepLoai,TinhLuong());
        }
    }
}
