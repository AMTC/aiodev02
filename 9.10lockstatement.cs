The lock statement handle lock segment as a critical section and lock the object during the execution of program from other thread. Once the execution is completed it releases the lock and frees objects.
Example:


using System;
 
namespace Lock_Statement
{
  class Program
   {
     public void printname()
      {
        Console.WriteLine("My name is Steven Clark");
      }
 
     static void Main(string[] args)
      {
        Program p = new Program();
        // creating lock segment. all the resources that          is used in lock segment, can't be used by another           thread until it releases.
        lock (p)   
         {
           p.printname();
         }
        Console.ReadLine();
      }
   }
}
