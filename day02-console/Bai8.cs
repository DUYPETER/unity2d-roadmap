using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Hoán đổi biến: nhập a, b → hoán đổi. Gợi ý: dùng biến tạm hoặc phép cộng/trừ.
    //1. create vari a,b,temp
    //2. a=temp,a=b,b=temp
    //3.print a,b
    //Check: a=5,b=10 -> a=10,b=5
    internal class Bai8
    {
        public static void Run()
        {
            double a = 0, b = 0, temp = 0;  
            Console.WriteLine("Nhập a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b=double.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b=temp;
            Console.WriteLine($"a={a},b={b}");
        }
    }
}
