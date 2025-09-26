namespace Bibliotek
{
    internal class Borrower : User
    {
        public Borrower() { }

        public override void ShowMenu(BookRepository repo)
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("Låntagar-meny\n");
                Console.WriteLine("1. Låna bok");
                Console.WriteLine("2. Lämna tillbaka bok");
                Console.WriteLine("3. Visa alla böcker");
                Console.WriteLine("4. Sök efter bok");
                Console.WriteLine("5. Logga ut\n");
                Console.Write("Ange val: ");

                choice = ValidateInput.GetInt();
                switch (choice)
                {
                    case 1:
                        repo.BorrowBook();
                        break;
                    case 2:
                        repo.ReturnBook();
                        break;
                    case 3:
                        repo.ListAll();
                        break;
                    case 4:
                        repo.SearchBook();
                        break;
                    case 5:
                        Console.WriteLine("Loggar ut...");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }
    }
}