using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student std = new Student();
            std.getDetails();
            std.print();*/

            //when you use the static keyword in the other class, do not create an object.
            //Simply use the class name and methods as:
            //Student.getDetails();
            //Student.print();

            int a, b, c;
            Console.WriteLine("Enter the value of a, b, c: ");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            ByValByRef.alterValues(ref a, ref b,ref c); //By ref
            //ByValByRef.alterValues(ref a, ref b,ref c); By val

            Console.WriteLine("Your Values are: {0}, {1}, {2} ", a, b, c);



            Console.ReadKey();

        }

    }
}
