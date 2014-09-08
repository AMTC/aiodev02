// Write a program to explain method in C#. Create a static function add() that accept two number from user and returns sum of the number.


using System;
 
namespace Example1
{
  class calculation
   {
     static int num1, num2, result;
     public static void add()
      {
        Console.Write("Enter number 1st.\t");
        num1 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter number 2nd.\t");
        num2 = Convert.ToInt32(Console.ReadLine());
 
        result = num1 + num2;
 
        Console.Write("\nAdd = {0}", result);
        Console.ReadLine();
      }
   }
  class Program
   {
     static void Main(string[] args)
      {
        calculation.add();
      }
   }
}
