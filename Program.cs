﻿using System;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            Parella<string, int> parella1 = new Parella<string, int>("Hola", 2);
            parella1.ShowValues();
            Parella<double, bool> parella2 = new Parella<double, bool>(2.3, false);
            parella2.ShowValues();
        }
    }
}