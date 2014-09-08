// Qu3:Write a program in which pass two number as command line argument and displays the multiplication of both number.
//a.Write the following command on notepad and save as commandline.cs


using System;
 
namespace Example3
{
  class Program
   {
     static void Main(string[] args)
      {
        int num1,num2,result;
        num1 = Convert.ToInt32(args[0]);
        num2 = Convert.ToInt32(args[1]);
        result = num1 * num2;
        Console.WriteLine("{0} x {1} = {2}", num1, num2,            result);
      }
   }
}

/*
b.Open visual studio command prompt and set current path of your program.
c.Compile it as csc commandline.cs
d.Now execute program as commandline 5 4 
*/
