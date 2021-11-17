using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;

            Console.WriteLine("Enter the weight in pounds: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());

            weight = weight * 0.458559237;
            height = height * 0.0254;

            bmi = (weight * 703) / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if(bmi>18.5 && bmi < 25.0)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi > 25.0 && bmi < 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                
               Console.WriteLine("Obese");
             
            }
            Console.ReadKey();

        }
    }
}
