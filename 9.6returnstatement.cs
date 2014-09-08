// A return statement is used for returning value to the caller from the called function. A easy example is mentioned below in a program that demonstrate the return statement very clearly.

using System;
 
namespace Return_Statement
{
  class Program
    {
      public int add(int num1, int num2)
       {
         // returns the add of num1 and num2
         return num1 + num2;
       }
      static void Main(string[] args)
       {
         Program p = new Program();
         int result;
         // calling the function add that will return 9 to          the result vaiable.
         result = p.add(3, 6);
         Console.WriteLine(result);
 
         Console.ReadLine();
       }
    }
}
