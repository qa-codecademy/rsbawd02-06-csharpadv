namespace Exercise102;

public interface IBook
{
    int Id { get; set; }
    string Title { get; set; }
    string Author { get; set; }
    int Year { get; set; }
    string GetBookInfo();
}
