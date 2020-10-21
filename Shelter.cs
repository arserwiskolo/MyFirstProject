using System;

namespace Unit3Examples
{
    /*
    Challenge:
    - 1. Add a data member for a unique Id to the Movie class
    - 2. Add a data member for a collection of numerical ratings
    - 3. Add a constructor that initializes all the data members of a movie
    - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
    - 5. Add a mechanism that allows you to get the average rating of a movie
    */
    public class Shelter {
        public string Animal{get; set;}

        public string Rase { get; set; }
        public string Size { get; set; }
        public Boolean HealthChecked{get; set;}
        public int Age { get; set; }
        public int Characteristics{get; set;}

        //methods
        //public void RateMovie(int rating){
            //Console.WriteLine("Please rate your movie using number from 1 - Bad, 2 - Could be better, 3 - Decent, 4 - Good  to 5 - Excellent");
            //string input = Console.ReadLine();
           // int x=Int32.Parse(input);   
           // Rating = rating;
           // //return Rating;
        //}

        // public float GetAverageRating(){
        //     return 0f;
        // }
        // public void PrintDetails() {
        //     Console.WriteLine($"Movie Title: {Title}");
        //     Console.WriteLine($"Director: {Director}");
        //     Console.WriteLine($"Year: {Year}\n");
        //     Console.WriteLine($"Rating: {Rating}\n");
        // }
    }

}
