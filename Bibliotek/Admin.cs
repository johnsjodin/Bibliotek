namespace Bibliotek
{
    internal class Admin : User
    {
        public Admin() { }
        public override void ShowMenu()
        {
            Console.WriteLine("\nAdmin-meny:");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Sök efter bok via titel eller författare");
            Console.WriteLine("3. Sök efter bok via ISBN-kod");
            Console.WriteLine("4. Ta bort bok");
            Console.WriteLine("5. Visa alla böcker");
            Console.WriteLine("6. Logga ut");

            string choice = Console.ReadLine();

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
                    Console.WriteLine("Ta bort");
                    break;
                case "5":
                    Console.WriteLine("Visa alla");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}
