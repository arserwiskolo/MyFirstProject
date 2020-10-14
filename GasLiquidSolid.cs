using System;

namespace MyFirstProject
{
    public class GasLiquidSolid
    {
         public static void Run() {

        Console.WriteLine("Please enter temp (Celcius): ");
            
        string TempInput = Console.ReadLine();
        int intTempInput = Int32.Parse(TempInput);
        Console.WriteLine("Please select one substance from the list:  "); 
        var substances = new string []{"1. Water", "2. Helium", "3. Merkury", "4. Ethanol", "5. Carbon Dioxide"};
        var states = new string[]{"Solid", "liquid", "Gas"};
            foreach (string i in substances){
                Console.WriteLine(i);
            }
        string SubsInput = Console.ReadLine();
        int intSubsInput = Int32.Parse(SubsInput);   
        //gas      
        if ((intSubsInput == 1 && intTempInput >100) 
        || (intSubsInput == 2 && intTempInput>=(-268))
        || (intSubsInput == 3 && intTempInput>=440)
        || (intSubsInput == 3 && intTempInput>=500)
        || (intSubsInput == 3 && intTempInput>=5500))
        {
            Console.WriteLine("Your state for the selected temp and substance will be: "+ states[2]);
        } 
        //solid
        else if((intSubsInput == 1 && intTempInput < 0) 
        || (intSubsInput == 2 && intTempInput <-272)
        || (intSubsInput == 3 && intTempInput<-38.83)
        || (intSubsInput == 3 && intTempInput<0)
        || (intSubsInput == 3 && intTempInput< -79))
        {
            Console.WriteLine("Your state for the selected temp and substance will be: "+ states[0]);
        }
    //liquid
        else 
        {
            Console.WriteLine("Your state for the selected temp and substance will be: "+ states[1]);
        }

        }
    }
}