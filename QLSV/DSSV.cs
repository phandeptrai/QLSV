using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace QLSV
{
    class DSSV
    {
        private ArrayList danhSachSinhVien;

        public DSSV()
        {
            danhSachSinhVien = new ArrayList();
        }
        public void Add(SV sv)
        {
            danhSachSinhVien.Add(sv);
        }
        public void hienThiSV()
        {
            foreach(SV sv in danhSachSinhVien)
            {
                sv.hienThi();
            }
        }
        public void nhapDSSV()
        {
            int d = 0;
            SV sv;
            do
            {              
                Console.WriteLine("1. nhap SVCNTT: ");
                Console.WriteLine("2. Nhap SVVL: ");
                Console.WriteLine("3. Nhap SVVH: ");
                Console.WriteLine("nhap vao lua chon: ");
                d = int.Parse(Console.ReadLine());


                switch (d)
                {
                    case 1:
                        sv = new SVCNTT();
                        sv.nhapSV();
                        break;
                    case 2:
                        sv = new SVVL();
                        sv.nhapSV();
                        break;
                    case 3:
                        sv = new SVVH();
                        sv.nhapSV();
                        break;
                    default:
                        break;


                }
                   


            } while (d == 1 || d == 2 || d == 3);
        }
        public void hienThiSV(double diem)
        {
            foreach (SV sv in danhSachSinhVien)
            {
                if(sv.tinhDiem() > 5)
                {
                    sv.hienThi();
                }
            }
        }
    }
}
