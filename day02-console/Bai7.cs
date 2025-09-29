using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Hoá đơn mini: nhập đơn giá & số lượng → tính tổng + VAT 8%. Gợi ý: định dạng tiền tệ.
    //dongia*soluong*1.08
    //1. create vari dongia, soluong
    //2. create allow (wr) and enter board(readline) dongia, soluong
    //3.print tong tien = dongia*soluong*1.08
    //Check: dongia=100000, soluong=5 -> tong tien=540000
    internal class Bai7
    {
        public static void Run()
        {
            double dongia = 0;
            int soluong = 0;
            Console.WriteLine("Nhập đơn giá: ");
            dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng: ");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng tiền là: {dongia * soluong * 1.08:C}");
        }
    }
}
