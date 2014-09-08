// The private access specifiers restrict the member variable or function to be called outside from the parent class. A private function or variable cannot be called outside from the same class. It hides its member variable and method from other class and methods. However, you can store or retrieve value from private access modifiers using get set property. You will learn more about get set property in lateral chapter.

using System;
 
namespace Private_Access_Specifiers
{
  class access
   {
     // String Variable declared as private
     private string name;
     public void print() // public method
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
