// The protected internal access specifier allows its members to be accessed in derived class, containing class or classes within same application. However, this access specifier rarely used in C# programming but it becomes important while implementing inheritance.

using System;
 
namespace Protected_Internal
{
  class access
   {
     // String Variable declared as protected internal
     protected internal string name;
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
        // Accepting value in protected internal variable
        ac.name = Console.ReadLine();
        ac.print();
        Console.ReadLine();
      }
   }
}
