using System;

namespace MyFirstProject
{
    public class LeapYear
    {
         public static void Run() {

        Console.WriteLine("Please enter year: ");
        
            string input1 = Console.ReadLine();
            int x=Int32.Parse(input1);

             if ((x % 400) == 0)
                Console.WriteLine("is a leap year.\n", x);
            else if ((x % 100) == 0)
                Console.WriteLine("is not a leap year.\n", x);
            else if ((x % 4) == 0)
                Console.WriteLine("is a leap year.\n", x);
            else
                Console.WriteLine("is not a leap year.\n", x);

        }
    }
}