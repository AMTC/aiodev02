/*
Properties  Explanation Example
Length  Returns the length of array. Returns integer value.   int i = arr1.Length;
Rank  Returns total number of items in all the dimension. Returns integer value.  int i = arr1.Rank;
IsFixedSize   Check whether array is fixed size or not. Returns Boolean value   bool i = arr.IsFixedSize;
IsReadOnly  Check whether array is ReadOnly or not. Returns Boolean value   bool k = arr1.IsReadOnly;

*/

/*
Function  Explanation Example
Sort  Sort an array   Array.Sort(arr);
Clear   Clear an array by removing all the items  Array.Clear(arr, 0, 3);
GetLength   Returns the number of elements  arr.GetLength(0);
GetValue  Returns the value of specified items  arr.GetValue(2);
IndexOf   Returns the index position of value   Array.IndexOf(arr,45);
Copy  Copy array elements to another elements   Array.Copy(arr1,arr1,3);
*/

using System;
 
namespace Array_Class
{
  class Program
   {
     static void printarray(int[] arr)
      {
        Console.WriteLine("\nElements of array is:\n");
        foreach (int i in arr)
         {
           Console.Write("\t{0}", i);
         }
        Console.WriteLine("\n");
      }
     static void Main(string[] args)
      {
        //Initializing and storing value in arr1
        int[] arr1=new int[5]{43,25,33,14,5};
        int[] arr2 = new int[5];
        int len,rank;
        bool fixedsize, read_only;
 
        //Check array length
        len = arr1.Length;
        Console.WriteLine("Length:\t{0}", len);
 
        //Check array rank
        rank = arr1.Rank;
        Console.WriteLine("Rank:\t{0}", rank);
 
        //Check whether array is fixed size or not
        fixedsize = arr1.IsFixedSize;
        Console.WriteLine("Fixed Size:\t{0}", fixedsize);
 
        //Check whether array is read only or not
        read_only = arr1.IsReadOnly;
        Console.WriteLine("Read Only:\t{0}", read_only);
 
        //Sorting an array
        Array.Sort(arr1);
        printarray(arr1);
 
        //Returning Lenght from specified position
        Console.WriteLine("Get Length:\t{0}",                       arr1.GetLength(0));
 
        //Returns value of specied position
        Console.WriteLine("Get Value:\t{0}",                       arr1.GetValue(2));
 
        //Returns Index position of specified value
        Console.WriteLine("Get Index:\t{0}",                       Array.IndexOf(arr1, 33));
 
        //Copying arr1's items to arr2
        Array.Copy(arr1, arr2,5);
        printarray(arr2);
 
        //Removing items from array.
        Array.Clear(arr1, 0, 5);
        printarray(arr1);
 
        Console.ReadLine();
      }
   }
}
