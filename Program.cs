using System;

namespace tempCalc
{
    class Program
    {
        static void Main()
        {
            string userChoice;
            float temp;
            double celsius;
            double farenheit;
            bool loop = false;

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Temperature Calculator. This calculator lets you calculate Farenheith into Celsius and vice-versa.");

            while (!loop)
            {
                Console.WriteLine("Insert \"FC\" if you cant to calculate Farenheit into Celsius or");
                Console.WriteLine("insert \"CF\" if you want to calculate Celsius into Farenheit.");
                Console.WriteLine("Insert any other button if you want to exit calculator.");
                userChoice = Console.ReadLine();
                Console.WriteLine("\n");

                if (userChoice.ToUpper() == "FC")
                {
                    Console.WriteLine("Please insert F temperature value you want to convert.");
                    temp = float.Parse(Console.ReadLine());
                    celsius = (temp - 32) * 1.8;
                    Console.WriteLine($"The {temp}F degrees is {celsius}C degrees.");
                }

                else if (userChoice.ToUpper() == "CF")
                {
                    Console.WriteLine("Please insert C temperature value you want to convert.");
                    temp = float.Parse(Console.ReadLine());
                    farenheit = temp * 1.8 + 32;
                    Console.WriteLine($"The {temp}C degrees is {farenheit}F degrees.");
                }
                
                else
                {
                    loop = true;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
