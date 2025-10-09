namespace Bibliotek
{
    public class Statistics
    {
        public static void LibraryStatistics(List<Book> books)
        {
            Console.WriteLine("Statistik");

            //Hur många gånger som boken har lånats.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAntal gånger lånade: ");
            Console.ResetColor();
            foreach (var book in books)
            {
                //Console.WriteLine($"{book.Title} av {book.Author} - Lånad {book.BorrowCount} gånger");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Title);
                Console.ResetColor();
                Console.Write(" av ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Author);
                Console.ResetColor();
                Console.Write($" - Lånad {book.BorrowCount} gånger");
            }

            //Tillgängliga böcker.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTillgängliga böcker :");
            Console.ResetColor();
            foreach (var book in books.Where(b => !b.IsBorrowed))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Title);
                Console.ResetColor();
                Console.Write(" av ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Author);
                Console.ResetColor();
            }

            //Top 3 mest lånade böckerna.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTop 3 mest lånade böcker: :");
            Console.ResetColor();
            foreach (var book in books.OrderByDescending(b => b.BorrowCount).Take(3))
            {         
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(book.Title);
                Console.ResetColor();
                Console.WriteLine($" — {book.BorrowCount} gånger");
            }
        }
    }
}
