using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Đổi thời gian: nhập số giây → in HH:MM:SS. Gợi ý: dùng % và /.
    //h=giay/3600, m=(giay%3600)/60,s=giay%60
    //1. create vari giay,h,m,s
    //2. create allow (wr) and enter board(readline) giay
    //3. print h:m:s
    //Check: giay=3661 -> 1:1:1
    internal class Bai2
    {
        public static void Run()
        {
            int giay = 0, h = 0, m = 0, s = 0;
            Console.WriteLine("Nhập số giây:");
            giay = int.Parse(Console.ReadLine());
            h = giay / 3600;
            m=(giay%3600)/60;
            s = giay % 60;
            Console.WriteLine($"{h}::{m}::{s}");
        }
    }
}
