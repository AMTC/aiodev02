// The get set accessor or modifier mostly used for storing and retrieving value from the private field. The get accessor must return a value of property type where set accessor returns void. The set accessor uses an implicit parameter called value. In simple word, the get method used for retrieving value from private field whereas set method used for storing value in private variables.

using System;
 
namespace Get_Set
{
  class access
   {
     // String Variable declared as private
     private static string name;
     public void print()
      {
        Console.WriteLine("\nMy name is " + name);
      }
 
     public string Name //Creating Name property
      {
        get //get method for returning value
         {
           return name;
         }
        set // set method for storing value in name field.
         {
           name = value;
         }
      }
   }
 
  class Program
   {
     static void Main(string[] args)
      {
        access ac = new access();
        Console.Write("Enter your name:\t");
        // Accepting value via Name property
        ac.Name = Console.ReadLine();
        ac.print();
        Console.ReadLine();
      }
   }
}
