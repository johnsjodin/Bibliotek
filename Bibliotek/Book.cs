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

        // Constructor for books without ISBN
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        // Constructor for books with ISBN
        public Book(int isbn, string title, string author) : this(title, author)
        {
            ISBN = isbn;
        }
        // Methods for borrowing and returning books
        public bool Borrow()
        {
            if (IsBorrowed) return false;
            IsBorrowed = true;
            return true;
        }
        // Method for returning a book
        public bool Return()
        {
            if (!IsBorrowed) return false;
            IsBorrowed = false;
            return true;
        }
        // Method to check if a book matches a search term
        public bool Matches(string term) =>
            Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
            Author.Contains(term, StringComparison.OrdinalIgnoreCase);

        public override string ToString() => $"{Title} — {Author} [{Available}]";


    }
}
