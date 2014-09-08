/*
1.  You can define multiple functions within a class.

2.  If you are using return data type instead of void, then must return appropriate value with return keyword. 
*/
using System;
 
namespace Declaring_Method
{
  class Program
   {
     string name, city;
     int age;
 
     // Creating method for accepting details
     public void acceptdetails()
      {
        Console.Write("\nEnter your name:\t");
        name = Console.ReadLine();
 
        Console.Write("\nEnter Your City:\t");
        city = Console.ReadLine();
 
        Console.Write("\nEnter your age:\t\t");
        age = Convert.ToInt32(Console.ReadLine());
      }
 
     // Creating method for printing details
     public void printdetails()
      {
        Console.Write("\n\n===================");
        Console.Write("\nName:\t" + name);
        Console.Write("\nCity:\t" + city);
        Console.Write("\nAge:\t" + age);
        Console.Write("\n===================\n");
      }
 
     static void Main(string[] args)
      {
        Program p = new Program();
        p.acceptdetails();
        p.printdetails();
        Console.ReadLine();
      }
   }
}
