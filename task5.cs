using System.Collections.Generic;
using System.Linq;
using System.Text;

class Task5_Array
{
    public Task5_Array()
    {
        int i       = 0;
        //declare array of integers
        int[] arr   = new int[5];

        //reading elements
        Console.WriteLine("Enter array elements : ");
        for (i = 0; i < arr.Length; i++)
        {
            Console.Write("Element[" + (i + 1) + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        //checking and printing list of EVEN integers
        Console.WriteLine("List of even numbers : ");
        for (i = 0; i < arr.Length; i++)
        {
            //condition for EVEN number
            if (arr[i] % 2 == 0)
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

