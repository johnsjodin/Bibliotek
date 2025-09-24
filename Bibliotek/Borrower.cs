using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Borrower
    {
        public static void BorrowerMenu()

        {
            Console.WriteLine("\nLåntagarmeny:");
            Console.WriteLine("1. Låna bok");
            Console.WriteLine("2. Återlämna bok");
            Console.WriteLine("3. Visa lånade böcker");
            Console.WriteLine("4. Logga ut");

            string choice = Console.ReadLine();

            // Hantera låntagarens val här
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Låna bok...");
                    break;
                case "2":
                    Console.WriteLine("Återlämna bok...");
                    break;
                case "3":
                    Console.WriteLine("Visa lånade böcker...");
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
