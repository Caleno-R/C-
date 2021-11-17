using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings s = new Savings(50, 1, 1);
            s.input();
            s.compute();
            s.display();
        }
    }
}
