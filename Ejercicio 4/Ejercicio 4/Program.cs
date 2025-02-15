using System;

class Program
{
    static void Main()
    {
        // Asks the user for a number
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        // Calculates the square and cube using arithmetic operators
        double square = number * number;  // Square = number * number
        double cube = number * number * number; // Cube = number * number * number

        // Displays the results
        Console.WriteLine($"The square of {number} is: {square}");
        Console.WriteLine($"The cube of {number} is: {cube}");
    }
}