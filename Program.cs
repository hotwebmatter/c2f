/**
 * ######################################################
 * ##    Programming Exercise Chapter 2 #1             ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: December 5 2019               ##
 * ##    Purpose: Width & numeric format specifiers    ##
 * ######################################################
 */

using System;
using static System.Console;

namespace c2f
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit;
            WriteLine("{0, 8}{1, 12}", "Celsius", "Fahrenheit");

            for (double tempCelsius = 0; tempCelsius < 33; tempCelsius++)
            {
                tempFahrenheit = (tempCelsius * 9 / 5) + 32;
                WriteLine("{0, 8:F0}{1, 12:F1}", tempCelsius, tempFahrenheit);
            }
            WriteLine("\n");
            /**
             * BONUS: Fahrenheit to Celsius table
             *
             * Based on example from "The C Programming Language"
             * by Brian W. Kernighan and Dennis Ritchie (1978)
             */

            int fahr, celsius;
            const int LOWER = 0;     // lower limit of temperature scale
            const int UPPER = 300;   // upper limit
            const int STEP = 20;     // step size

            WriteLine("{0, 12}{1, 8}", "Fahrenheit", "Celsius");
            fahr = LOWER;
            while (fahr <= UPPER)
            {
                celsius = 5 * (fahr - 32) / 9;
                WriteLine("{0, 12}{1, 8}", fahr, celsius);
                fahr = fahr + STEP;
            }

            ReadLine();
        }
    }
}
