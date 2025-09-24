namespace Bibliotek
{
    internal class Admin : User
    {
        public Admin() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nAdmin-meny:");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Sök efter bok via titel eller författare");
            Console.WriteLine("3. Sök efter bok via ISBN-kod");
            Console.WriteLine("4. Ta bort bok");
            Console.WriteLine("5. Visa alla böcker");
            Console.WriteLine("6. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = Console.ReadLine();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nLägg till bok\n");
                    Console.Write("Ange titel på boken du vill lägga till: ");
                    string title = Console.ReadLine();
                    Console.Write("Ange författarens namn: ");
                    string author = Console.ReadLine();
                    Console.Write("Ange bokens ISBN-kod: ");
                    int isbn = int.Parse(Console.ReadLine());
                    Book book = new Book(isbn, title, author);
                    repo.AddBook(book);
                    break;
                case "2":
                    Console.WriteLine("Sök titel");
                    break;
                case "3":
                    Console.WriteLine("Sök ISBN");
                    break;
                case "4":
                    Console.WriteLine("Ta bort bok");
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
