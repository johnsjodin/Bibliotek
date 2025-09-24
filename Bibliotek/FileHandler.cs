using Bibliotek;
using System.Text.Json;

internal static class FileHandler
{
    public static void SaveToFile(List<Book> books, string filePath)
    {
        try
        {
            string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fel vid sparande: " + ex.Message);
        }
    }

    public static List<Book> LoadFromFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
                return new List<Book>(); // tom lista om filen inte finns

            string json = File.ReadAllText(filePath);
            var books = JsonSerializer.Deserialize<List<Book>>(json);

            return books ?? new List<Book>();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fel vid inläsning: " + ex.Message);
            return new List<Book>(); // returnera tom lista om det går fel
        }
    }
}
