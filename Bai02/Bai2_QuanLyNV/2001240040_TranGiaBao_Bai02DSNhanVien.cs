// Bai02DSNV - 2001240040 - Trần Gia Bảo - 15DHTH02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLyNV
{
    public class DSNhanVien
    {
        List<NhanVien> LstNV = new List<NhanVien>();
        public List<NhanVien> lstNV
        {
            get;
            set;
        }

        public void NhapDSNV()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. ", i + 1);
                NhanVien NV = new NhanVien();
                NV.NhapThongTinNV();
                lstNV.Add(NV);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (NhanVien nv in lstNV)
            {
                nv.xuatThongTinNV();
            }
        }

        public double tongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in lstNV)
            {
                tong += nv.tinhLuong();
            }
            return tong;
        }

        public void sapXepNVTangDanTheoNamLam()
        {
            lstNV.Sort((x, y) => x.NamVaoLam.CompareTo(y.NamVaoLam));
        }
    }
}
