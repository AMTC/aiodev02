// Throw statement is used for throwing exception in a program. The throwing exception is handled by catch block. You will learn complete about throw statement in Exception handling tutorial.

using System;
 
namespace Throw_statement
{
  class Program
   {
     static void Main(string[] args)
      {
        int num1, num2, result;
 
        Console.WriteLine("Enter First Number");
        num1 = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("Enter Second Number");
        num2 = Convert.ToInt32(Console.ReadLine());

        try
         {
           if (num2 == 0)
            {
              throw new Exception("Can’t Divide by Zero                   Exception\n\n");
            }
           result = num1 / num2;
           Console.WriteLine("{0} / {1} = {2}", num1,                  num2, result);
         }
        catch(Exception e)
         {
           Console.WriteLine("Error : " + e.ToString());
         }
        Console.ReadLine();
      }
   }
}


// When you will execute this code, and input 0 for second input then you will get the “Can’t Divide by Zero Exception” that is raised by throw statements.
