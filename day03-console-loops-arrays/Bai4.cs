using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Đếm chữ số của N — gợi ý: chia 10 liên tiếp với while.
    //create enter, check bool, N,sum,temp=0
    //1.Nhập N>0, check đúng kiểu int
    //2.Gán temp=n;while(temp>0) sum++;
    //3,print số chữ số N = temp
    //check N=1000 3 chữ số
    internal class Bai4
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
            temp = X;
            while (temp > 0)
            {
                temp /= 10;
                sum++;
            }
            Console.WriteLine($"Số chữ số của {X} là: {sum}");
        }

    }
}
