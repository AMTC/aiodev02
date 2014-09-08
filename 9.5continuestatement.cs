// The continue statements enables you to skip the loop and jump the loop to next iteration.

using System;
 
namespace Continue_Statement
{
  class Program
   {
     static void Main(string[] args)
      {
        int i = 0; 
        while(i<10)
         {
           i++;
           if (i < 6)
            {
              continue;
            }    
           Console.WriteLine(i);
         }           
        Console.ReadLine();
      }
   }
}
