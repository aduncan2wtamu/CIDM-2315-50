using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        int result = FindLargest(a, b);
        Console.WriteLine("The largest number is: " + result);
    }

    static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}