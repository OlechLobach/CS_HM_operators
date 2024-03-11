using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {

            Employee employee1 = new Employee("John Doe", new DateTime(1990, 5, 15), "+123456789", "john.doe@example.com", "Manager", "Managing stuff", 5000);
            Employee employee2 = new Employee("Jane Smith", new DateTime(1985, 10, 25), "+987654321", "jane.smith@example.com", "Developer", "Developing stuff", 4500);


            Console.WriteLine("Initial salaries:");
            Console.WriteLine($"{employee1.FullName}: {employee1.Salary}");
            Console.WriteLine($"{employee2.FullName}: {employee2.Salary}");
            Console.WriteLine();


            employee1.IncreaseSalary(1000);


            employee2.DecreaseSalary(500);


            Console.WriteLine("Updated salaries:");
            Console.WriteLine($"{employee1.FullName}: {employee1.Salary}");
            Console.WriteLine($"{employee2.FullName}: {employee2.Salary}");
            Console.WriteLine();


            if (employee1 == employee2)
            {
                Console.WriteLine("Salaries are equal");
            }
            else
            {
                Console.WriteLine("Salaries are not equal");
            }


            if (employee1 > employee2)
            {
                Console.WriteLine($"{employee1.FullName} has a higher salary than {employee2.FullName}");
            }
            else if (employee1 < employee2)
            {
                Console.WriteLine($"{employee1.FullName} has a lower salary than {employee2.FullName}");
            }
            else
            {
                Console.WriteLine("Salaries are equal");
            }
        }
    }
}