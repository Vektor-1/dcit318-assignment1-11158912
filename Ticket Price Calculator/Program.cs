using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;

        Console.WriteLine($"Your ticket price is: GHS{price}");
    }
}