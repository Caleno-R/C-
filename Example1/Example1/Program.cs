using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, inputedAnswer, actualAnswer;
            int count = 0;

            Random random = new Random();
            x = random.Next(0, 9);
            y = random.Next(0, 9);

            Console.WriteLine("What is " + x + "+" + y + "?");
            actualAnswer = x + y;
            while (count < 5)
            {
                inputedAnswer = Convert.ToInt32(Console.ReadLine());

                if (inputedAnswer == actualAnswer)
                {
                    Console.WriteLine("Your answer is correct");
                    break;
                }
                else
                {
                    String output = String.Format("Correct answer of {0} + {1} is {2}", x, y, actualAnswer);
                    String msg = count < 4 ? "Invalid. Try again" : output;
                    Console.WriteLine(msg);
                }

                count++;
            }
            //inputedAnswer = Int32.Parse(Console.ReadLine());
            Console.ReadKey();
        }

    }
}
