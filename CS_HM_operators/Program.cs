using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, new DateTime(2024, 12, 31), 1000.0m);
            CreditCard card2 = new CreditCard("9876543210987654", 456, new DateTime(2025, 12, 31), 2000.0m);

            Console.WriteLine("Initial Card Information:");
            Console.WriteLine("Card 1:");
            card1.DisplayCardInformation();
            Console.WriteLine("\nCard 2:");
            card2.DisplayCardInformation();

            Console.WriteLine("\nAdding 500 to Card 1...");
            card1 += 500.0m;
            Console.WriteLine("New Balance for Card 1: " + card1.Balance);

            Console.WriteLine("\nSubtracting 300 from Card 2...");
            card2 -= 300.0m;
            Console.WriteLine("New Balance for Card 2: " + card2.Balance);

            Console.WriteLine("\nChecking if Card 1 and Card 2 have the same CVC...");
            if (card1 == card2)
            {
                Console.WriteLine("Card 1 and Card 2 have the same CVC.");
            }
            else
            {
                Console.WriteLine("Card 1 and Card 2 do not have the same CVC.");
            }

            Console.WriteLine("\nChecking if Card 1 has more balance than Card 2...");
            if (card1 > card2)
            {
                Console.WriteLine("Card 1 has more balance than Card 2.");
            }
            else
            {
                Console.WriteLine("Card 1 does not have more balance than Card 2.");
            }
        }
    }
}