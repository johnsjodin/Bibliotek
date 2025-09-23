namespace Bibliotek
{
    internal class Book
    {
        int ISBN;
        string Title;
        string Author;
        bool IsAvailable;
        string available => IsAvailable ? "Tillgänglig" : "Utlånad";

        public static List<Book> Books = new List<Book>();
    }
}
