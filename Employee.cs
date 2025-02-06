using System;
namespace Activitats_T4
{
    public class Employee
    {
        public int CalculateAge(DateTime fechaNacimiento)
        {
            TimeSpan daysLived = -(fechaNacimiento.Subtract(DateTime.Now));
            int age = daysLived.Days / 365;
            return age;
        }
    }
}
