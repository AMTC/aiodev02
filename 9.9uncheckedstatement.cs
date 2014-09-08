// The unchecked statement ignores the stack overflow exception and executes the program so, the output can be incorrect.

using System;
 
namespace Checked_Statements
{
  class Program
   {
     static void Main(string[] args)
      {
        int num;
        // assign maximum value
        num = int.MaxValue;
        try
         {
           unchecked
            {
              // forces stack overflow exception
              num = num + 1;
              Console.WriteLine(num);
            }
         }
        catch (Exception e)
         {
           Console.WriteLine(e.ToString());
         }
        Console.ReadLine();
      }
   }
}


// Here, the output should be 2147483648 but the output is -2147483648.
