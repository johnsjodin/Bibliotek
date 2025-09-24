namespace Bibliotek
{
    internal class BookRepository
    {
        private List<Book> _books = new List<Book>();
        private string _filePath = "../../../books.json";

        public BookRepository()
        {
            _books = FileHandler<Book>.LoadFromFile(_filePath);
        }

        // Lägg till bok i listan
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // Ta bort bok via I-S-B-N
        public bool RemoveBook(int isbn)
        {
            var book = _books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null) return false;
            _books.Remove(book);
            return true;
        }

        // Hitta bok via ISBN
        public Book? FindBook(int isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        // Sök böcker via titel eller författare
        public List<Book> Search(string term)
        {
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
