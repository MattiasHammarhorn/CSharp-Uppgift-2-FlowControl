using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Util
    {
        // Helper method for asking for and validating a string
        public static string AskForAString(string prompt)
        {
            bool isValidString = false;
            string userInput = String.Empty;

            do
            {
                Console.Write($"Please enter a valid {prompt}: ");
                userInput = Console.ReadLine();

                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Error: you must enter a valid {prompt}.");
                }
                else
                {
                    isValidString = true;
                }
            } while (!isValidString);

            return userInput;
        }

        // Helper method for asking for and validating an integer
        public static int AskForAnInt(string prompt)
        {
            bool isValidInt = false;
            string userInput = String.Empty;
            int intToReturn = 0;
            do
            {
                Console.Write($"Please enter a valid {prompt} here: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out intToReturn))
                {
                    isValidInt = true;
                }
                else
                {
                    Console.WriteLine($"Error: you must enter a valid {prompt}.");
                }
            } while (!isValidInt);
            return intToReturn;
        }

        // Helper method for calculatiing the price of a ticket based on a customer's age
        public static double CalculateTicketPrice(int customerAge)
        {
            double ticketPrice = 0;
            if (customerAge < 20)
            {
                ticketPrice = 80.0;
                Console.WriteLine($"Youth price: {ticketPrice}");
            }
            else if (customerAge > 64)
            {
                ticketPrice = 90.0;
                Console.WriteLine($"Pensioner price: {ticketPrice}");
            }
            else
            {
                ticketPrice = 120.0;
                Console.WriteLine($"Standard price: {ticketPrice}");
            }
            return ticketPrice;
        }
    }
}
