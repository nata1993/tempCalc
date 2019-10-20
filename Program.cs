using System;

namespace tempCalc
{
    class Program
    {
        static void Main()
        {
            string userChoice;           
            bool loop = false;

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Temperature Calculator. This calculator lets you calculate Farenheith into Celsius and vice-versa.");

            while (!loop)
            {
                Console.WriteLine("Insert \"FC\" if you cant to calculate Farenheit into Celsius or");
                Console.WriteLine("insert \"CF\" if you want to calculate Celsius into Farenheit.");
                Console.WriteLine("Insert \"N\" if you want to exit calculator.");
                userChoice = Console.ReadLine();
                Console.WriteLine("\n");

                switch(userChoice.ToUpper())
                {
                    case "FC":
                        break;
                    case "CF":
                        break;
                    case "N":
                        break;
                }

                if (userChoice.ToUpper() == "FC")
                {
                    FarenheitCelsius();
                }

                else if (userChoice.ToUpper() == "CF")
                {
                    CelsiusFarenheit();
                }
                
                else if (userChoice.ToUpper() == "N")
                {
                    Goodbye();
                    loop = true;
                }
                Console.WriteLine("\n");
            }
        }

        public static void FarenheitCelsius()
        {
            Console.WriteLine("Please insert F temperature value you want to convert.");
            float userTemperature = float.Parse(Console.ReadLine());
            double celsius = (userTemperature - 32) * 1.8;
            Console.WriteLine($"The {userTemperature}F degrees is {celsius}C degrees.");
        }

        public static void CelsiusFarenheit()
        {
            Console.WriteLine("Please insert C temperature value you want to convert.");
            float userTemperature = float.Parse(Console.ReadLine());
            double farenheit = userTemperature * 1.8 + 32;
            Console.WriteLine($"The {userTemperature}C degrees is {farenheit}F degrees.");
        }

        public static void Goodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
