using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER BASIC CALCULATOR ***");

            Console.WriteLine("Enter the Current Temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int CurrentTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int RelativeHumidity = int.Parse(Console.ReadLine());

            int sum = CurrentTemp - (9*(100 - RelativeHumidity)/25);

            Console.WriteLine("The Dew Point is " + sum);

            Console.WriteLine("Enter the Wind Speed");
            int WindSpeed = int.Parse(Console.ReadLine());
         
            double Just = (0.4275 * CurrentTemp * Math.Pow(WindSpeed, 0.16));
            double chill = 35.74
                + 0.6215 * (CurrentTemp)
                - 35.75 * Math.Pow(WindSpeed, 0.16)
                + Just;

            Console.WriteLine("The Wind Chill is " + chill);

        }
    }
}
