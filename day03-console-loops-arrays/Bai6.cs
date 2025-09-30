using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Nhập mảng: nhập n, rồi nhập n số; in lại theo cùng thứ tự và ngược.
    //1.Create number arry,enter,check bool
    //2.Create array,Nhập phần tử mảng(check kiểu dữ liệu),(tái sử dụng enter  để check dữ liệu nhập cho từng phần tử) 
    //2.1.continue use While to check elements of arr if(false) continue else gán and tăng i
    //3.Print array xuôi and ngược for-(cú pháp đảo mảng)
    //4.Check array[3,5,7,9] and array[9,7,5,3]
    internal class Bai6
    {
       public static void Run()
        {
            //1
            int X = 0 ;
            string enter = "";
            bool check = false;
            int[] a;

            while (check == false)
            {
                Console.Write("Nhập bảng cửu chương X (X>0): ");
                enter = Console.ReadLine();
                check = int.TryParse(enter, out int g) ? int.Parse(enter) > 0 : false;
            }
            X = int.Parse(enter);
            a = new int[X];
            int h = 0;
            //2
            while (h<=a.Length)
            {
                Console.WriteLine($"Nhập giá trị nguyên phần tử thứ {h} của mảng:");
                enter = Console.ReadLine();
                if (!int.TryParse(enter, out int g)) continue;
                else
                {
                    a[h] = int.Parse(enter);
                    h++;
                }
            }
            //3
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            //đảo mảng
            a.Reverse();
            foreach(int i in a)
            {
                Console.Write(i + " ");     
            }
        }
    }
}
