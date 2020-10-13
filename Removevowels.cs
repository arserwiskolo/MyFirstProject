using System;

namespace MyFirstProject
{
    public class Removevowels
    {
    public static void Run() {

    Console.WriteLine("Please enter string including letters 'iueao': ");
        
    string input = Console.ReadLine();
    char[] charArr = input.ToCharArray();  //convert to char array
     
    for(int j= 0; j<=charArr.Length-1; j++){
        if(charArr[j] =='e' || charArr[j] =='o' || charArr[j] =='i' || charArr[j] =='u'||charArr[j] =='a'){
        charArr[j] = ' ';}
    }

        string charsStr = new string(charArr); 
        charsStr = charsStr.Replace(" ", String.Empty); 
        Console.WriteLine(charsStr);

        }
    }
}