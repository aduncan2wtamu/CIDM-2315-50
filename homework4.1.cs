using System;

class Program
{
    static void Main()
    {
        int a, b, c, d;
        Console.WriteLine("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        d = Convert.ToInt32(Console.ReadLine());

        int largest = FindLargestOfFour(a, b, c, d);
        Console.WriteLine("The largest number is: " + largest);
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

    static int FindLargestOfFour(int num1, int num2, int num3, int num4)
    {
        int firstTwo = FindLargest(num1, num2);
        int lastTwo = FindLargest(num3, num4);
        int largest = FindLargest(firstTwo, lastTwo);
        return largest;
    }
}