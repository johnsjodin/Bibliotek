using System.Reflection.Metadata.Ecma335;
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
                   
                    repo.AddBook();
                    break;
                case "2":
                    repo.SearchBook();
                    break;

                case "3":
                    repo.RemoveBookInteraction();
                    break;
                  

                case "4":
                    Console.WriteLine("Visa alla");
                    repo.ListAll();
                    break;
                case "5":
                    Console.WriteLine("Loggar ut...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}
