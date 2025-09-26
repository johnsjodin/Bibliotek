namespace Bibliotek
{
    internal class ValidateInput
    {
        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
            }
            return intInput;
        }
        public static double GetDouble()
        {
            double doubleInput;
            while (!double.TryParse(Console.ReadLine(), out doubleInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
            }
            return doubleInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
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
    }
}
