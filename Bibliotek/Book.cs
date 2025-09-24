using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Book
    {
        public int ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; private set; }
        public string Available => IsBorrowed ? "Utlånad" : "Tillgänglig";

        // Constructor för böcker utan I-S-B-N
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Constructor för böcker med I-S-B-N
        public Book(int isbn, string title, string author) : this(title, author)
        {
            ISBN = isbn;
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
