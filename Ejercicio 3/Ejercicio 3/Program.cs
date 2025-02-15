using System;

class Program
{
    static void Main()
    {
        // Asks the user for the first integer
        Console.Write("Enter the first integer: ");
        int number1 = int.Parse(Console.ReadLine());

        // Asks the user for the second integer
        Console.Write("Enter the second integer: ");
        int number2 = int.Parse(Console.ReadLine());

        // Calculates the average using addition and division
        double average = (number1 + number2) / 2.0;

        // Displays the result
        Console.WriteLine($"The average of {number1} and {number2} is: {average}");
    }
}