// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;
using day03_consoleư;
Console.OutputEncoding = Encoding.UTF8; 
Console.InputEncoding = Encoding.UTF8;  
Console.WriteLine("Hello, World!");
string fullName;
string ho = "Ngô";
string ten = "Duy";
fullName = ho + " " + ten;
//nối chuỗi
Console.WriteLine(string.Concat("Ngô ", "Xuân ", "Duy"));
Console.WriteLine(fullName);
//nối mảng chuỗi
string[] words = { "C#", "là", "ngôn", "ngữ", "hay" };
string sentence = string.Join(" ", words);
Console.WriteLine(sentence); // C# là ngôn ngữ hay
for(int i=0; i< 8; i++)
{
    Console.Write(i);
}
int g = 8;
int h = 0;
//while (true)
//{
//   if( h == g) { 
//         break;
//    } 
//    Console.WriteLine(h);
//    h++;
//}

do
{
    Console.WriteLine(h);
    h--;
} while (h > 0);
int[] a = new int[10];

bool[] flag = { true, false, true, false };
string[] name = new string[3];
name[0] = "Ngô ";
name[1] = "Xuân";
name[2] = "Duy";
for (int i = 0; i < a.Length; i++)
{
    a[i] = i;
}
foreach(int i in a){
       Console.WriteLine(i);
}


foreach(bool i in flag)
{
    Console.WriteLine(i);
}
foreach(string i in name)
{
Console.Write(i+" ");
}
int[] aray = new int[2];
int[] b = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };

//for (int i= 0; i<b.Length;i++)
//{
//    if (i == 2)
//    {
//        b[i] = 100;
//        break;
//    }
//}
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);
}
//while switch-case lựa chọn 1->11, 0 thoát;biến choose để chọn
while (true)
{
    Console.WriteLine("Mời bạn lựa chọn bài tập: 1->11. Chọn 0 để kết thúc");
    int choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 0: return;
        case 1:
            Bai1.Run();
            break;
        case 2:
            Bai2.Run();
            break;
        case 3:
            Bai3.Run();
            break;
        case 4:
            Bai4.Run();
            break;
        case 5:
            Bai5.Run();
            break;
        case 6:
            Bai6.Run();
            break;
        case 7:
            Bai7.Run();
            break;
        case 8:
            Bai8.Run();
            break;
        case 9:
            Bai9.Run();
            break;
        case 10:
            Bai10.Run();
            break;
        case 11:
            Bai11.Run();
            break;
        default:
            Console.WriteLine("Kết thúc chương trình");
            break;
    }
}
