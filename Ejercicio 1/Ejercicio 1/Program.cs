using System;

class Program
{
    static void Main()
    {
        // Asks the user to enter two integers
        Console.Write("Enter the first number, please: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number, porfavor: ");
        int number2 = int.Parse(Console.ReadLine());

        // Calculates the sum, subtraction, multiplication, and division
        int sum = number1 + number2;
        int subtraction = number1 - number2;
        int multiplication = number1 * number2;

        // Checks if the second number is not zero before performing the division
        if (number2 != 0)
        {
            double division = (double)number1 / number2;
            Console.WriteLine($"The division of {number1} by {number2} is: {division}, ur welcome");
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero, you should know that by now.");
        }

        // Displays the results
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
        Console.WriteLine($"The subtraction of {number1} and {number2} is: {subtraction}");
        Console.WriteLine($"The multiplication of {number1} and {number2} is: {multiplication}");
    }
}