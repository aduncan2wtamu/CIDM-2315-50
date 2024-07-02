using System;

class Program
{
    // Method to check age
    static bool CheckAge(int birthYear)
    {
        int age = 2022 - birthYear;
        return age >= 18;
    }

    // Method to create an account
    static void CreateAccount()
    {
        // Ask user to input username
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        // Ask user to input password
        Console.WriteLine("Enter password: ");
        string password1 = Console.ReadLine();

        // Ask user to input password again
        Console.WriteLine("Enter password again: ");
        string password2 = Console.ReadLine();

        // Ask user to input birth year
        Console.WriteLine("Enter birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        // Check if age is greater than or equal to 18
        if (CheckAge(birthYear))
        {
            // Check if two passwords are the same
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

    static void Main(string[] args)
    {
        CreateAccount();
    }
}