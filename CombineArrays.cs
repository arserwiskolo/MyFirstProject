using System;

namespace MyFirstProject
{
    public class CombineArrays
    {
         public static void Run() {

        Console.WriteLine("Please enter First Word: ");
        string x = Console.ReadLine();
        
        Console.WriteLine("Please enter Second Word: ");
        string y = Console.ReadLine();//.ToLower();
        
        char [] charArr = x.ToUpper().ToCharArray();
        char [] charArr2 = y.ToLower().ToCharArray();
        
        int a = charArr.Length;
        int b = charArr2.Length;
             
        string [] result = new string [a];
        if (a!=b){
           Console.WriteLine("Strings are not equal in lenght. ");  }
        else {
            for(int i = 0; i<a; i++){
                
                result [i] = charArr[i] + "-" + charArr2[i];
                Console.WriteLine(result[i]);
                }
            string output = string.Join("-", result);
            Console.WriteLine($"RESULT: {output}");

        }
    }
}
}