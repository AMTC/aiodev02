/*
Value Type: A value type variable directly contains data in the memory.

Reference Type: A Reference type variable contains memory address of value.

In value type parameter, the actual value gets passed to the function. Passing a value type variable as parameter means, you are passing the copy of the value. 
*/

using System;
 
namespace Value_Type
{
  class Program
   {
     public static int qube(int num)
      {
        return num * num * num;
      }
     static void Main(string[] args)
      {
        int val,number;
        number = 5;
        //Passing the copy value of number variable
        val = Program.qube(number);
        Console.Write(val);
        Console.ReadLine();
      }
   }
}
