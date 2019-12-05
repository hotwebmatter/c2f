using System;
using static System.Console;

namespace c2f
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0, 8}{1, 12}", "Celsius", "Fahrenheit");

            for (double tempCelsius = 0; tempCelsius < 33; tempCelsius++)
            {
                double tempFahrenheit = (tempCelsius * 9 / 5) + 32;
                WriteLine("{0, 8:F0}{1, 12:F1}", tempCelsius, tempFahrenheit);
            }

            ReadLine();
        }
    }
}
