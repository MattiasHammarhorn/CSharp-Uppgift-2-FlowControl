using FlowControl.Helpers;
using System.Net.Sockets;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isShutDown = false;

            do
            {
                MenuHelpers.DisplayMainMenu();
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        AskForAgeAndCalculateTicketPrice();
                        break;
                    case "2":
                        AskForMultipleAgesAndCalculateTicketPrice();
                        break;
                    case "3":
                        LoopUserInputTenTimes();
                        break;
                    case "4":
                        SplitUserInputByWhiteSpace();
                        break;
                    default:
                        Console.WriteLine("Error: you must enter a valid menu choice.");
                        break;
                }
            } while (!isShutDown);
        }

        private static void AskForAgeAndCalculateTicketPrice()
        {
            string customerType = String.Empty; // Variable for storing whether customer is youth, standard or pensioner
            int customerAge = Util.AskForAnInt("age");
            double ticketPrice = Util.CalculateTicketPrice(customerAge, out customerType);
            MenuHelpers.DisplayTicketPriceAndCustomerType(ticketPrice, customerType);
            MenuHelpers.PressAnyKeyToContinue();
        }

        private static void AskForMultipleAgesAndCalculateTicketPrice()
        {
            double sumOfTicketPrices = 0.0;
            int length = Util.AskForAnInt("amount of persons you would like to order tickets for");
            // Loop through the number of customers and ask for their age
            for (int i = 0; i < length; i++)
            {
                int customerAge = Util.AskForAnInt("age");
                string customerType = String.Empty; // Unused variable, mainly to stop CalculateTicketPrice from throwing an error

                sumOfTicketPrices += Util.CalculateTicketPrice(customerAge, out customerType);
            }
            MenuHelpers.DisplaySumOfTicketPrices(sumOfTicketPrices, length);
            MenuHelpers.PressAnyKeyToContinue();
        }

        private static void LoopUserInputTenTimes()
        {
            string input = Util.AskForAString("input");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input}, ");
            }

            MenuHelpers.PressAnyKeyToContinue();
        }

        private static void SplitUserInputByWhiteSpace()
        {
            bool inputIsValid = false;
            string thirdWord = "";

            do
            {
                Console.Write("Please enter a sentence of at least three words of any choice:");
                string userInput = Console.ReadLine(); // split into string valid.

                var words = userInput.Split(' ');
                if (words.Length < 3)
                {
                    Console.WriteLine("Error: the sentence must contain at least 3 words.");
                } // split into array valid.
                else
                {
                    thirdWord = words[2];
                    inputIsValid = true;
                }
            } while (!inputIsValid);

            Console.WriteLine(thirdWord);
            MenuHelpers.PressAnyKeyToContinue();
        }
    }
}
