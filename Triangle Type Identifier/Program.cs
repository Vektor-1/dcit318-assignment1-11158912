using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Please enter the length side 1: ");
        double side1 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length side 2: ");
        double side2 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length side 3: ");
        double side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is an Equilateral triangle.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3) 
        {
            Console.WriteLine("The triangle is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("The triangle is a Scalene triangle.");
        }
    }
}