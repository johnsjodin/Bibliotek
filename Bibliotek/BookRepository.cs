namespace Bibliotek
{
    internal class BookRepository
    {
        private List<Book> books = new List<Book>();

        // Lägg till bok i listan
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Ta bort bok via I-S-B-N
        public bool RemoveBook(int isbn)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null) return false;
            books.Remove(book);
            return true;
        }

        // Hitta bok via ISBN
        public Book? FindBook(int isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        // Sök böcker via titel eller författare
        public List<Book> Search(string term)
        {
            return books.Where(b => b.Matches(term)).ToList();
        }

        // Lista alla böcker
        public void ListAll()
        {
            if (!books.Any())
            {
                Console.WriteLine("Inga böcker i systemet.");
                return;
            }

            foreach (var book in books)
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
