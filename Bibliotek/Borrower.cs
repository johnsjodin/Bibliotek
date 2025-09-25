namespace Bibliotek
{
    internal class Borrower : User
    {
        public Borrower() { }
        public override void ShowMenu(BookRepository repo)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                DisplayHeader();
                DisplayMenuOptions();

                string choice = ValidateInput.GetString();

                HandleUserChoice(choice, repo);

                if (choice != "5") // Visa inte paus vid utloggning
                {
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                }
            }
        }

        private void DisplayHeader()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            Console.WriteLine("***Borrower Menu***");
            Console.WriteLine("--------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void DisplayMenuOptions()
        {
            Console.WriteLine("1. Låna bok");
            Console.WriteLine("2. Lämna tillbaka bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Sök efter bok");
            Console.WriteLine("5. Logga ut\n");
            Console.Write("Ange val: ");
        }

        private void HandleUserChoice(string choice, BookRepository repo)
        {
            switch (choice)
            {
                case "1":
                    BorrowBook(repo);
                    break;
                case "2":
                    ReturnBook(repo);
                    break;
                case "3":
                    DisplayAllBooks(repo);
                    break;
                case "4":
                    SearchBook(repo);
                    break;
                case "5":
                    Console.WriteLine("Loggar ut...");
                    break;
                default:
                    ShowErrorMessage("Ogiltigt val. Försök igen.");
                    break;
            }
        }

        private void BorrowBook(BookRepository repo)
        {
            Console.Write("\nAnge ISBN för att låna bok: ");
            if (int.TryParse(Console.ReadLine(), out int isbn))
            {
                try
                {
                    if (repo.BorrowBook(isbn))
                    {
                        ShowSuccessMessage("Boken har lånats!");
                    }
                    else
                    {
                        ShowErrorMessage("Boken kunde inte lånas. Den kan vara utlånad eller saknas.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Ett fel uppstod vid utlåning: {ex.Message}");
                }
            }
            else
            {
                ShowErrorMessage("Ogiltigt ISBN.");
            }
        }

        private void ReturnBook(BookRepository repo)
        {
            Console.Write("\nAnge ISBN för att lämna tillbaka bok: ");
            if (int.TryParse(Console.ReadLine(), out int isbn))
            {
                try
                {
                    if (repo.ReturnBook(isbn))
                    {
                        ShowSuccessMessage("Boken har lämnats tillbaka!");
                    }
                    else
                    {
                        ShowErrorMessage("Boken kunde inte lämnas tillbaka. Den finns kanske inte i systemet.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Ett fel uppstod vid återlämning: {ex.Message}");
                }
            }
            else
            {
                ShowErrorMessage("Ogiltigt ISBN.");
            }
        }

        private void DisplayAllBooks(BookRepository repo)
        {
            Console.WriteLine("\nTillgängliga böcker:");
            repo.ListAll(); // <-- FIX NEEDED

            // If ListAll() returns void, update to:
            // repo.ListAll();

            // Remove usage of 'books' below, or refactor ListAll() to return List<Book>
        }

        private void SearchBook(BookRepository repo)
        {
            Console.Write("Ange sökord (titel eller författare): ");
            string searchTerm = ValidateInput.GetString();

            try
            {

                repo.SearchBook(); // Calls the repository's search method instead.
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Ett fel uppstod vid sökning: {ex.Message}");
            }
        }

        private void ShowErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private void ShowSuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
