using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLSV
{
    class SVVH : SV
    {
        private string chuyenNganh;
        private ArrayList danhSachMH = new ArrayList();
        public SVVH()
        {

        }
        public SVVH(string hoTen, string maSV, string chuyenNganh) : base(hoTen, maSV)
        {
            this.chuyenNganh = chuyenNganh;
        }
        public override void nhapSV()
        {
            base.nhapSV();
            Console.WriteLine("nhap vao chuyenNganh: ");
            chuyenNganh = Console.ReadLine();
            danhSachMH.Add(new MonHoc("VH co dien"));
            danhSachMH.Add(new MonHoc("Vh hien dai"));
            foreach (MonHoc item in danhSachMH)
            {
                item.nhapMonHoc();
            }

        }
        
        public override double tinhDiem()
        {
            int soTinChi = 0;
            double diem = 0;
            foreach (MonHoc item in danhSachMH)
            {
                soTinChi += item.SoTinChi;
                diem += item.Diem * item.SoTinChi;
            }
            return diem / soTinChi;
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("diemTB: " + tinhDiem());

        }
    }
}
