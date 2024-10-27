// See https://aka.ms/new-console-template for more information
using learning;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();
for (; ; )
    
{
    Console.Write("adad vared konid ");
    int num = int.Parse(Console.ReadLine());

    if (IsPrime(num))
    {
        Console.WriteLine($"adad {num} ast");
    }
    else
    {
        Console.WriteLine($"{num} nist");
    }
}


static bool IsPrime(int number)
{


    if (number <= 1) return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}














