using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuitionFee = 10000;
            int year = 0;
            while (tuitionFee < 20000)
            {
                tuitionFee = tuitionFee * 1.07;
                year++;
            }
            Console.WriteLine("The amount will be doubled in " + year +", years");
            Console.ReadKey();
        }

    }
}
