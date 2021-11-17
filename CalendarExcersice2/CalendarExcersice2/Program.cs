using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarExcersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            DateTime date;

            Console.WriteLine("Enter Month: ");
            month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt16(Console.ReadLine());

            date = new DateTime(year, month, 1);
            Console.WriteLine("{0} {1} had {2} days", date.ToString("MMMM"), date.Year, DateTime.DaysInMonth(date.Year, date.Month));

            Console.ReadKey();

        }
    }
}
