// See https://aka.ms/new-console-template for more information
using learning;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();


int n;
Console.WriteLine("teded adad:");
n = Convert.ToInt32(Console.ReadLine());

int sum=0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"عدد {i + 1} را وارد کنید:");
    int number = Convert.ToInt32(Console.ReadLine());
    sum += number; // جمع کردن اعداد
}

double average = (double)sum / n; // محاسبه میانگین

Console.WriteLine($"sum: {sum}");
Console.WriteLine($"avrage: {average}");
    

    




















