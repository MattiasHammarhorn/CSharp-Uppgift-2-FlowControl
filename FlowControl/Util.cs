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
        public static string AskForAString()
        {
            bool isValidString = false;
            string userInput = String.Empty;

            do
            {
                Console.Write("Please enter a value: ");
                userInput = Console.ReadLine();

                if (String.IsNullOrEmpty(userInput) || String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error, you must enter a valid string.");
                }
                else
                {
                    isValidString = true;
                }
            } while (!isValidString);

            return userInput;
        }

        // Helper method for asking for and validating an integer
        public static int AskForAnInt()
        {
            bool isValidInt = false;
            string userInput = String.Empty;
            int intToReturn = 0;
            do
            {
                Console.Write("Please enter a number here: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out intToReturn))
                {
                    isValidInt = true;
                }
                else
                {
                    Console.WriteLine("Error, you must enter a valid number.");
                }
            } while (!isValidInt);
            return intToReturn;
        }
    }
}
