using System;
public class Task9_ProductOfNumber
{
    public Task9_ProductOfNumber(string[] args)
    {
        Console.Write("Please enter first integer value: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter second integer value: ");
        int y = Convert.ToInt32(Console.ReadLine());
 
        int result = 0;
        int i = 0;
 
        while (i < y)
        {
            result = result + x;
            i++;
        }

        Console.WriteLine("===== Output =====");
        Console.WriteLine("{0}x{1}= {2}", x, y, result);
    }
}