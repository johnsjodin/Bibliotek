using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Meny
    {
        public static void LibraryMenu()
            {
            Console.WriteLine("\nBibliotekarie meny:");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Ta bort bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Logga ut");

                string choice = Console.ReadLine();

                // Hantera bibliotekariens val här
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Lägg till bok...");
                        break;
                    case "2":
                        Console.WriteLine("Ta bort bok...");
                        break;
                    case "3":
                        Console.WriteLine("Visa alla böcker...");
                        break;
                    case "4":
                        Console.WriteLine("Loggar ut...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }
}
