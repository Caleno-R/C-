using System;
class Class1
{
    static void Main(String[] args)
    {
        Random random = new Random();
        int no = random.Next(100, 1000);

        int x, y, z, rem, sum;
        x = no / 10;
        rem = no % 10;
        y = rem / 10;
        z = rem % 10;
        sum = x + y + z;

        Console.WriteLine("The " + { no} +"has the digits " + { x} +" " + { y} +" " + { z} +" and their sum = " + {sum});
        Console.ReadKey();

    }
}

