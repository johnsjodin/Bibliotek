namespace Bibliotek
{
    internal class Validering
    {
        public static int GetInt()
        {
            int Heltal;
            while (!int.TryParse(Console.ReadLine(), out Heltal))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");

            }

            return Heltal;

        }

        public static double GetDouble()
        {
            double tal;
            while (!double.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");

            }

            return tal;

        }

        public static string GetString()
        {
            string text = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Felaktig inmatning, försök igen:");
                text = Console.ReadLine();
            }
            return text;
        }
    }
}
