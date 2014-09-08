// Whenever you write a function or declare a variable, it doesn’t create instance in a memory until you create object of class. But if you declare any function or variable with static modifier, it directly create instance in a memory and acts globally. The static modifier doesn’t reference with any object.

using System;
 
namespace Static_var_and_fun
{
  class number
   {
     // Create static variable
     public static int num;
     //Create static method
     public static void power()
      {
        Console.WriteLine("Power of {0} = {1}", num,                num * num);
        Console.ReadLine();
      }
   }
  class Program
   {
     static void Main(string[] args)
      {
        Console.Write("Enter a number\t");
        number.num = Convert.ToInt32(Console.ReadLine());
        number.power();
      }
   }
}
