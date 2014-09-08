// Qu 1:Write a program to demonstrate private access specifier.

using System;
 
namespace Example1
{
  class Program
   {
     private void add()
      {
        int num1, num2, result;
        Console.Write("Enter a number:\t");
        num1 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("\nEnter second number:\t");
        num2 = Convert.ToInt32(Console.ReadLine());
 
        result = num1 + num2;
        Console.WriteLine("{0} + {1} = {2}", num1, num2,           result);
      }
     static void Main(string[] args)
      {
        Program p = new Program();
        p.add(); //It is valid, because private add() is           in same class
        Console.ReadLine();
      }
   }
}
