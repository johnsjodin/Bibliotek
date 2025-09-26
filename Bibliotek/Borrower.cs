namespace Bibliotek
{
    internal class Borrower : User
    {
        public Borrower() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nLåntagare-meny:");
            Console.WriteLine("1. Låna bok");
            Console.WriteLine("2. Lämna tillbaka bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = ValidateInput.GetString();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Låna");

                    break;
                case "2":
                    Console.WriteLine("Lämna");
                    break;
                case "3":
                    Console.WriteLine("Visa alla böcker...");
                    break;
                case "4":
                    Console.WriteLine("Loggar ut...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
<<<<<<< Updated upstream
=======

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

        private void DisplayAllBooks(BookRepository repo) //Here updated method name
        {
            Console.WriteLine("\nTillgängliga böcker:");
            repo.ListAll();
        }

        private void SearchBook(BookRepository repo) //Here updated method name
        {
            Console.Write("Ange sökord (titel eller författare): ");
            string searchTerm = ValidateInput.GetString();
            repo.SearchBook();
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
>>>>>>> Stashed changes
    }
}