namespace Bibliotek
{
    internal class Book
    {
        public int ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; private set; }
        public string Available => IsBorrowed ? "Utlånad" : "Tillgänglig";

        // Constructor för böcker med I-S-B-N
        public Book(int isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Låna bok
        public bool Borrow()
        {
            if (IsBorrowed) return false;
            IsBorrowed = true;
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
