using System;

namespace MyFirstProject
{
    public class Customer
    {
        // public static void Run() {


    public string FirstName {get; set;} 
    public string LastName {get; set;}
    public long Id{get; set;}
    public string Email{get; set;}
    public DateTime DOB{get; set;}

//Customer c1 = new Customer();
    
   // private static Customer (string FirstName, string LastName, int id, string email, DateTime DOB);


public void PrintGreeting(){
    Console.WriteLine("Welcome "+  FirstName + LastName);;
}

public void SendEmail(string emailAddress){

    //set email server 
    // 
    Console.WriteLine("Email has been sent to " + emailAddress);
}

public int GetAge(DateTime DateOfBirth){
    
    int age = DateTime.Now.Year - DateOfBirth.Year;  
    if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
        age = age - 1; 
        return age;
}



}


    }
