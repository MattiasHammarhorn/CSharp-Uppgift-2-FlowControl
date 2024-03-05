namespace FlowControl.Helpers
{
    public class MenuHelpers
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Flow Control menu!" +
                "\nTo navigate through the program, use the options in the menu below:\n" +
                "\n0. Exit" +
                "\n1. Check ticket prices (single)" +
                "\n2. Check ticket prices (multiple)" +
                "\n3. Write an input and see it repeat 10 times" +
                "\n4. Write a sentence and see the third word displayed");
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        // Displays the price of a ticket and what kind of type the customer is
        public static void DisplayTicketPriceAndCustomerType(double ticketPrice, string customerType)
        {
            Console.WriteLine($"{customerType} price: {ticketPrice}");
        }

        // Displays the number of customers and the summed up price of their tickets
        public static void DisplaySumOfTicketPrices(double sumOfTicketPrices, int length)
        {
            Console.WriteLine($"The maximum ticket price for {length} person(s) is: {sumOfTicketPrices}");
        }
    }
}
