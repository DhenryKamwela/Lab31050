using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement - Write a program that converts a Fahrenheit temperature to Celsius.
            //The user should be able to input the temperature at the Command prompt and it should output the temperature.
            //In addition, you should output “It is cold” if the Fahrenheit value is less that 40 or it should output 
            //“It is hot” if the temperature is over 90 (4 points).
            //Code to read a value: double fahrenheit = Convert.ToDouble(Console.ReadLine());
            //Code to convert: celsius  = (fahrenheit - 32d) * 5d / 9d;

            double a = 40;
            double b = 90;

            Console.WriteLine("Enter your temperature in degrees Fahrenheit.");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            if (fahrenheit > b)
            {
                Console.WriteLine("The tempurature in degrees Celsius is: " + celsius);
                Console.WriteLine("It is hot");

            }
            else if (fahrenheit > a)
            {
                Console.WriteLine("The tempurature in degrees Celsius is: " + celsius);
            }
            else
            {
                Console.WriteLine("The tempurature in degrees Celsius is: " + celsius);
                Console.WriteLine("It is cold");
            }

            Console.ReadKey();













        }
    }
}
