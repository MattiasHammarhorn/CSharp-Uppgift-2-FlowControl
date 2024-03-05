using FlowControl.Helpers;

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
                string menuChoice = Util.AskForAString();

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
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            } while (!isShutDown);
        }

        private static void AskForAgeAndCalculateTicketPrice()
        {
            Console.Clear();
            int customerAge = Util.AskForAnInt();
            double ticketPrice = CalculateTicketPrice(customerAge);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private static void AskForMultipleAgesAndCalculateTicketPrice()
        {
            Console.Clear();
            Console.Write("Please enter the amount of persons you would like to order tickets for: ");
            int length = Util.AskForAnInt();
            double sumOfTicketPrices = 0.0;

            for (int i = 0; i < length; i++)
            {
                bool inputIsValid = false;
                string userInput = string.Empty;
                int customerAge = 0;

                customerAge = Util.AskForAnInt();
                sumOfTicketPrices += CalculateTicketPrice(customerAge);
            }

            Console.WriteLine($"The maximum ticket price for {length} person(s) is: {sumOfTicketPrices}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private static void LoopUserInputTenTimes()
        {
            string input = Util.AskForAString();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input}, ");
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        #region Helper methods, todo: move to Helper classes

        private static void SplitUserInputByWhiteSpace()
        {
            bool inputIsValid = false;
            string thirdWord = "";

            do
            {
                Console.Write("Please enter a sentence of at least three words of any choice:");
                string userInput = Console.ReadLine();

                var words = userInput.Split(' ');
                if (words.Length < 3)
                {
                    Console.WriteLine("Error: the sentence must contain at least 3 words.");
                }
                else
                {
                    thirdWord = words[2];
                    inputIsValid = true;
                }
            } while (!inputIsValid);

            Console.WriteLine(thirdWord);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        private static double CalculateTicketPrice(int customerAge)
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
        #endregion
    }
}
