﻿using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input the first num:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second num:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the third num:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest = num1;

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest = num3;
        }

        Console.WriteLine("The smallest value is: " + smallest);
    }
}