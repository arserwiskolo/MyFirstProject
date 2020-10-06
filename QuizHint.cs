using System;

namespace MyFirstProject
{
    public class QuizHint
    {
         public static void Run() {

        decimal ticketPrice = 0m;
        Console.WriteLine("Please enter an age: ");
        string givenAge = Console.ReadLine();
        int convertedAge = Int32.Parse(givenAge);

        int decimalNumber = Convert.ToInt32(givenAge);
           
        if (convertedAge < 5)
            ticketPrice = 0.00m;
        else if (convertedAge > 5 && convertedAge < 14)
            ticketPrice = 7.99m;
        else if (convertedAge >14 && convertedAge < 65)
            ticketPrice = 11.99m;
        else if (convertedAge > 65)
            ticketPrice = 9.99m;

        Console.WriteLine("The ticket price is: " + ticketPrice);

        }
    }
}