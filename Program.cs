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

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Temperature Calculator. This calculator lets you calculate Farenheith into Celsius and vice-versa.");
            Console.WriteLine("Insert \"FC\" if you cant to calculate Farenheit into Celsius or"); 
            Console.WriteLine("insert \"CF\" if you want to calculate Celsius into Farenheit.");
            userChoice = Console.ReadLine();
            Console.WriteLine("Please insert temperature value you want to convert.");
            temp = float.Parse(Console.ReadLine());

            if (userChoice.ToUpper() == "FC")
            {
                celsius = (temp - 32) * 1.8;
                Console.WriteLine($"The {temp}F degrees is {celsius}C degrees.");
            }

            else
            {
                farenheit = temp * 1.8 + 32;
                Console.WriteLine($"The {temp}C degrees is {farenheit}F degrees.");
            }
        }
    }
}
