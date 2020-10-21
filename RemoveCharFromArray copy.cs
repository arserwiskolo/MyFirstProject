using System;

namespace MyFirstProject
{
    public class RemoveCharFromArray
    {
    public static void Run() {

     string  [] x= {"[156565]","[27878787]", "[37878766655687]","[4789898878787]","[578787989898987]"}; 
     // char [] charArr = x.ToUpper().ToCharArray();
        //char [] charArr2 = y.ToLower().ToCharArray();
        
        int a = x.Length;
        //int b = charArr2.Length;
             
        string [] result = new string [a];
        //if (a!=b){
           //Console.WriteLine("Strings are not equal in lenght. ");  }
       // else {
            for(int i = 0; i<a; i++){
                
                result [i] = x[i] ;
                //Console.WriteLine(result[i]);
                if (result[i].Contains("[")  ){
                    result[i]= result[i].Replace("[", string.Empty);}

                if (result[i].Contains("]")  )
                    result[i]= result[i].Replace("]", string.Empty); 
                    Console.WriteLine(result[i]);
                };
            string output = string.Join(",", result);
            Console.WriteLine($"RESULT: {output}");

            }
    }
}