using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitats_T4
{
    public class SalesEmployee : Employee
    {
        private const string EmployeeType = "SALES EMPLOYEE";
        public float Commission { get; set; }
        private const float DefaultCommission = 1.0f;
        public SalesEmployee(string code, string name, string surname, DateTime birthDate, float monthSalary, int payments, float commission) : base(code, name, surname, birthDate, monthSalary, payments)
        {
            Commission = commission;
        }
        public SalesEmployee() : this(DefaultCode, DefaultName, DefaultSurname, DateTime.Now, DefaultSalary, DefaultPayments, DefaultCommission) { }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"\n>Commission: {Commission}");
            return sb.ToString();
        } 
    }
}
