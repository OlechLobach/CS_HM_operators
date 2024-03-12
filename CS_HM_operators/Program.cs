using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Journal journal1 = new Journal("Journal1", 2000, "Description1", "123456789", "journal1@example.com", 50);
            Journal journal2 = new Journal("Journal2", 2010, "Description2", "987654321", "journal2@example.com", 75);

            journal1.DisplayJournalInformation();
            journal2.DisplayJournalInformation();

            journal1 += 10; 
            journal2 -= 5; 

            Console.WriteLine("\nAfter adding/removing employees:");
            journal1.DisplayJournalInformation();
            journal2.DisplayJournalInformation();

            Console.WriteLine($"\nAre the number of employees in journal1 and journal2 equal? {journal1 == journal2}");

            Console.WriteLine($"Are the number of employees in journal1 and journal2 not equal? {journal1 != journal2}");

            Console.WriteLine($"Is the number of employees in journal1 less than in journal2? {journal1 < journal2}");
            Console.WriteLine($"Is the number of employees in journal1 greater than in journal2? {journal1 > journal2}");
        }
    }
}