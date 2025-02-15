using System;

class Program
{
    // Defines a constant for the value of π
    const double Pi = 3.14159;

    static void Main()
    {
        // Asks the user for the radius of the circle
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        // Calculates the area and the perimeter using the formulas
        double area = Pi * Math.Pow(radius, 2); // Area = π * radius²
        double perimeter = 2 * Pi * radius;     // Perimeter = 2 * π * radius

        // Displays the results
        Console.WriteLine($"The area of the circle is: {area}");
        Console.WriteLine($"The perimeter of the circle is: {perimeter}");
    }
}