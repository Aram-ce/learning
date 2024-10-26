using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class ForZoj
    {
        public static void ForByZoj()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void ForByZoj2()
        {
            int x;

            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= x; i+= 2)
            {
                Console.WriteLine(i);
            }






        }
    }
}