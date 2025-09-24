namespace Bibliotek
{
    internal class LoggaIn
    {
        private static List<User> users = new List<User>
        {
            new Librarian { Name = "librarian", Password = "librarian123" },
            new Borrower { Name = "borrower", Password = "borrower123" },
            new Admin { Name = "admin", Password = "admin123" }
        };

        public static User Login()
        {
            Console.Write("Användarnamn: ");
            string name = ValidateInput.GetString().ToLower();
            Console.Write("Lösenord: ");
            string password = ValidateInput.GetString();

            User foundUser = null;

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
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Välkommen {foundUser.Name.ToUpper()}!");
                Console.ResetColor();
                return foundUser;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel användarnamn eller lösenord.");
                Console.ResetColor();
                return null;
            }
        }
    }
}
