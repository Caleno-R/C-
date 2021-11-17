using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7by7TableDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("The multiplication table for 7 is shown below /n");

            do
            {
                Console.WriteLine("7 * " + i + "  = " + 7 * i);
                i++;
            }
            while (i <= 100);

            Console.ReadKey();

        }
    }
}
