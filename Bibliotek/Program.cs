namespace Bibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new BookRepository();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      * * * * * * * * * * * * * * * *");
            Console.WriteLine("      * Välkommen till biblioteket! *");
            Console.WriteLine("      * * * * * * * * * * * * * * * *");
            Console.ResetColor();
            Console.WriteLine("\nVänligen logga in med din användare.\n");

            //Console.WriteLine("\nÄr du bibliotekarie tryck 1:"); // Lärde mig en ny funktion \n som gör radbrytningar
            //Console.WriteLine("Är du låntagare tryck 2:");
            //Console.WriteLine("För att avsluta tryck 3:");

            //string userChoice = Console.ReadLine();

            User loggedInUser = LogIn.Login();

            while (true)
            {
                if (loggedInUser != null)
                {
                    loggedInUser.ShowMenu(repo);
                }
                else
                {
                    Console.WriteLine("\nInloggning misslyckades.");
                    Console.Write("Tryck 1 för att försöka igen, eller annan knapp för att avsluta: ");
                    string retryChoice = Console.ReadLine();
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