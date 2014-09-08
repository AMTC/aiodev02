//Empty statement is used when you no need to perform an operation where a statement is required. It simple transfers control to the end point of the statement. It is also very useful with while loop with blank body and label statements.

using System;
 
namespace empty_statement
{
  class Program
   {
     public bool print()
      {
        Console.WriteLine("Steven Clark");
        return true;
      }
     static void Main(string[] args)
      {
        int i = 0;
        Program p = new Program();
        while (p.print())
         {
           ; //Empty Statement
         }
        Console.WriteLine("i = {0}", i);
        Console.ReadLine();
      }
   }
}


