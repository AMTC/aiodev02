//Qu2:Write a program in which accept two argument as parameter from the user and returns four output value as add, subtract, multiplication and division.

using System;
 
namespace Example2
{
  class Program
   {
     public static void parameter(int num1, int num2,            out int add, out int sub, out int mul, out float div)
      {
        add = num1 + num2;
        sub = num1 - num2;
        mul = num1 * num2;
        div = (float)num1 / num2;
      }
     static void Main(string[] args)
      {
        int num1,num2;
        int add, sub, mul;
        float div;
        Console.Write("Enter 1st number\t");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter 2nd number\t");
        num2 = Convert.ToInt32(Console.ReadLine());
 
        Program.parameter(num1, num2, out add, out sub,              out mul, out div);
        Console.WriteLine("\n\n{0} + {1} = {2}", num1,              num2, add);
        Console.WriteLine("{0} - {1} = {2}", num1, num2,            sub);
        Console.WriteLine("{0} * {1} = {2}", num1, num2,            mul);
        Console.WriteLine("{0} / {1} = {2}", num1, num2,            div);
 
        Console.ReadLine();
      }
   }
}


