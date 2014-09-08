/* Main() method is where program stars execution. Main method doesn’t accept parameter from any method. It accept parameter through command line. It is an array type parameter that can accept n number of parameter in runtime.

In Main(string[] args) , args is a string type of array that can hold numerous parameter.
*/



// 1.Open Notepad and write the following code and save it with command.cs

using System;
 
namespace command
{
  class Program
   {
     static void Main(string[] args)
      {
        Console.WriteLine("First Name is " + args[0]);
        Console.WriteLine("Last Name is " + args[1]);
        Console.ReadLine();
      }
   }
}

/*

2.  Open visual studio command prompt and compile the code as follow:
(i) Set current path, where your program is saved.
(ii)  Compile it with csc command.cs

3.  Now execute the program using following command line argument:
(a) command steven clark 

*/
