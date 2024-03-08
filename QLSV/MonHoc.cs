using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class MonHoc
    {
       private string tenMH;
       private int soTinChi;
       private double diem;

        public MonHoc(string tenMH)
        {
            this.tenMH = tenMH;
        }
        public MonHoc(string tenMH,int soTinChi,double diem)
        {
            this.TenMH = tenMH;
            this.SoTinChi = soTinChi;
            this.Diem = diem;
        }
        public void nhapMonHoc()
        {
            Console.WriteLine("nhap vao soTinChi  " + tenMH+": ");
            soTinChi = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao diem: "+ tenMH + ": ");
            diem = double.Parse(Console.ReadLine());
        }

        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public double Diem { get => diem; set => diem = value; }
    }
}
