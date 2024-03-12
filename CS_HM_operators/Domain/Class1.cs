using System;

namespace Domain
{
    public class Shop
    {
        private string name;
        private string address;
        private string description;
        private string phoneNumber;
        private string email;
        private double area; // Площа магазину

        public Shop(string name, string address, string description, string phoneNumber, string email, double area)
        {
            this.name = name;
            this.address = address;
            this.description = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.area = area;
        }

        public void DisplayShopInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Area: {area}");
        }

        public static Shop operator +(Shop shop, double sizeIncrease)
        {
            shop.area += sizeIncrease;
            return shop;
        }

        public static Shop operator -(Shop shop, double sizeDecrease)
        {
            shop.area -= sizeDecrease;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.area == shop2.area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.area != shop2.area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.area < shop2.area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.area > shop2.area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Shop shop = (Shop)obj;
            return area.Equals(shop.area);
        }
    }
}