namespace Bibliotek
{
    internal class LogIn
    {
        private static List<User> users = new List<User>
        {
            // Här finns en bibliotekarie, en låntagare och en administratör.
            new Librarian { Name = "librarian", Password = "librarian123" },
            new Borrower { Name = "borrower", Password = "borrower123" },
            new Admin { Name = "admin", Password = "admin123" }
        };

        // Metod för att logga in en användare
        public static User Login()
        {
            Console.WriteLine("\nVänligen logga in med din användare.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Användarnamn: ");
            string name = ValidateInput.GetString().ToLower();
            Console.Write("Lösenord: ");
            string password = ValidateInput.GetString();
            Console.ResetColor();

            User foundUser = null;

            // Loopar igenom listan med användare och letar efter match
            foreach (User u in users)
            {
                if (u.Name == name && u.Password == password)
                {
                    foundUser = u;
                    break;
                }
            }

            if (foundUser != null)
            {
                Console.Clear();
                return foundUser;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFel användarnamn eller lösenord.");
                Console.ResetColor();
                return null;
            }
        }
    }
}
