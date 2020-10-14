using System;

namespace MyFirstProject
{
    public class AddIntegersBetween
    {
    public static void Run() {

    Console.WriteLine("Please enter first number: ");
        
    string input1 = Console.ReadLine();
    //int x = input; 
    Console.WriteLine("Please enter second number: ");
    string input2 = Console.ReadLine();

    int x=Int32.Parse(input1);
    int y=Int32.Parse(input2);; 
    int sum = 0;

    for (int i=x; i<=y; i++){
	    sum=sum+i;
	    Console.WriteLine(sum);
        }




    }
}
}