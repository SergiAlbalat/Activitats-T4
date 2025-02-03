using System;
namespace Activitats_T4
{
    public class Parella<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }
        public Parella(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public void ShowValues()
        {
            Console.WriteLine(Value1);
            Console.WriteLine(Value2);
        }
    }
}
