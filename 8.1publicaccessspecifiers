//The class member, that is defined as public can be accessed by other class member that is initialized outside the class. A public member can be accessed from anywhere even outside the namespace.

using System;
 
namespace Public_Access_Specifiers
{
  class access
   {
     // String Variable declared as public
     public string name;
     // Public method
     public void print()
      {
        Console.WriteLine("\nMy name is "+name);
      }
   }
 
  class Program
   {
     static void Main(string[] args)
      {
        access ac = new access();
        Console.Write("Enter your name:\t");
        // Accepting value in public variable that is               outside the class
        ac.name = Console.ReadLine();
        ac.print();
 
        Console.ReadLine();
      }
   }
}


