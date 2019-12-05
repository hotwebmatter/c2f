using System;
using static System.Console;

namespace c2f
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempCelsius = 0;
            double tempFahrenheit = ((tempCelsius * 9) / 5) + 32;
            WriteLine("{0, 12}{1, 12}", "Celsius", "Fahrenheit");
            WriteLine("{0, 12:F0}{1, 12:F1}", tempCelsius, tempFahrenheit);
            ReadLine();
        }
    }
}
