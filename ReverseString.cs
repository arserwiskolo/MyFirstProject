using System;

namespace MyFirstProject
{
    public class ReverseString
    {
         public static void Run() {

            string str = "", reverse = "";  
            int wordlenght = 0;  
            Console.WriteLine("Enter a Word");  
            
            str = Console.ReadLine();  
              
             wordlenght = str.Length; 
             for(int i = wordlenght-1; i >= 0; i--){
                  reverse = reverse + str[i];  
              
             } 
            //while(wordlenght>=0)  
           // {  
            //    reverse = reverse + str[wordlenght];  
            //    wordlenght--;  
           // }  
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}",reverse);  
            Console.ReadLine();
            

        }
    }
}