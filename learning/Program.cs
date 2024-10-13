// See https://aka.ms/new-console-template for more information
using learning;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();
int d;
int m;
Console.WriteLine("day:");
d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("month:");
m = Convert.ToInt32(Console.ReadLine());
if (m<=6)
    Console.WriteLine(((m-1)*31)+d);
else 

    Console.WriteLine(((m-1)*30+d));





