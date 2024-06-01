namespace Exercise102;

// Step 2: Implement the interface
public class Book : IBook
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public string GetBookInfo()
    {
        return $"Id: {Id}, Title: {Title}, Author: {Author}, Year: {Year}";
    }
}
