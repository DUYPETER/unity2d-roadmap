using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //In 1→N (N nhập từ bàn phím) — gợi ý: for.
    //1.Nhập N từ bàn phím (Kiểm tra đúng kiểu int ,>0)-while,crete N
    //2.For in N số
    //check N=10 ->1_> 10 ,KDL khác nhập lại
    internal class Bai1
    {
       public static void Run()
        {
            string enter="";
            int N;
            bool check = false;
            while (check==false)
            {
                Console.WriteLine("Nhập N (N>0): ");
                enter=Console.ReadLine();
                check = int.TryParse(enter, out int g)?int.Parse(enter)>0:false; 

            }
            N = int.Parse(enter);
            for(int i = 1; i <= N; i++)
            {
                Console.Write(i+" ");
            }
        }

    }
}
