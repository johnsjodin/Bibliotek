namespace Bibliotek
{
    internal class Admin : User, IMenuable
    {
        public Admin() { }

        public override void ShowMenu(BookRepository repo)
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("Admin-meny\n");
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Sök efter bok");
                Console.WriteLine("3. Ta bort bok");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Logga ut\n");
                Console.Write("Ange val: ");

                choice = ValidateInput.GetInt();

                // Hantera admins val här
                switch (choice)
                {
                    case 1:
                        repo.AddBook();
                        break;
                    case 2:
                        repo.SearchBook();
                        break;
                    case 3:
                        repo.RemoveBookInteraction();
                        break;
                    case 4:
                        repo.ListAll();
                        break;
                    case 5:
                        Console.WriteLine("Loggar ut...");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }
    }
}