// The protected access specifier hides its member variables and functions from other classes and objects. This type of variable or function can only be accessed in child class. It becomes very important while implementing inheritance.

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
 
  class Program
   {
     static void Main(string[] args)
      {
        access ac = new access();
        Console.Write("Enter your name:\t");
        // raise error because of its protection level
        ac.name = Console.ReadLine();
        ac.print();
        Console.ReadLine();
      }
   }
}
