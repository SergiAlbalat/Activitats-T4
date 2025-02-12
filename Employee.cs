using System;
namespace Activitats_T4
{
    public class Employee
    {
        private static int _employeeCounter = 0;
        public static int GetCounter() => _employeeCounter;
        protected const string DefaultCode = "No Code";
        protected const string DefaultName = "Jhon";
        protected const string DefaultSurname = "Doe";
        protected const int DefaultPayments = 14;
        protected const float DefaultSalary = 1800;
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments {  get; set; }
        public Employee(string code, string name, string surname, DateTime birthDate, float monthSalary, int payments)
        {
            Code = code;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            HireDate = DateTime.Now;
            MonthSalary = monthSalary;
            Payments = payments;
            _employeeCounter++;
        }
        public Employee() : this(DefaultCode, DefaultName, DefaultSurname, DateTime.Now, DefaultSalary, DefaultPayments) {}
        public Employee(string code, string name, string surname, DateTime birthDate) : this(code, name, surname, birthDate, DefaultSalary, DefaultPayments) {}

        public string GetFullName(bool reverse) => reverse ? $"{Surname}, {Name}" : $"{Name}, {Surname}";
        public int CalculateAge()
        {
            TimeSpan daysLived = -BirthDate.Subtract(DateTime.Now);
            int age = daysLived.Days / 365;
            return age;
        }
        public int CalculateTimeWorking()
        {
            TimeSpan daysWorked = -HireDate.Subtract(DateTime.Now);
            int years = daysWorked.Days / 365;
            return years;
        }
        public float GetAnualSalary() => MonthSalary*Payments;
        public override string ToString() => $"-----------------------------------------------------------------------------------------------------\r\n                           E M P L O Y E E / S A L E S E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n>Code: {Code}\r\n>Firstname: {Name}\r\n>Last name: {Surname}\r\n>Full name: {GetFullName(false)}\r\n>Reverse name: {GetFullName(true)}\r\n>Age: {CalculateAge()}\r\n>Seniority: {CalculateTimeWorking()}\r\n>Annual salary {GetAnualSalary()}";
    }
}
