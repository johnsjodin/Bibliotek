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
            static void BorrowerMenu()
            {
                Console.WriteLine("\nLåntagarmeny:");
               
                Console.WriteLine("1. Låna bok");
                Console.WriteLine("2. Återlämna bok");
                Console.WriteLine("3. Visa lånade böcker");
                Console.WriteLine("4. Logga ut");
               
            }

            static void LibraryMenu()
            {
                Console.WriteLine("\nBibliotekarie meny:");
                
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Ta bort bok");
                Console.WriteLine("3. Visa alla böcker");
                Console.WriteLine("4. Logga ut");
               
            }
        }
    }
}
