namespace Bibliotek
{
    internal class ValidateInput
    {
        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                ShowErrorMessage("Felaktig inmatning, försök igen.");
                Console.ResetColor();
            }
            return intInput;
        }
        public static double GetDouble()
        {
            double doubleInput;
            while (!double.TryParse(Console.ReadLine(), out doubleInput))
            {
                ShowErrorMessage("Felaktig inmatning, försök igen.");
                Console.ResetColor();
            }
            return doubleInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(stringInput))
            {
                ShowErrorMessage("Felaktig inmatning, försök igen.");
                stringInput = Console.ReadLine();
            }
            return stringInput;
        }
        public static Book ValidateBookInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ange titel: ");
            string title = ValidateInput.GetString();
            Console.Write("Ange författare: ");
            string author = ValidateInput.GetString();
            Console.Write("Ange ISBN (endast siffror): ");
            int isbn = ValidateInput.GetInt();
            Console.ResetColor();
            return new Book(isbn, title, author);
        }
        public static void ShowErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void ShowSuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
