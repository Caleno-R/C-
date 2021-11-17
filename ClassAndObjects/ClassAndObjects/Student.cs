using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Student
    {
        String regNo, name, gender;
        int age;
        DateTime dob;

        public void getDetails()
        {
            Console.WriteLine("Enter the Registration Number: ");
            regNo = Console.ReadLine();

            Console.WriteLine("Enter the Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the Date of Birth: ");
            dob = DateTime.Parse(Console.ReadLine());


        }
        public int getAge()
        {
            age = DateTime.Now.Year - dob.Year;
            return age;
        }
        public void print() //you cannot use a non static fied in a static environment. 
                            //So all variables and methods have to ALL be static or not static.
        {
            getAge(); //We call this method because we have calculated it

            Console.WriteLine("Your details are: {0}, {1}, {2}, {3}", regNo, name, gender, age);
        }

    }
}
