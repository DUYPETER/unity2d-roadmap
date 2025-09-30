using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Bảng cửu chương của X — gợi ý: chạy i=1..9.
    //1.Create X, Nhập X(check đúng kiểu int),st enter,bool check,g save bảng ht
    //2.while ngoài check g<=x allow bcc g,For con i=1->i<=9 (print X*i)
    //3.check 5->hiện 5 bảng cửu chương  
    internal class Bai3
    {
       public static void Run()
        {

            int X = 0, sum = 0;
            string enter = "";
            bool check = false;
            
            while (check == false)
            {
                Console.Write("Nhập bảng cửu chương X (X>0): ");
                enter = Console.ReadLine();
                check = int.TryParse(enter, out int g) ? int.Parse(enter) > 0 : false;
            }
            X = int.Parse(enter);
            int h = 1;
            while (h <= X)
            {
                Console.WriteLine($"Bảng cửu chương {h}:");
                for(int i = 1; i <= 9; i++)
                {
                    Console.WriteLine(i * h);
                }
                h++;
            }


        }

    }
}
