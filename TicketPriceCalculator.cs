using System;

class TicketPriceCalculator
{
    static void Main()
    {
        const int regularPrice = 10;
        const int discount = 3;

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int ticketPrice = regularPrice;

        if (age <= 12 || age >= 65)
        {
            ticketPrice -= discount;
        }

        Console.WriteLine("The ticket price is: GHC" + ticketPrice);
    }
}
