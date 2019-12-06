﻿/**
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

            ReadLine();
        }
    }
}
