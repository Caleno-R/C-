using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7by7TableWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("The multiplication table for 7 is shown below");

            while (i <= 100)
            {
                Console.WriteLine("7 X " + i + " = " + 7 * i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
