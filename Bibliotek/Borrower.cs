namespace Bibliotek
{
    internal class Borrower : User
    {
        public Borrower() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nLåntagare-meny:");
            Console.WriteLine("1. Låna bok");
            Console.WriteLine("2. Lämna tillbaka bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = ValidateInput.GetString();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Låna");
                    break;
                case "2":
                    Console.WriteLine("Lämna");
                    break;
                case "3":
                    Console.WriteLine("Visa alla böcker...");
                    break;
                case "4":
                    Console.WriteLine("Loggar ut...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}