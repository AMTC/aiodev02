/*
Sometimes, you are not assured about number of parameters or you want to create a method that can accept n number of parameters at run time. This situation can be handled with params type array in C#. The params keyword creates an array at run time that receives and holds n number of parameters.

 static int add(params int[] allnumber)

In the preceding line, the allnumber variable can holds n number of parameters at runtime because it is declared with params keyword.
*/

using System;
 
namespace params_array
{
  class Program
   {
     static int add(params int[] allnumber)
      {
        int sum=0;
        foreach (int n in allnumber)
         {
           sum = sum + n;
         }
        return sum;
      }
     static void Main(string[] args)
      {
        int sum;
        // passing three parameters
        sum = Program.add(1, 2, 3);
        Console.WriteLine("Sum of 1,2,3 is:\t{0}", sum);
 
        // passing five parameters
        sum = Program.add(3, 5, 2, 6, 2);
        Console.WriteLine("Sum of 3,5,2,6,2 is:\t{0}",             sum);
        Console.ReadLine();
      }
   }
}
