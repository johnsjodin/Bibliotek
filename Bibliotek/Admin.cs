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

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════╗");
                Console.WriteLine("║ Admin Meny ║");
                Console.WriteLine("╚════════════╝");
                Console.ResetColor();
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Sök efter bok");
                Console.WriteLine("3. Ta bort bok");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Logga ut\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ange val: ");
                Console.ResetColor();

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
                        return;
                    default:
                        ValidateInput.ShowErrorMessage("Ogiltigt val. Vänligen försök igen.");
                        break;
                }
            }
        }
    }
}