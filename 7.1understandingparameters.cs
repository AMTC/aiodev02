using System;
 
namespace Understanding_Parameter
{
  class Program
   {
     // function with parameter
     public static int power(int num1)
      {
        int result;
        result = num1 * num1;
        return result;
      }
 
     static void Main(string[] args)
      {
        int pow;
        // passing arguement as parameter
        pow = Program.power(5);
        Console.Write("\nPower = {0}", pow);
        Console.ReadLine();
      }
   }
}
