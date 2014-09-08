// Enumeration provides efficient way to assign multiple constant integral values to a single variable. Enumeration improves code clarity and makes program easier to maintain. Enumeration in C# also provides more security by better error-checking technology and compiler warnings.

using System;
 
namespace Enumeration
{
  // creating enumeration for storing day.
  public enum attandance
   {
     Monday,
     Tuesday,
     Wednesday,
     Thursday,
     Friday
   }
 
  class Program
   {
     static void Main(string[] args)
      {
        attandance present = attandance.Monday;//Valid
        Console.WriteLine(present);
           
        //attandance absent = attandance.Sunday;//Invalid
        Console.ReadLine();
      }
   }
}
