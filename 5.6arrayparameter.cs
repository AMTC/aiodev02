/*
An array can also be passed to method as argument or parameter. A method process the array and returns output. Passing array as parameter in C# is pretty easy as passing other value as parameter. Just create a function that accepts array as argument and then process them. The following demonstration will help you to understand how to pass array as argument in C# programming.
*/
using System;
 
namespace array_parameter
{
  class Program
   {
     static void printarray(int[] newarray)
      {
        int i,sum=0;
        Console.Write("\n\nYou entered:\t");
        for (i = 0; i < 4; i++)
         {
           Console.Write("{0}\t", newarray[i]);
           sum = sum + newarray[i];
         }
        Console.Write("\n\nAnd sum of all value is:                 \t{0}", sum);
        Console.ReadLine();
      }
     static void Main(string[] args)
      {
        int[] arr = new int[4];
        int i;
        for (i = 0; i < 4; i++)
         {
           Console.Write("Enter number:\t");
           arr[i] = Convert.ToInt32(Console.ReadLine());
         }
        // passing array as argument
        Program.printarray(arr);
      }
   }
}
