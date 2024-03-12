using System;

namespace Domain
{
    public class Journal
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;
        private int numberOfEmployees;

        public Journal(string name, int yearFounded, string description, string contactPhone, string email, int numberOfEmployees)
        {
            this.name = name;
            this.yearFounded = yearFounded;
            this.description = description;
            this.contactPhone = contactPhone;
            this.email = email;
            this.numberOfEmployees = numberOfEmployees;
        }

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public void DisplayJournalInformation()
        {
            Console.WriteLine("Journal Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year Founded: {yearFounded}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Number of Employees: {numberOfEmployees}");
        }

        public static Journal operator +(Journal journal, int employeesToAdd)
        {
            journal.numberOfEmployees += employeesToAdd;
            return journal;
        }

        public static Journal operator -(Journal journal, int employeesToRemove)
        {
            journal.numberOfEmployees -= employeesToRemove;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.numberOfEmployees == journal2.numberOfEmployees;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1.numberOfEmployees != journal2.numberOfEmployees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.numberOfEmployees < journal2.numberOfEmployees;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.numberOfEmployees > journal2.numberOfEmployees;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Journal other = (Journal)obj;
            return this.numberOfEmployees == other.numberOfEmployees;
        }

        public override int GetHashCode()
        {
            return numberOfEmployees.GetHashCode();
        }
    }
}