namespace Bibliotek
{
    internal class ValidateInput
    {
        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");
            }
            return intInput;
        }
        public static double GetDouble()
        {
            double doubleInput;
            while (!double.TryParse(Console.ReadLine(), out doubleInput))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");
            }
            return doubleInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");
                stringInput = Console.ReadLine();
            }
            return stringInput;
        }
        public static Book ValidateBookInput()
        {
            Console.Write("Ange titel: ");
            string title = ValidateInput.GetString();
            Console.Write("Ange författare: ");
            string author = ValidateInput.GetString();
            Console.Write("Ange ISBN (endast siffror): ");
            int isbn = ValidateInput.GetInt();
            return new Book(isbn, title, author);
        }
    }
}
