// See https://aka.ms/new-console-template for more information
using learning;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();



Console.Write("adad vared konid ");
int x = int.Parse(Console.ReadLine());


for (int i = 2; i <= x; i++)
{
    if (IsPrime(i))
        Console.WriteLine(i + " adad aval hast");


}
bool IsPrime(int a)
{

    for (int j = 2; j < a; j++)
    {
        if (a % j == 0)
            return false;
    }
    return true;
}



















