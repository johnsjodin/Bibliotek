namespace Bibliotek
{
    internal class ValidateInput
    {
        // Loopar tills inmatningen är en giltig int.
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
        // Loopar tills inmatningen är en giltig double.
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
        // Specialmetod för att skapa en ny bok med validerad input.
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
        // Skriver ut ett felmeddelande i röd färg.
        public static void ShowErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Skriver ut ett lyckat meddelande i grön färg.
        public static void ShowSuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
