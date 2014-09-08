// The break statement is used to terminating the current flow of program and transfer controls to the next execution.

using System;
 
namespace break_statement
{
  class Program
   {
     static void Main(string[] args)
      {
        int i = 0;
 
        while (i < 100)
         {
           Console.WriteLine(i);
           if (i == 20)
            {
              Console.WriteLine("breaking the current                     segment...");
              break;
            }
           i++;
         }  
        Console.ReadLine();
      }
   }
}
