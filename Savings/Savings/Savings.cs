using System;
using System.Collections.Generic;
using System.Text;

namespace Savings
{
    class Savings
    {
        private double saving, amount = 0;
        private double annualrate, months;

        public void input()
        {
            Console.WriteLine("Enter the amount of saving");
            saving = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annualrate");
            annualrate = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of months");
            months = Double.Parse(Console.ReadLine());


        }
        /* Setters and getters */
        public double  P_Saving{ 
            get{ return saving ;}
            set{ saving = value;}

  /* Properties for months and annualrate */

             }
        /* Default Constructor */
        public Savings()
        {
            saving = 50;
            annualrate = 1;
            months = 1;
        }

        /* Parameterized Constructor */
        public Savings(double saving, double annualrate, double months)
        {
            this.saving = saving;
            this.annualrate = annualrate;
            this.months = months;
        }


        public void compute()
        {
            double mrate, i;
            mrate = (annualrate / 100.00) / 12;
            for(i = 1; i <= months; i++)
            {
                amount = (P_Saving + amount) * (1 + mrate);
            }

        
        }
        public void display()
        {
            Console.WriteLine(saving);
            Console.WriteLine(annualrate);
            Console.WriteLine(months);
            Console.WriteLine(amount);
        }




    }
}
