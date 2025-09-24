using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Librarian : User
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
            }
        }
    }
}
