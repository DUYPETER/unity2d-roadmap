using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Diện tích & chu vi hình chữ nhật: nhập w, h.
    //1. create vari w,h
    //2. create allow (wr) and enter board(readline) w,h
    //3. print diện tích (w*h) và chu vi 2*(w+h)
    //Check: w=3,l=4 -> dt=12,cv=14
    internal class Bai4
    {
        public static void Run()
        {
            double w = 0, l = 0;
            Console.WriteLine("Nhập chiều rộng: ");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dai: ");
            l = double.Parse(Console.ReadLine());
            Console.WriteLine($"Diện tích là: {w * l}, Chu vi là: {2 * (w + l)}");
        }
    }
}
