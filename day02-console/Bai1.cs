using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    internal class Bai1
    {
        //Chào & tuổi: nhập tên và tuổi → in “5 năm nữa bạn … tuổi”. Gợi ý: ép kiểu từ chuỗi sang int.
        //1.2 creaate name,age
        //2. create nội suy {name}, {age}(int)
        //3. writeline console
        //check: age=20 --> 20 and 25
        public static void  Run()
        {
            string name = "";
            string age= "0";
            Console.WriteLine("Nhập tên của ban:");
            name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi của ban:");
            age= Console.ReadLine();
            Console.WriteLine($"{name}, {int.Parse(age)}, 5 năm nữa tôi {int.Parse(age) + 5}");
        }
    }
}
