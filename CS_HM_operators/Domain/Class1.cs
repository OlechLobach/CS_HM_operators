using System;

namespace Domain
{
    public class City
    {
        private string name;
        private string country;
        private int population;

        public string Name { get { return name; } }
        public string Country { get { return country; } }
        public int Population { get { return population; } }

        public City(string name, string country, int population)
        {
            this.name = name;
            this.country = country;
            this.population = population;
        }

        public static City operator +(City city, int increase)
        {
            city.population += increase;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.population -= decrease;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.population == city2.population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.population != city2.population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.population < city2.population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.population > city2.population;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            City city = (City)obj;
            return population == city.population;
        }

        public void DisplayCityInformation()
        {
            Console.WriteLine($"City: {name}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Population: {population}");
        }
    }
}