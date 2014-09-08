// The checked statements force C# to raise exception whenever underflow or stack overflow exception occurs due to integral type arithmetic or conversion issues.

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
           checked
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


// This program raises exception while executing because it is using checked statement that prevent the current execution when stack overflow exception appears.
