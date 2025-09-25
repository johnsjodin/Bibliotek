namespace Bibliotek
{
    internal class BookRepository
    {
        private List<Book> _books = new List<Book>();
        private string _filePath = "../../../books.json";
        

      

        // Lägg till bok i listan
        public void AddBook(Book book)
        {
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
            if (book == null)
                return false;

            _books.Remove(book);
            FileHandler.SaveToFile(_books, _filePath);
            return true;
        }
        public void RemoveBookInteraction()
        {
            Console.WriteLine("Ta bort bok");
            Console.WriteLine();
            Console.Write("Ange ISBN på boken som ska tas bort: ");
            int isbnToRemove = ValidateInput.GetInt();

            if (RemoveBook(isbnToRemove))
            {
                Console.WriteLine();
                Console.WriteLine($"Boken med ISBN {isbnToRemove} har tagits bort.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Ingen bok med ISBN {isbnToRemove} finns i systemet.");
            }
        }

  

        // Hitta bok via ISBN
        public Book? FindBook(int isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> SearchBook(string term)
        {
            // Försök tolka term som ISBN
            if (int.TryParse(term, out int isbn))
            {
                var book = FindBook(isbn);
                return book != null ? new List<Book> { book } : new List<Book>();
            }
            // Annars sök på titel/författare
            return _books.Where(b => b.Matches(term)).ToList();
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
