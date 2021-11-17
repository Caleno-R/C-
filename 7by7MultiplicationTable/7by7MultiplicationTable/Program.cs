using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7by7MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("The multiplication table for 7 is as below");

            for (i = 0; i <= 100; i++)
            {
                Console.WriteLine("7 x " + i + " = " + 7 * i);
            }
            Console.ReadKey();
        }
    }
}
