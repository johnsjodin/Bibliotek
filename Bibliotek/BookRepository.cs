namespace Bibliotek
{
    internal class BookRepository
    {
        private List<Book> _books = new List<Book>();
        private string _filePath = "../../../books.json";

        public BookRepository()
        {
            _books = FileHandler.LoadFromFile(_filePath);
            
        }

        // Lägg till bok i listan
        public void AddBook()
        {
            Book book = ValidateInput.ValidateBookInput();
            if (FindBook(book.ISBN) != null)
            {
                
                ValidateInput.ShowErrorMessage($"Boken med ISBN {book.ISBN} finns redan i systemet.");
                return;
            }

            ValidateInput.ShowSuccessMessage($"Boken '{book.Title}' av {book.Author} med ISBN {book.ISBN} har lagts till.");
            _books.Add(book);
            FileHandler.SaveToFile(_books, _filePath);
        }

        // Ta bort bok via I-S-B-N
        public bool RemoveBook(int isbn)
        {
            var book = _books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
                return false;

            _books.Remove(book);
            FileHandler.SaveToFile(_books, _filePath);
            return true;
        }

        public void RemoveBookInteraction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;   
            Console.WriteLine("Ta bort bok");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Ange ISBN på boken som ska tas bort: ");
            int isbnToRemove = ValidateInput.GetInt();

            if (RemoveBook(isbnToRemove))
            {
                ValidateInput.ShowSuccessMessage($"\nBoken med ISBN {isbnToRemove} har tagits bort.");
            }
            else
            {
                ValidateInput.ShowErrorMessage($"\nIngen bok med ISBN {isbnToRemove} hittades.");
            }
        }

        // Hitta bok via I-S-B-N
        public Book? FindBook(int isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public void SearchBook()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("Ange sökord (titel eller författare): ");
            Console.ResetColor();

            string searchTerm = ValidateInput.GetString().ToLower();

            List<Book> matchedBooks = _books.Where(b => b.Title.ToLower().Contains(searchTerm) || b.Author.ToLower().Contains(searchTerm)).ToList();

            if (matchedBooks.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Hittade böcker");
                Console.WriteLine("----------------- ");
                Console.ResetColor();

                foreach (var book in matchedBooks)
                {
                    Console.WriteLine();
                    Console.Write("Titel: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(book.Title);
                    Console.ResetColor();
                    Console.Write(" Författare: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(book.Author);
                    Console.ResetColor();
                    Console.Write(" ISBN: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(book.ISBN);
                    Console.ResetColor();

                    if (book.IsBorrowed)
                    {
                        ValidateInput.ShowErrorMessage($"Status: {book.Available}");
                        Console.WriteLine();
                    }
                    else
                    {
                        ValidateInput.ShowSuccessMessage($"Status: {book.Available}");
                        Console.WriteLine();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                ValidateInput.ShowErrorMessage("Inga böcker matchade din sökning.");
            }
        }

        // Lista alla böcker
        public void ListAll()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Visar alla böcker");
            Console.WriteLine("----------------- ");
            Console.ResetColor();

            if (!_books.Any())
            {
                ValidateInput.ShowErrorMessage("Inga böcker finns i systemet.");
                return;
            }

            foreach (var book in _books)
            {
                Console.WriteLine();
                Console.Write("Titel: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Title);
                Console.ResetColor();
                Console.Write(" Författare: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Author);
                Console.ResetColor();
                Console.Write(" ISBN: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(book.ISBN);
                Console.ResetColor();

                if (book.IsBorrowed)
                {
                    ValidateInput.ShowErrorMessage($"Status: {book.Available}");
                    Console.WriteLine();
                }
                else
                {
                    ValidateInput.ShowSuccessMessage($"Status: {book.Available}");
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
        }

        // Låna en bok
        public void BorrowBook()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAnge ISBN-koden för den bok du vill låna: ");
            Console.ResetColor();
            int isbn = ValidateInput.GetInt();
            var book = FindBook(isbn);
            if (book == null)
            {
                ValidateInput.ShowErrorMessage($"\nIngen bok med ISBN {isbn} hittades.");
            }
            if (book.IsBorrowed)
            {
                ValidateInput.ShowErrorMessage($"\nBoken '{book.Title}' är redan utlånad.");
                return;
            }
            book.Borrow();
            FileHandler.SaveToFile(_books, _filePath);
            ValidateInput.ShowSuccessMessage($"\nDu har nu lånat boken '{book.Title}'.");

        }

        // Lämna tillbaka en bok
        public void ReturnBook()
        {
            Console.Write("\nAnge ISBN-koden för den bok du vill lämna tillbaka: ");
            int isbn = ValidateInput.GetInt();
            var book = FindBook(isbn);
            if (book == null)
            {
                ValidateInput.ShowErrorMessage($"\nIngen bok med ISBN {isbn} hittades.");
                return;
            }
            if (!book.IsBorrowed)
            {
                ValidateInput.ShowErrorMessage($"\nBoken '{book.Title}' är inte utlånad.");
                return;
            }
            book.Return();
            FileHandler.SaveToFile(_books, _filePath);
            ValidateInput.ShowSuccessMessage("Du har nu lämnat tillbaka boken.");

        }
    }
}