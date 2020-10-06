using System;

namespace MyFirstProject
{
    public class QuizHint
    {
         public static void Run() {

        decimal ticketPrice = 0m;
           //int studentCardNo = 0;
        Console.WriteLine("Please enter an age: ");
        
        string givenAge = Console.ReadLine();
        int convertedAge = Int32.Parse(givenAge);

        Console.WriteLine("Please enter student card ID: ");
        string givenStudentCardid = Console.ReadLine();
        int convertedStudentCardid = Int32.Parse(givenStudentCardid);

        DateTime dt = DateTime.Now;
        string weekday = dt.ToString("dddd");    
        int decimalNumber = Convert.ToInt32(givenAge);

        //ticket price vs age
        if (convertedAge < 5){
            ticketPrice = 0.00m;
            }
        else if (convertedAge > 5 && convertedAge < 14){
            ticketPrice = 7.99m;
            }
        else if (convertedAge >14 && convertedAge < 65){
            ticketPrice = 11.99m;
            }
        else if (convertedAge > 65){
            ticketPrice = 9.99m;
            }

        //student card and day logic
        if (weekday == "Tuesday"){
            ticketPrice = ticketPrice/2;
            Console.WriteLine("Because today is : " + weekday + " you are paying half price for a ticket.");
            }
        if (convertedStudentCardid != 0){
            ticketPrice  = ticketPrice -1;
            Console.WriteLine("Because you are student you are paying reduced price for a ticket.");
            }

        Console.WriteLine("The ticket price is: " + ticketPrice);
        Console.WriteLine("Today is: " + weekday);

        }
    }
}