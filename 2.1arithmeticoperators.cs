/*
Operator    Description Examples
+   Add numbers     X=num1+num2
-   Subtract numbers    X=num1-num2
*   Multiply numbers    X=num1*num2
/   Divide numbers  X=num1/num2
%   Divide two numbers and returns reminder     X=22%10 then X will be X=2
*/

using System;
 
namespace Arithmetic_Operators
{
  class Program
   {
     static void Main(string[] args)
      {
        int num1, num2;
        int add, sub, mul;
        float div;
 
        //Accepting Values from users
        Console.Write("Enter first number\t\t");
        num1 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("\n\nEnter second number\t\t");
        num2 = Convert.ToInt32(Console.ReadLine());
 
        //Processing Values
        //Used + operator for adding values
        add = num1 + num2;
        //Used - operator for subtracting values
        sub = num1 - num2;
        //Used * operator for multiplying values
        mul = num1 * num2;
        //Used / operator for dividing values
        div = (float)num1 / num2;
 
        //Displaying Output
        Console.WriteLine("\n\n=====================\n");
        Console.WriteLine("Addition\t\t{0}", add);
        Console.WriteLine("Subtraction\t\t{0}", sub);
        Console.WriteLine("Multiplication\t\t{0}", mul);
        Console.WriteLine("Division\t\t{0}", div);
        Console.WriteLine("\n=======================\n");
 
        Console.ReadLine();           
      }
   }
}
