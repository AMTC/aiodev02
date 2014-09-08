/*
In C# programming the Main method is where program starts execution. It is the main entry point of program that executes all the objects and invokes method to execute. There can be only one Main method in C#. However, the C# Main method can be void or int return type. It must be inside a class or struct and must be declared with static modifier. It is the main place where a program starts the execution and end. The Main method can have a parameter and these parameters are known as zero-indexed command line argument.

Why main method is always declared with static?

The Main method in C# is always declared with static because it can’t be call in other method of function. The Main method instantiate other objects and variables but there is no any method there that can instantiate main method in C#. On other hand, the main method doesn’t accept parameter from any other function. It only takes parameter as argument via command line argument.
*/

using System;
 
namespace Main_Method
{
  class check
   {
     float num, percent;
     public void accept()
      { 
        Console.Write("\nEnter your marks. (Total                   Mark = 850):\t");
        num = float.Parse(Console.ReadLine());
      }
     public void print()
      {        
        percent = (float)num / 850 * 100;
        if (percent < 35)
         {
           Console.WriteLine("Sorry!!! You are fail.                   your marks is "+percent);
         }
        else if (percent > 35 && percent < 50)
         {
           Console.WriteLine("You got grade D and                       your percentage marks is " + percent);
         }
        else if (percent > 50 && percent < 60)
         {
           Console.WriteLine("You got grade C and you                   percentage marks is " + percent);
         }
        else if (percent > 60 && percent < 75)
         {
           Console.WriteLine("You got grade B and your                 percentage marks is " + percent);
         }
        else
         {
           Console.WriteLine("You got grade A and your                 percentage marks is " + percent);
         }
      }
   }
 
  class Program
   {
     static void Main(string[] args)
      {
        // Starting execution
        // Creating object of class check
        check chk = new check();
        chk.accept(); //Invoking accept method
        chk.print(); //Invoking print method
        Console.ReadLine();
      }
   }
}
