// The goto statement is a jump statement that controls the execution of the program to another segment of the same program. You create label at anywhere in program then can pass the execution control via the goto statements.

using System;
 
namespace goto_statement
{
  class Program
   {
     static void Main(string[] args)
      {
        string name;
 
        label: //creating label with colon(:)
 
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();
 
        Console.WriteLine("Welcome {0}", name);
 
        goto label; //jump to label statement           
      }
   }
}
