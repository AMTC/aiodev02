using System;
 
namespace First_c_sharp_code
{
  class Program
   {
     static void Main(string[] args)
      {
        string name; //Variable for storing string value
 
        //Displaying message for entring value
        Console.WriteLine("Please Enter Your Good Name");
 
        //Accepting and holding values in name variable
        name = Console.ReadLine();
 
        //Displaying Output
        Console.WriteLine("Welcome {0} in your first                csharp program", name);
 
        //Holding console screen
        Console.ReadLine(); 
      }
   }
}
