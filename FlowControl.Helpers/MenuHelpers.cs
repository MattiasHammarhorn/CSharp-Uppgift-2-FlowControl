namespace FlowControl.Helpers
{
    public class MenuHelpers
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Flow Control menu!" +
                "\nTo navigate through the program, use the options in the menu below:" +
                "\n0. Exit" +
                "\n1. Check ticket prices (single)" +
                "\n2. Check ticket prices (multiple)" +
                "\n3. Write an input and see it repeat 10 times" +
                "\n4. Write a sentence and see the third word displayed");
        }
    }
}
