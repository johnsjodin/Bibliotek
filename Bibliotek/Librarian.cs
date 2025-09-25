namespace Bibliotek;

internal class Librarian : User
{

    public override void ShowMenu(BookRepository repo)
    {
        int choice = 0;

        while (choice != 4)
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
            Console.WriteLine("3. Sök efter en bok.");
            Console.WriteLine("4. Avsluta");

            Console.Write("Ange ditt val: ");
            choice = ValidateInput.GetInt();

            switch (choice)
            {
                case 1:
                    repo.AddBook();
                    break;
                case 2:
                    repo.ListAll();
                    break;
                case 3:
                    repo.SearchBook();                
                    break;

                case 4:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Librarian menyn avslutas");
                    Console.ResetColor();
                    Clear.ClearConsole();
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                    break;
            }
        }
    }
}