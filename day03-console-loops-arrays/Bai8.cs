using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_consoleư
{
    //Max & vị trí đầu tiên: in giá trị lớn nhất và index đầu tiên của nó.
    //1.create array, temp=arr[0],index=0;
    //2.for i=1--> a.lenghth-1 if arr[i]>temp temp=arr[i] ,inex=i
    //3. print max and index 
    //check arr[3,5,7,9,11,5] max=9,index=4;
    internal class Bai8
    {
        public static void Run()
        {
            //1.
            int[] a = { 3, 5, 7, 9, 11, 5 };
            int temp = a[0];
            int index = 0;
                //2.
                for(int i = 1; i < a.Length; i++)
            {
                if (a[i] > temp)
                {
                    temp = a[i];
                    index = i;
                }
            }
                //3.
                Console.WriteLine($"Max = {temp}, index = {index}");

        }
    }
}
