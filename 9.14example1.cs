// Qu 1:Write a program of calculating the percentage value of given number. After showing output asks user to whether continue or not. If continue, then again take input and shows the result. Hint: Use Goto label statement.

using System;
 
namespace Examples
{
  class Program
   {
     static void Main(string[] args)
      {
        int number,percentage,option;
        float result;
 
        label:
        Console.Write("\n\nEnter a number:\t");
        number = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("\nEnter Percentage Value:\t");
        percentage = Convert.ToInt32(Console.ReadLine());
 
        result = (float)(number * percentage) / 100;
        Console.WriteLine("Percentage value is:\t{0}",             result);
        Console.Write("\nCalculate again press 1.                   To quit press digit:\t");
        option = Convert.ToInt32(Console.ReadLine());
        if (option == 1)
         {
           goto label;
         }
        Console.WriteLine("Press Enter for quit");
        Console.ReadLine();           
      }
   }
}
