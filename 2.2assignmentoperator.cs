/*
Assignment Operators    Usage   Examples
= (Equal to)    result=5    Assign the value 5 for result
+= (Plus Equal to)  result+=5   Same as result=result+5
-= (Minus Equal to)     result-=5   Same as result=result-5
*= (Multiply Equal to)  result*=5   Same as result=result*5
/= (Divide Equal to)    result/=5   Same as result=result/5
%= (Modulus Equal to)   result%=5   Same as result=result%5
*/
using System;
 
namespace assignment_operator
{
  class Program
   {
     static void Main(string[] args)
      {
        int num1,num2;
 
        num1 = 10;
        num2 = 5;
 
        num1 += num2; // same as num1=num1+num2
        Console.WriteLine("Add = {0}", num1);
 
        num1 -= num2; // same as num1=num1-num2
        Console.WriteLine("\n\nSubtraction = {0}", num1);
 
        num1 *= num2; // same as num1=num1*num2
        Console.WriteLine("\n\nMultiplication={0}",num1);
 
        num1 %= num2; // same as num1=num1%num2
        Console.WriteLine("\n\nModulus = {0}", num1);
 
        Console.ReadLine();
      }
   }
}


