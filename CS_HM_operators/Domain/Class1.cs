using System;

namespace Domain
{
    public class Employee
    {
        private string fullName;
        private DateTime birthDate;
        private string phoneNumber;
        private string workEmail;
        private string position;
        private string jobDescription;
        private decimal salary;

        public Employee(string fullName, DateTime birthDate, string phoneNumber, string workEmail, string position, string jobDescription, decimal salary)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
            this.salary = salary;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void IncreaseSalary(decimal amount)
        {
            salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            salary -= amount;
        }

        public bool Equals(Employee other)
        {
            return this.salary == other.salary;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.salary == emp2.salary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.salary < emp2.salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.salary > emp2.salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Employee other = (Employee)obj;
            return this.salary == other.salary;
        }

        public override int GetHashCode()
        {
            return salary.GetHashCode();
        }
    }
}