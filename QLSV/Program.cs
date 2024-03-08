using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSV a = new DSSV();

            a.nhapDSSV();
            Console.WriteLine("hien thi: ");
            Console.WriteLine("1. danh sach sinh vien: ");
            Console.WriteLine("2. danh sach tot nghiep: ");
            int d = int.Parse(Console.ReadLine());
            switch (d)
            {
                case 1:
                    a.hienThiSV();
                    break;
                case 2:
                    a.DSTN();
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();

        }
    }
}
