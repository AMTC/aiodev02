// A variable refers to the memory address. When you create variable, it creates holds space in the memory that is used for storing temporary data. As you know about c# data types, each data type has predefined size. In this chapter you will learn how to use data types to create variable.

using System;
 
namespace Variable
{
  class Program
   {
     static void Main(string[] args)
      {
        //cretaing integer type variable
        int num1, num2, result;
        //Displaying message
        Console.WriteLine("Please enter first value");
          
        //Accepting Value in num1
        num1 = Int32.Parse(Console.ReadLine());
        //Displaying message
        Console.WriteLine("Enter second Value");
        //Accepting Value
        num2 = Int32.Parse(Console.ReadLine());
 
        result = num1 + num2; //processing value
 
        Console.WriteLine("Add of {0} and {1} is {2}",              num1, num2, result); //Output
 
        Console.ReadLine();
      }
   }
}


/*
 Integer = int32.parse() or Convert.ToInt32()
 Float= (float)
 Double=Convert.ToDouble()
 Decimal=Convert.ToDecimal()
 Byte=Convert.ToByte()
*/
