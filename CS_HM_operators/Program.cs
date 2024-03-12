using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Shop shop1 = new Shop("Shop1", "Address1", "Description1", "123456789", "shop1@example.com", 100.0);
            Shop shop2 = new Shop("Shop2", "Address2", "Description2", "987654321", "shop2@example.com", 150.0);


            Console.WriteLine("Shop1 Information:");
            shop1.DisplayShopInformation();

            Console.WriteLine("\nShop2 Information:");
            shop2.DisplayShopInformation();

            shop1 += 50.0;
            Console.WriteLine("\nShop1 Area Increased by 50.0:");
            shop1.DisplayShopInformation();

            if (shop1 == shop2)
            {
                Console.WriteLine("\nShop1 and Shop2 have the same area.");
            }
            else
            {
                Console.WriteLine("\nShop1 and Shop2 have different areas.");
            }

            if (shop1 > shop2)
            {
                Console.WriteLine("\nShop1 has a larger area than Shop2.");
            }
            else
            {
                Console.WriteLine("\nShop1 does not have a larger area than Shop2.");
            }
        }
    }
}
