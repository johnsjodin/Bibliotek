namespace Bibliotek
{
    internal class Librarian : User
    {
        public Librarian() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nBibliotekarie-meny:");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Sök efter bok via titel eller författare");
            Console.WriteLine("3. Sök efter bok via ISBN-kod");
            Console.WriteLine("4. Visa alla böcker");
            Console.WriteLine("5. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = ValidateInput.GetString();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Låna");
                    break;
                case "2":
                    Console.WriteLine("Söktitel");
                    break;
                case "3":
                    Console.WriteLine("SökISBN");
                    break;
                case "4":
                    Console.WriteLine("Visa alla");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}