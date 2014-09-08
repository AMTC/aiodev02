using System;
 
namespace Protected_Specifier
{
  class access
   {
     // String Variable declared as protected
     protected string name;
     public void print()
      {
        Console.WriteLine("\nMy name is " + name);
      }
   }
 
  class Program : access // Inherit access class
   {
     static void Main(string[] args)
      {
        Program p=new Program();
        Console.Write("Enter your name:\t");
        p.name = Console.ReadLine(); // No Error!!
        p.print();
        Console.ReadLine();
      }
   }
}
