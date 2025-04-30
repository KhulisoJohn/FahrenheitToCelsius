using System;

namespace FahrenheitToCelsius {

    class Program {

        static void Main(string[] args) {

            Console.Write("Enter temperature in Fahrenheit: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            double celsius = (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine($"The temperature in Celsius is: {celsius:F2}");
        }
    }
}
