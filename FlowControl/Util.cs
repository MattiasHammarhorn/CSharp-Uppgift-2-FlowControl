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

        // Helper method for calculating the price of a ticket and what the type of customer
        // they are based on their age
        public static double CalculateTicketPrice(int customerAge, out string customerType)
        {
            double ticketPrice = 0;
            if (customerAge < 20)
            {
                if (customerAge < 5)
                    ticketPrice = 0.0;
                else
                    ticketPrice = 80.0;

                customerType = "Youth";
            }
            else if (customerAge > 64)
            {
                if(customerAge > 100)
                    ticketPrice = 0.0;
                else
                    ticketPrice = 90.0;
                customerType = "Pensioner";
            }
            else
            {
                ticketPrice = 120.0;
                customerType = "Standard";
            }
            return ticketPrice;
        }
    }
}
