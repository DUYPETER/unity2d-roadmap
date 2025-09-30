using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //FizzBuzz 1→100 — gợi ý: thứ tự kiểm tra 15, 3, 5.
    //Create N, enter, check bool,
    //1.Nhập N>0, check đúng kiểu int
    //2.For i=1->N if %3==0 print Fizz else if %5==0 Buzz else if %15==0 print FizzBuzz else  print i
    //3.Check N=15 ->1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz
    internal class Bai5
    {
       public static void Run()
        {
            int X = 0, sum = 0, temp = 0;
            string enter = "";
            bool check = false;

            while (check == false)
            {
                Console.Write("Nhập bảng cửu chương X (X>0): ");
                enter = Console.ReadLine();
                check = int.TryParse(enter, out int g) ? int.Parse(enter) > 0 : false;
            }
            X = int.Parse(enter);
            for(int i=1;i<=X;i++)
            {
                if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if(i%15==0) Console.WriteLine("FizzBuzz");
                else Console.WriteLine(i);
            }
        }

    }
}
