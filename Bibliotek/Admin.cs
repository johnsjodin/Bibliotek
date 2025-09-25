using static System.Reflection.Metadata.BlobBuilder;

namespace Bibliotek
{
    internal class Admin : User
    {
        public Admin() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nAdmin-meny:");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Sök efter bok");
            Console.WriteLine("3. Ta bort bok");
            Console.WriteLine("4. Visa alla böcker");
            Console.WriteLine("5. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = ValidateInput.GetString();

            // Hantera admins val här
            switch (choice)
            {
                case "1":
                    Book book = ValidateInput.ValidateBookInput();
                    repo.AddBook(book);
                    break;
                case "2":
                    Console.Write("Ange söksträng: ");
                    string term = ValidateInput.GetString();
                    var results = repo.SearchBook(term);
                    foreach (var b in results)
                    {
                        Console.WriteLine($"{b.Title} av {b.Author}, ISBN: {b.ISBN}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Ta bort bok");
                    Console.WriteLine();
                    Console.Write("Ange ISBN på boken som ska tas bort: ");
                    int isbnToRemove = ValidateInput.GetInt();
                    if (repo.RemoveBook(isbnToRemove))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Boken med ISBN {isbnToRemove} har tagits bort.");
                        
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ingen bok med ISBN {isbnToRemove} finns i systemet.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Visa alla");
                    repo.ListAll();
                    break;
                case "5":
                    Console.WriteLine("Loggar ut...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}
