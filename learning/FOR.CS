using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class FOR

    {
        public static void SumByFor()
        {
            int sum = 0;
            for (int i= 1; i <= 4; i = i + 1)
            {
                int a;
                Console.WriteLine("adad ravared konid:");
                a= Convert.ToInt32(Console.ReadLine());

                sum += a;
                
            }
            Console.WriteLine("SUM:" + sum.ToString());
        }
    }
}
