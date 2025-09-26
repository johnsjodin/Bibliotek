namespace Bibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new BookRepository();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║  Välkommen till Biblioteket  ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ResetColor();
            
            

            User loggedInUser = LogIn.Login();
            bool jusLoggedOut = false;

            while (true)
            {
                if(jusLoggedOut)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du har loggat ut.");
                    Console.ResetColor();
                    jusLoggedOut = false;

                }

                if (loggedInUser == null)
                {
                    
                    loggedInUser = LogIn.Login();
                }



                if (loggedInUser != null)
                {
                    loggedInUser.ShowMenu(repo);
                    loggedInUser = null; // Efter meny, logga ut användaren
                    jusLoggedOut = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInloggning misslyckades.");
                    Console.ResetColor();
                    Console.Write("Tryck 1 för att försöka igen, eller annan knapp för att avsluta: ");
                    string retryChoice = ValidateInput.GetString();
                    if (retryChoice == "1")
                    {
                        loggedInUser = LogIn.Login();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}