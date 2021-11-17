using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoThis
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Random random = new Random();
                int no = random.Next(100, 1000);

                int x, y, z, rem, sum;
                x = no / 10;
                rem = no % 10;
                y = rem / 10;
                z = rem % 10;
                sum = x + y + z;

                Console.WriteLine("The " +  no +"has the digits " +  x
                +" " +  y
                +" " +  z
                +" and their sum = " +  sum);
            Console.ReadKey();
        }
    }
}
