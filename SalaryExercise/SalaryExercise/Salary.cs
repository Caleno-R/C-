using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryExercise
{
    class Salary
    {
        static double basicSalary, allowance, taxRate, taxAmount, netSalary;

        public static void input()
        {
            Console.WriteLine("Enter your salary: ");
            basicSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your allowance: ");
            allowance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: ");
            taxRate = int.Parse(Console.ReadLine());

        }
        public static void compute()
        {
            taxAmount = taxRate / 100 * (basicSalary + allowance);
            netSalary = basicSalary - taxAmount;
        }
        public static void output()
        {
            compute();
            Console.WriteLine("Your net salary is: {0} ", netSalary);
        }
    }
}
