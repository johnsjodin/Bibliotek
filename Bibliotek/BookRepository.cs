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
                Console.WriteLine($"Boken med ISBN {book.ISBN} finns redan i systemet.");
                return;
            }

            Console.WriteLine($"Boken '{book.Title}' av {book.Author} med ISBN {book.ISBN} har lagts till.");
            _books.Add(book);
            FileHandler.SaveToFile(_books, _filePath);
        }

        // Ta bort bok via I-S-B-N
        public bool RemoveBook(int isbn)
        {
            
            var book = _books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null) return false;
            
            _books.Remove(book);
            FileHandler.SaveToFile(_books, _filePath);
            return true;
        }

        // Hitta bok via ISBN
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Hittade böcker:");
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Status: {book.Available}");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Status: {book.Available}");
                        Console.ResetColor();
                        Console.WriteLine();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inga böcker matchade din sökning.");
                Console.ResetColor();
            }
        }


        // Lista alla böcker
        public void ListAll()
        {
            if (!_books.Any())
            {
                Console.WriteLine("Inga böcker i systemet.");
                return;
            }

            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }

        // Låna en bok
        public bool BorrowBook(int isbn)
        {
            var book = FindBook(isbn);
            if (book == null || book.IsBorrowed) return false;
            return book.Borrow();

        }

        // Lämna tillbaka en bok
        public bool ReturnBook(int isbn)
        {
            var book = FindBook(isbn);
            if (book == null || !book.IsBorrowed) return false;
            return book.Return();
        }
    }
}
