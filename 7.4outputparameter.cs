// Usually, a method returns value with return keyword. Unfortunately, a return modifier can return only one value at a time. Sometime, your C# program required to return multiple values from a single method. In this situation, you need such type of function that can produce multiple output result from a single function. The output parameter C# lets your program to return multiple values.

using System;
 
namespace out_parameter
{
  class Program
   {
     //Accept two input parameter and returns two out value
     public static void rect(int len, int width, out int         area, out int perimeter)
      {
        area = len * width;
        perimeter = 2 * (len + width);
      }
     static void Main(string[] args)
      {
        int area, perimeter;
        // passing two parameter and getting two returning          value
        Program.rect(5, 4, out area, out perimeter);
        Console.WriteLine("Area of Rectangle is {0}\t",              area);
        Console.WriteLine("Perimeter of Rectangle is                {0}\t", perimeter);
        Console.ReadLine();
      }
   }
}
