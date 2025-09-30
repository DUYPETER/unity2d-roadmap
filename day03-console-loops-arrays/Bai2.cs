using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Tổng số lẻ ≤ N — gợi ý: if (i % 2 != 0).
    //1.Create N, creat Sum,Nhập N>0,
    //2.For i=1->i<=N i+=2 (sum+=i)
    //3.Print Sum 
    //4. Check N==11->sum=36
    internal class Bai2
    {
       public static void Run()
        {
            int N=0, sum = 0;
            string enter = "";
            bool check = false;
            while (check == false)
            {
                Console.Write("Nhập số tự nhiên N (N>0): ");
                enter = Console.ReadLine();
                check = int.TryParse(enter, out int g) ? int.Parse(enter) > 0 : false;
            }
            N = int.Parse(enter);
            for(int i = 1; i <= N; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"Tổng các chữ số lẻ bé hơn {N} là: {sum}");
        }

    }
}
