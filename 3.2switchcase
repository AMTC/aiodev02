/*
1.  Must include break statement in each case and default statements.

2.  If you are accepting char value then write it within single quotes as follow:
case ‘1’, case ‘b’, case ‘c’, case ‘k’ etc.

3.If you are accepting string value then write it within double quotes as follow:
case “add”, case “sub”, case “mul”, case “div” etc.
*/

using System;
 
namespace Switch_Case
{
  class Program
   {
     static void Main(string[] args)
      {
        int opt, num1, num2;
        float result;
 
        label:
 
        Console.WriteLine("\n\tMenu");
        Console.WriteLine("\nPress 1 for add");
        Console.WriteLine("Press 2 for subtraction");
        Console.WriteLine("Press 3 for multiplication");
        Console.WriteLine("Press 4 for Division");
  
        Console.Write("\n\nEnter first number:\t");
        num1 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter second number:\t");
        num2 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("\nEnter your option:\t");
        opt = Convert.ToInt32(Console.ReadLine());
 
        switch (opt)
         {
           case 1:
               result = num1 + num2;
               Console.WriteLine("\n{0} + {1} = {2}", num1,                num2, result);
               break;
 
           case 2:
               result = num1 - num2;
               Console.WriteLine("\n{0} - {1} = {2}", num1,                num2, result);
               break;
           case 3:
               result = num1 * num2;
               Console.WriteLine("\n{0} * {1} = {2}", num1,                num2, result);
               break;
           case 4:
               result = (float)num1 / num2;
               Console.WriteLine("\n{0} / {1} = {2}", num1,                num2, result);
               break;
           default:
                   Console.WriteLine("\nInvalid option.                    Please try again.");
                   goto label;
         }
        Console.ReadLine();
      }
   }
}
