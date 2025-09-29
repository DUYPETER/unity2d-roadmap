using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //BMI đơn giản: nhập cân nặng(kg), chiều cao(m) → tính BMI (2 chữ số)
    //1. Create weight, height
    //2. create allow (wr) and enter board(readline) weight, height
    //3. print BMI = weight/(height*height)
    //Check: weight=70,height=1.75 -> BMI=22.86
    internal class Bai5
    {
        public static void Run()
        {
            double weight = 0, height = 0;
            Console.WriteLine("Nhập cân nặng (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều cao (m): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Chỉ số BMI là:{Math.Round(weight / Math.Pow(height, 2), 2)}");
        }
    }
}
