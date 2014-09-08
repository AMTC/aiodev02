// The internal access specifier hides its member variables and methods from other classes and objects, that is resides in other namespace. The variable or classes that are declared with internal can be access by any member within application. It is the default access specifiers for a class in C# programming.

using System;
 
namespace Internal_Access_Specifier
{
  class access
   {
     // String Variable declared as internal
     internal string name;
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
        // Accepting value in internal variable
        ac.name = Console.ReadLine();
        ac.print();
        Console.ReadLine();
      }
   }
}
