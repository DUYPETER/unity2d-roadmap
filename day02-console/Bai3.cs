using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Nhiệt độ: nhập °C → đổi sang °F. Gợi ý: F = C*9/5 + 32.
    //1.create vari tem,
    //2.create allow (wr) and enter board(readline) tem
    //3.print do f by cong thuc F = C*9/5 + 32
    //check: 0C=32F, 100C=212F
    internal class Bai3
    {
        public static void Run()
        {
            double c = 0;
            Console.WriteLine("Nhập độ C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Độ F là:{c*9/5+32}");
        }
    }
}
