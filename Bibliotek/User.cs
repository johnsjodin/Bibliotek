namespace Bibliotek
{
    abstract class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public abstract void ShowMenu();
    }
}