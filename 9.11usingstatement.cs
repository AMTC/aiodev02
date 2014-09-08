// The using statement is mostly used when you need to one or more resources in a segment. The using statement obtains one or various resources, executes them and then releases the objects or resources. It is widely used in database connectivity through C#.

using System;
 
namespace Using_Statement
{
  class check_using : IDisposable
   {
     public void Dispose()
      {
        Console.WriteLine("Execute  Second");
      }
   }
 
  class Program
   {       
     static void Main(string[] args)
      {
        using(check_using c=new check_using())
         {
           Console.WriteLine("Executes First");
         }
        Console.WriteLine("Execute Third");
        Console.ReadLine();
      }
   }
}


// In the above example, the using statement calling the check_using class to execute. So, it first executes the using block, then executes the check_using class and finally executes the last statements.
