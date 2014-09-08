// Q1. Write a program to check whether input character is vowel or not.

using System;
 
namespace Example1
{
  class Program
   {
     static void Main(string[] args)
      {
        char ch;
 
        Console.Write("Enter a character: \t");
        ch = Convert.ToChar(Console.ReadLine());
 
        if (ch == 'a' || ch == 'A' || ch == 'e' || 
                        ch == 'E' || ch == 'i' || ch == 'I' ||                      
                        ch == 'o' || ch == 'O' || ch == 'u' || ch=='U')
         {
           Console.WriteLine("\n\n{0} is vowel",ch);
         }
        else
         {
           Console.WriteLine("\n\n{0} is not vowel",ch);
         }
        Console.ReadLine();
      }
   }
}
