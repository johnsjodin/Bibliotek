
using System;
using Bibliotek;

namespace Bibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string adminUsername = "bibliotekarie";
            int adminPassword = 1234;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      * * * * * * * * * * * * * * * *");
            Console.WriteLine("      * Välkommen till biblioteket! *");
            Console.WriteLine("      * * * * * * * * * * * * * * * *");
            Console.ResetColor();

            
            Console.WriteLine("\nÄr du bibliotekarie tryck 1:"); // Lärde mig en ny funktion \n som gör radbrytningar
            Console.WriteLine("Är du låntagare tryck 2:");
            Console.WriteLine("För att avsluta tryck 3:");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("Ange lösenord:");
                        string input = Console.ReadLine();
                        bool lyckades = int.TryParse(input, out int enteredPassword);

                        if (!lyckades)
                        {
                            Console.WriteLine("Fel format på lösenordet, försök igen.");
                            continue;
                        }

                        if (enteredPassword == adminPassword)
                        {
                            Console.Clear();
                            Console.WriteLine("Inloggning lyckades som bibliotekarie.");
                            Meny.LibraryMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fel lösenord, försök igen.");
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("Inloggad som låntagare.");
                    Borrower.BorrowerMenu();
                    break;

                case "3":
                    Console.WriteLine("Avslutar.");
                    Console.WriteLine("Tryck på valfri knapp för att avsluta...");
                    Console.ReadKey(); 
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
}