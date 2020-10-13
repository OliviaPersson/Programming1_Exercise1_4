using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming1_Exercise1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double graderCelsius;
            double farenheit;
            
            Console.WriteLine("Mata in grader i Celsius: ");
            userInput = Console.ReadLine();
            graderCelsius = Convert.ToDouble(userInput);

            farenheit = (graderCelsius * 9) / 5 + 32;


            Console.WriteLine($"Det blir {farenheit} grader Farenheit." + "\n" + "Tryck på valfri tangent för att fortsätta...");

            Console.ReadKey();


        }
    }
}
