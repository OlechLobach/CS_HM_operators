using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the name of the first city: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the country of the first city: ");
            string country1 = Console.ReadLine();

            Console.Write("Enter the population of the first city: ");
            int population1 = int.Parse(Console.ReadLine());

            City city1 = new City(name1, country1, population1);

            Console.Write("Enter the name of the second city: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter the country of the second city: ");
            string country2 = Console.ReadLine();

            Console.Write("Enter the population of the second city: ");
            int population2 = int.Parse(Console.ReadLine());

            City city2 = new City(name2, country2, population2);

            Console.WriteLine($"Initial populations: {city1.Name} - {city1.Population}, {city2.Name} - {city2.Population}");

            Console.Write("Enter the amount to increase the population of the first city: ");
            int increase1 = int.Parse(Console.ReadLine());
            city1 += increase1;

            Console.Write("Enter the amount to decrease the population of the second city: ");
            int decrease2 = int.Parse(Console.ReadLine());
            city2 -= decrease2;

            Console.WriteLine($"After changes: {city1.Name} - {city1.Population}, {city2.Name} - {city2.Population}");

            if (city1 == city2)
                Console.WriteLine($"{city1.Name} and {city2.Name} have the same population");
            else
                Console.WriteLine($"{city1.Name} and {city2.Name} have different populations");

            if (city1 > city2)
                Console.WriteLine($"{city1.Name} has a larger population than {city2.Name}");
            else if (city1 < city2)
                Console.WriteLine($"{city1.Name} has a smaller population than {city2.Name}");
            else
                Console.WriteLine($"{city1.Name} and {city2.Name} have the same population");

            Console.ReadLine();
        }
    }
}
