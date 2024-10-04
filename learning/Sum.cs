using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Sum
    {
        public static void Sum4Number()
        {
            int a, b, c, d;
            Console.WriteLine("adad1 vared konid:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adad2 vared konid:");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adad3 vared konid:");
            c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adad4 vared konid:");
            d=Convert.ToInt32(Console.ReadLine());
            int Sum=a+b+c+d;
            Console.WriteLine("SUM:"+Sum.ToString());

        }
    }
}
