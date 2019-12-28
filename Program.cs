using System;

namespace tempCalc
{
    class Program
    {
        static void Main()
        {
            string userChoice;
            bool loopCalculator = false;

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Temperature Calculator. This calculator lets you calculate Farenheith into Celsius and vice-versa.");

            while (!loopCalculator)
            {
                Console.WriteLine("Insert \"FC\" if you want to calculate FARENHEIT --> CELSIUS or");
                Console.WriteLine("Insert \"CF\" if you want to calculate CELSIUS --> FARENHEIT.");
                Console.WriteLine("Insert \"FK\" if you want to calculate FARENHEIT --> KELVIN or");
                Console.WriteLine("Insert \"KF\" if you want to calculate KELVIN --> FARENHEIT.");
                Console.WriteLine("Insert \"CK\" if you want to calculate CELSIUS --> KELVIN or");
                Console.WriteLine("Insert \"KC\" if you want to calculate KELVIN --> CELSIUS.");
                Console.WriteLine("Insert \"N\" if you want to exit calculator.");
                userChoice = Console.ReadLine();
                Console.WriteLine("\n");

                switch (userChoice.ToUpper())
                {
                    case "FC":
                        break;
                    case "CF":
                        break;
                    case "FK":
                        break;
                    case "KF":
                        break;
                    case "CK":
                        break;
                    case "KC":
                        break;
                    case "N":
                        break;
                }

                if (userChoice.ToUpper() == "FC")
                {
                    FarenheitToCelsius();
                }

                else if (userChoice.ToUpper() == "CF")
                {
                    CelsiusToFarenheit();
                }

                else if (userChoice.ToUpper() == "FK")
                {
                    FarenheitToKelvin();
                }

                else if (userChoice.ToUpper() == "KF")
                {
                    KelvinToFarenheit();
                }

                else if (userChoice.ToUpper() == "CK")
                {
                    CelsiusToKelvin();
                }

                else if (userChoice.ToUpper() == "KC")
                {
                    KelvinToCelsius();
                }

                else if (userChoice.ToUpper() == "N")
                {
                    loopCalculator = true;
                    Console.WriteLine("Goodbye!");
                }
                Console.WriteLine("\n");
            }
        }

        public static void FarenheitToCelsius()
        {
            Console.WriteLine("Please insert F temperature value you want to convert into C value.");
            float userTemperature = float.Parse(Console.ReadLine());
            double celsius = (userTemperature - 32) * 1.8;
            Console.WriteLine($"The value of {userTemperature}\u00B0F degrees is as much as {celsius}\u00B0C degrees.");
        }

        public static void CelsiusToFarenheit()
        {
            Console.WriteLine("Please insert C temperature value you want to convert into F value.");
            float userTemperature = float.Parse(Console.ReadLine());
            double farenheit = userTemperature * 1.8 + 32;
            Console.WriteLine($"The value of {userTemperature}\u00B0C degrees is as much as {farenheit}\u00B0F degrees.");
        }

        public static void FarenheitToKelvin()
        {
            Console.WriteLine("Please insert F temperature value you want to convert into K value.");
            double userTemperature = float.Parse(Console.ReadLine());
            double kelvin = Math.Round((((userTemperature - 32) * 5) / 9) + 273.15);
            Console.WriteLine($"The value of {userTemperature}\u00B0F degrees is as much as {Math.Round(kelvin)}\u00B0K degrees.");
        }

        public static void KelvinToFarenheit()
        {
            Console.WriteLine("Please insert K temperature value you want to convert into F value.");
            double userTemperature = float.Parse(Console.ReadLine());
            double farenheit = Math.Round((userTemperature - 273.15) * 1.8 + 32);
            Console.WriteLine($"The value of {userTemperature}\u00B0K degrees is as much as {Math.Round(farenheit)}\u00B0F degrees.");
        }
        public static void CelsiusToKelvin()
        {
            Console.WriteLine("Please insert C temperature value you want to convert into K value.");
            double userTemperature = float.Parse(Console.ReadLine());
            double kelvin = Math.Round(userTemperature + 273.15);
            Console.WriteLine($"The value of {userTemperature}\u00B0C degrees is as much as {Math.Round(kelvin)}\u00B0K degrees.");
        }

        public static void KelvinToCelsius()
        {
            Console.WriteLine("Please insert K temperature value you want to convert into C value.");
            double userTemperature = float.Parse(Console.ReadLine());
            double celsius = Math.Round(userTemperature - 273.15);
            Console.WriteLine($"The value of {userTemperature}\u00B0K degrees is as much as {Math.Round(celsius)}\u00B0C degrees.");
        }
    }
}