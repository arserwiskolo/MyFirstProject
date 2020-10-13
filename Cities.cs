using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Cities
    {

//public static void Run() {
        // Have a loop that asks a user for a city name on each iteration
            // If the entered city name is between 3 and 30 characters, then add it to a list
            // otherwise, ignore it and continue on gathering city names
            // after the loop, print out the list of cities

            // Can use a list or array
            // Can use a for loop or while loop
        
        public static void MainLists()
        {   
            List<string> CityList = GatherStringInput();

            PrintList(CityList);

           // Console.WriteLine("city list as follows: " + CityList);
        }

        static List<string> GatherStringInput() {
            List<string> theListToReturn = new List<string>();

            while (true) {
                Console.WriteLine("Enter the City Name");
                string userInput = Console.ReadLine();

                if (userInput == "quit") {
                    break;
                }

                string nextString = userInput;
                theListToReturn.Add(nextString);
            }
            return theListToReturn;
        }

         static void PrintList(List<string> listToPrint) {
            Console.WriteLine("----------");
            List<string> listToReturn = new List<string>();
            for (int i = 0; i < listToPrint.Count; i++) {
                if (listToPrint[i].Length <=3 && listToPrint[i].Length >=30){
                   listToReturn.Add(listToPrint[i]);
                   }
                else {}
                Console.WriteLine(listToReturn[i]);
            }
        }
       
        }
    }

