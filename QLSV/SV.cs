using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    abstract class SV
    {
        private string hoTen;
        private string maSV;

       
        public SV()
        {

        }
        public SV(string hoTen,string maSV)
        {
            this.HoTen = hoTen;
            this.MaSV = maSV;
        }
        public virtual void nhapSV()
        {
            Console.WriteLine("nhap vao hoTen: ");
            hoTen = Console.ReadLine();
            maSV = Console.ReadLine();
        }
        public virtual void hienThi()
        {
            Console.WriteLine("hoten : " + hoTen);
            Console.WriteLine("maSV: " + maSV);
        }
        public abstract double tinhDiem();
        protected string HoTen { get => hoTen; set => hoTen = value; }
        protected string MaSV { get => maSV; set => maSV = value; }

    }
}
