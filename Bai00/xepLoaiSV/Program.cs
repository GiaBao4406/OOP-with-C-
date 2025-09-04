using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xepLoaiSV
{
    public class xepLoaiSinhVien
    {
        /* Attribute
         * Họ tên, MSSV, DTB, xepLoai
         */

        /* Method
         * In thông tin và xếp loại SV
         * DTB >= 8: Giỏi
         * DTB >= 6.5: Khá
         * DTB >= 5: Trung Bình
         * DTB >= 3: Yếu
         * DTB < 3: Kém
         */

        // Khai báo biến
        private string MSSV;
        private string HoTen;
        private float DTB;
        private string xepLoai;

        // get/set
        public string maSV
        {
            get
            { 
                return MSSV; 
            }

            set
            {
                if (value.Length == 12 && value.StartsWith("SV")
                    && value.Substring(2).All(char.IsDigit))
                    MSSV = value;

                else
                    MSSV = "SV00000000";
            }
        }

        public string tenSV
        {
            get;

            set;
        }

        public float diemTB
        {
            get
            { 
                return DTB; 
            }

            set
            {
                DTB = value;
            }
        }

        public string xepLoaiSV
        {
            get
            {
                return xepLoai;
            }

            set
            {
                xepLoai = value;
            }
        }
        // Nhập thông tin
        public void nhapThongTinSV()
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            Console.Write("Nhap ma so sv: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ho ten sv: ");
            tenSV = Console.ReadLine();
            Console.Write("Nhap Diem Trung Binh: ");
            diemTB = float.Parse(Console.ReadLine());
            xepLoaiSv(diemTB);
        }

        // Xếp loại
        private void xepLoaiSv(float diemTB)
        {
            if (diemTB >= 8)
                xepLoaiSV = "Gioi";


            else if (diemTB >= 6.5)
                xepLoaiSV = "Kha";


            else if (diemTB >= 5)
                xepLoaiSV = "Trung binh";

            else if (diemTB > 3)
                xepLoaiSV = "Yeu";

            else
                xepLoaiSV = "Kem";
        }

        public void inThongTinSV()
        {
            Console.WriteLine("THONG TIN SV");
            Console.WriteLine("MSSV: {0}", maSV);
            Console.WriteLine("Ho Ten SV: {0}", tenSV);
            Console.WriteLine("Xep Loai: {0}", xepLoaiSV);

        }
    }

    public class chuongTrinh
    {
        static void Main(string[] args)
        {
            xepLoaiSinhVien phanLoaiSV = new xepLoaiSinhVien();

            phanLoaiSV.nhapThongTinSV();
            phanLoaiSV.inThongTinSV();
        }
    }
}
