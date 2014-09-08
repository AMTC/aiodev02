// || Operator:It is pronounced as or operator. It also returns true or false based on condition. If any one of the condition matches then it returns true but if both or all the conditions are false then it returns false.

Examples:


using System;
 
namespace Or_operator
{
  class Program
   {
     static void Main(string[] args)
      {   
        string username, userpassword;
 
        label: //Creating label
 
        Console.Write("\n\nEnter your login name:\t");
        username = Console.ReadLine();
 
        Console.Write("Enter your password:\t");
        userpassword = Console.ReadLine();
 
        if ((username == "Steven" || username == "Clark")               && (userpassword == "Steven Clark"))
         {
           Console.WriteLine("\nLogin Successful.");
         }
        else
         {
           Console.WriteLine("\nUnauthorised Access.                   Aborting...");
         }
 
        Console.Write("\n\nPress Y or y for continue.:\t");
        char ans = Convert.ToChar(Console.ReadLine());

        if (ans == 'Y' || ans == 'y')
         {
           goto label; //goto label
         }
        Console.WriteLine("Press  Enter for Aborting...");
        Console.ReadLine();
      }
   }
}
