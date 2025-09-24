 feature/book-repository
using Bibliotek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Borrower : User
    {

        public override void Menu()
        {
            int choice = 0;

            while (choice != 3)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------------------");
                Console.WriteLine("***Librarian Menu***");
                Console.WriteLine("--------------------");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Lägg till bok.");
                Console.WriteLine("2. Visa alla böcker.");
                Console.WriteLine("3. Avsluta");

                Console.Write("Ange ditt val: ");
                choice = Validering.GetInt();

                switch (choice)
                {
                    case 1:
                        Book.AddBook();
                        break;
                    case 2:
                        Book.ShowAllBooks();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Librarian menyn avslutas");
                        Console.ResetColor();
                        Clear.ClearConsole();
                        Program.Begin();
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                        break;
                }

namespace Bibliotek
{
    internal class Borrower : User
    {
        public Borrower() { }
        public override void ShowMenu(BookRepository repo)
        {
            Console.WriteLine("\nLåntagare-meny:");
            Console.WriteLine("1. Låna bok");
            Console.WriteLine("2. Lämna tillbaka bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Logga ut\n");
            Console.Write("Ange val: ");

            string choice = ValidateInput.GetString();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Låna");
                    break;
                case "2":
                    Console.WriteLine("Lämna");
                    break;
                case "3":
                    Console.WriteLine("Visa alla böcker...");
                    break;
                case "4":
                    Console.WriteLine("Loggar ut...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
               master
            }
        }
    }
}