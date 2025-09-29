///* See https://aka.ms/new-console-template for more information*/
using System.Globalization;
using day02_console; 
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding= Encoding.UTF8;
//Console.WriteLine("Hello, World!");
//int age = 7;
//string gioiThieu=$"Tôi tên là An, tôi {age} tuổi";
//char d=(char)64;
//string json = @"

//  ""Name"": ""John Doe"",
//  ""Age"": 30
//";
//int a ;
//string thu = """Xin \n chào""";
//double ho = 1.2343d;
//Console.WriteLine(d);
//Console.WriteLine(json);
//Console.WriteLine(thu);
//Console.WriteLine(gioiThieu);
//Console.WriteLine(ho);
//double x = 3.9;
//int c=(int)x;
//int n = 4200;
//double r = 0.12345;
//string s1 = n.ToString();                            // "4200"
//string s2 = r.ToString("F3", CultureInfo.InvariantCulture); // "0.12" (2 chữ số thập phân)
//string s3 = n.ToString("N0", CultureInfo.InvariantCulture); // "4,200"
//int n3 = Convert.ToInt32(null);
//Console.WriteLine(int.TryParse("123",out int n2));
//long df = 123456789012345;
//int g = (int)df;
//Console.WriteLine(s2);
//Console.WriteLine(n3
//int g1;
string hex = "abc";
int? checkd=int.TryParse(hex,out int l)?l:(int?)null;
int a = 5;
int b = 3;
Console.WriteLine(true && false);
//4
Console.WriteLine(int.TryParse("abc",out int i));
//5
string noisuy = $"đây là chuôi nội suy{4.23}";
Console.WriteLine(noisuy);
//6. 
const double pi = 3.14;

Console.WriteLine(pi);
//Bài tập
//Tạo switch gọi bài tập
//1. allow ( chọn 1->8 chạy ,0 thoát)

while (true)
{
    Console.WriteLine("Chọn bài tập (1-8), 0 để thoát:");
    string choose = "0";
    Console.WriteLine("Nhập lựa chọn của bạn: ");
    choose = Console.ReadLine();
    switch(choose){
        case "1":
        Bai1.Run();
        break;
            case "2":  Bai2.Run(); break;
            case "3":  Bai3.Run(); break;
            case "4":  Bai4.Run(); break;
            case "5":  Bai5.Run(); break;
            case "6":  Bai6.Run(); break;
            case "7":  Bai7.Run(); break;
            case "8":  Bai8.Run(); break;
        case "0":return;
    }
}

