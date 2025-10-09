namespace Bibliotek
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get;  set; }
        public int BorrowCount { get; set; }
        public string Available => IsBorrowed ? "Utlånad" : "Tillgänglig";

        public Book() { }

        // Konstruktor som initierar en bok med ISBN, titel och författare
        public Book(int isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Låna bok och öka värdet på antal lånade böcker under statistik
        public bool Borrow()
        {
            if (IsBorrowed) return false;
            IsBorrowed = true;
            BorrowCount++;
            return true;  
        }

        // Lämna tillbaka bok
        public bool Return()
        {
            if (!IsBorrowed) return false;
            IsBorrowed = false;
            return true;
        }

        // Sökfunktion: söktitel eller författare
        public bool Matches(string term) =>
            Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
            Author.Contains(term, StringComparison.OrdinalIgnoreCase);

        public override string ToString() => $"{Title} — {Author} (ISBN: {ISBN}) [{Available}]";
    }
}
