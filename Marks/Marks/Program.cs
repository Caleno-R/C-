using System;

namespace Marks
{
    class Program
    {
       
        static void Main(string[] args)
       
        {
            string[] names = { "Adim", "Sifuna", "Dottie" };
            int[,] marks = { { 18, 23, 40, 3, 35 }, { 7, 17, 35, 8, 36 }, { 21, 13, 41, 2, 37 } };
            Console.WriteLine("Name\t Cat1\t Cat2 \t Assign1 \t Assign2 \t Exam \t Average \t Grade ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(names[i] + "\t");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(marks[i, j] + "\t");
                }
                Console.WriteLine();
            }
           
        }
    }
}
