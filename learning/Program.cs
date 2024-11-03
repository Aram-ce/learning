// See https://aka.ms/new-console-template for more information
using learning;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Sum.Sum4Number();
//FOR.SumByFor();
//ForZoj.ForByZoj2();




 
for (int i = 1; i <= 7; i++)
{
    for (int j = 1; j <= 7; j++)
    {
        if (i==j)
            Console.Write(1 + " ");

       else if (i==4)
            Console.Write(1 + " ");
        else if (j==4)
                Console.Write(1 + " ");
        else if (i+j==8)
            Console.Write(1 + " ");
        else

            Console.Write(0 + " ");
    }
    Console.WriteLine();
}
    













