/*
The Reference type variable is such type of variable in C# that holds the reference of memory address instead of value. class, interface, delegate, array are the reference type. When you create object of particular class with new keyword, a space is created in the managed heap that holds the reference of classes.

If you are passing reference type variable as parameter, then you will have to use ref keyword with variable. 
*/

using System;
 
namespace Reference_Parameter
{
  class Program
   {
     public static void qube(ref int num)
      {
        num = num * num * num;
      }
     static void Main(string[] args)
      {
        int original = 9;
        Console.Write("\ncurrent value of Original is               {0}\t", original); 

        Program.qube(ref original);
        Console.WriteLine("\nNow the current value of               Original is {0}\t", original);
        Console.ReadLine();
      }
   }
}
