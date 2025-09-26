namespace Bibliotek
{
    internal class Librarian : User, IMenuable
    {
        public Librarian() { }

        public override void ShowMenu(BookRepository repo)
        {
            int choice = 0;

            while (choice != 4)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("┌───────────────┐");
                Console.WriteLine("│Librarian- Meny│");
                Console.WriteLine("└───────────────┘");
                Console.ResetColor();
                Console.WriteLine("1. Lägg till bok.");
                Console.WriteLine("2. Visa alla böcker.");
                Console.WriteLine("3. Sök efter en bok.");
                Console.WriteLine("4. Avsluta\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ange val: ");
                Console.ResetColor();


                choice = ValidateInput.GetInt();

                switch (choice)
                {
                    case 1:
                        repo.AddBook();
                        break;
                    case 2:
                        repo.ListAll();
                        break;
                    case 3:
                        repo.SearchBook();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Loggar ut...");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}