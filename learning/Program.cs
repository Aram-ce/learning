// See https://aka.ms/new-console-template for more information
using learning;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();


int x;
Console.WriteLine("adad vared konid:");
x = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < x; i += 1)
{

    if (x % i == 0)
    {
        Console.WriteLine("The number is not prime");
       return;
    }
}
Console.WriteLine("The number is prime");
















