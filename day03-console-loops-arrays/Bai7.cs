using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Sum & Average: tính tổng, trung bình (2 chữ số).(sai)
    //1.Nhập a, b check int khác continue,sum, average (2 while)
    //2.gán sum=a+b,average=sum/2 
    //3.print sum, average

    internal class Bai7
    {
       public static void Run()
        {
            //1.
            int a = 0, b = 0,sum=0;
            double average = 0;
            string enter = "";
            while (true)
            {
                Console.Write("Nhập số nguyên a: ");
                enter = Console.ReadLine();
                if (int.TryParse(enter, out int g))
                {
                    a = int.Parse(enter);
                    break;
                }
                else continue;
            }
            while (true)
            {
                Console.Write("Nhập số nguyên b: ");
                enter = Console.ReadLine();
                if (int.TryParse(enter, out int g))
                {
                    b = int.Parse(enter);
                    break;
                }
                else continue;
            }
            sum = a + b;
            average = sum / 2.0;
            Console.WriteLine($"Tổng của {a} và {b} là:{sum}");
            Console.WriteLine($"Trung bình cộng của {a} và {b} là:{average}");
        }

    }
}
