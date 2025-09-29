using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_console
{
    //Tiết kiệm: nhập gốc, lãi %/năm, năm → tính lãi đơn & lãi kép.
    //lãi đơn: tiền lãi = gốc * lãi suất * thời gian
    //lãi kép: tiền lãi =gốc*(1+lãi suất)^so năm-gốc
    //1. create vari goc, laiSuat, nam
    //2. create allow (wr) and enter board(readline) goc, laiSuat, nam
    //3. print lãi đơn goc*laiSuat*nam và lãi kép goc*(Math.Pow((1+laiSuat),nam)-goc)
    //Check: goc=1000000, laiSuat=8%, nam=5 -> lãi đơn=400000, lãi kép=469328.97
    internal class Bai6
    {
        public static void Run()
        {
            double goc = 0, laisuat = 0;
            int sonam = 0;
            Console.WriteLine("Nhập số tiền gốc: ");
            goc = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất (%/năm): ");
            laisuat = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("Nhập số năm: ");
            sonam = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tiền lãi đơn là:{goc * laisuat * sonam}");
            Console.WriteLine($"Tiền lãi kép là:{goc * Math.Pow((1+laisuat),sonam)-goc}");
        }
    }
}
