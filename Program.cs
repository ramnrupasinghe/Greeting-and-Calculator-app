using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Enhanced Greeting and Calculator Program!");

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Greet me");
            Console.WriteLine("2. Calculate");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GreetUser();
                    break;

                case "2":
                    Calculate();
                    break;

                case "3":
                    exitProgram = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void GreetUser()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        if (!string.IsNullOrEmpty(userName))
        {
            Console.WriteLine($"Hello, {userName}! Nice to meet you.");
        }
        else
        {
            Console.WriteLine("Hello, anonymous user! Nice to meet you.");
        }
    }

    static void Calculate()
    {
        Console.WriteLine("\nSelect an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        string operationChoice = Console.ReadLine();

        switch (operationChoice)
        {
            case "1":
                PerformCalculation(Operations.Addition);
                break;

            case "2":
                PerformCalculation(Operations.Subtraction);
                break;

            case "3":
                PerformCalculation(Operations.Multiplication);
                break;

            case "4":
                PerformCalculation(Operations.Division);
                break;

            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }
    }

    static void PerformCalculation(Operations operation)
    {
        Console.Write("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        double result = 0;

        switch (operation)
        {
            case Operations.Addition:
                result = num1 + num2;
                Console.WriteLine($"Result of addition: {num1} + {num2} = {result}");
                break;

            case Operations.Subtraction:
                result = num1 - num2;
                Console.WriteLine($"Result of subtraction: {num1} - {num2} = {result}");
                break;

            case Operations.Multiplication:
                result = num1 * num2;
                Console.WriteLine($"Result of multiplication: {num1} * {num2} = {result}");
                break;

            case Operations.Division:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result of division: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }
    }
}

enum Operations
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
