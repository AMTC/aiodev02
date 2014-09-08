/* Class is a template, declaration or blueprint that is used for classifying object. It encapsulates variable members, functions, structure, properties and many more components. It is the basic building block of object oriented programming. In order to create class, the class keyword is used. 

1. The class name should be noun and meaningful.

2. Use either pascal case or camel case. In camel case, the first letter is small. Ex. camelCase. In pascal case first letter is capital. Ex. PascalCase. It is strictly recommended you to use pascal case for class name and camel case for variable name.

3. Your class name should not contain any special character except underscore (_) or digit. Must start your class name with character.

4. Don’t use reserved keyword for class name.

*/

using System;
 
namespace Creating_Class
{
  class accept //Creating 1st. class
   {
     public string name;
     public void acceptdetails()
      {
        Console.Write("Enter your name:\t");
        name = Console.ReadLine();
      }
   }
 
  class print // Creating 2nd class
   {
     public void printdetails()
      {
        //Creating object of 1st. class
        accept a = new accept();
        //executing method of 1st class.
        a.acceptdetails();
        //Printing value of name variable
        Console.WriteLine("Your name is " + a.name);
      }
   }
  class Program //Creating 3rd class
   {
     static void Main(string[] args)
      {
        print p = new print();
        p.printdetails();
        Console.ReadLine();
      }
   }
}
