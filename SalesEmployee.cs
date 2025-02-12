using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitats_T4
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }
        private const float DefaultCommission = 1.0f;
        public SalesEmployee(string code, string name, string surname, DateTime birthDate, float monthSalary, int payments, float commission) : base(code, name, surname, birthDate, monthSalary, payments)
        {
            Commission = commission;
        }
        public SalesEmployee() : this(DefaultCode, DefaultName, DefaultSurname, DateTime.Now, DefaultSalary, DefaultPayments, DefaultCommission) { }
        public override string ToString() => $"-----------------------------------------------------------------------------------------------------\r\n                           E M P L O Y E E / S A L E S E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n>Code: {Code}\r\n>Firstname: {Name}\r\n>Last name: {Surname}\r\n>Full name: {GetFullName(false)}  \r\n>Reverse name: {GetFullName(true)}\r\n>Age: {CalculateAge()}\r\n>Seniority: {CalculateTimeWorking()}\r\n>Annual salary: {GetAnualSalary()}\r\n>Commission: {Commission}";
    }
}
