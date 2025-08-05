using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Sides must be positive numbers.");
            return;
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
