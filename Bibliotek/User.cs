namespace Bibliotek
{
    abstract class User : IMenuable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public abstract void ShowMenu(BookRepository repo);
    }
}