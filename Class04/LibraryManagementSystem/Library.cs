using LibraryManagementSystem.Models;

namespace LibraryManagementSystem;

public class Library
{
    private readonly List<ILibraryItem> _items = new();
    
    public void AddItem(ILibraryItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(ILibraryItem item)
    {
        _items.Remove(item);
    }

    public void BorrowItem(ILibraryItem item)
    {
        item.BorrowItem();
    }

    public void ReturnItem(ILibraryItem item)
    {
        item.ReturnItem();
    }

    public void DisplayItems()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item.GetDetails());
        }
    }

    public void SeedItems()
    {
        var comic = new Comic
        {
            Title = "The Amazing Spiderman",
            Author = "Stan Lee",
            Artist = "Steve Ditko",
            YearPublished = 1963
        };

        var book1 = new Book
        {
            Title = "The Catcher in the Rye",
            Author = "J.D. Salinger",
            ISBN = "978-3-16-148410-0",
            YearPublished = 1951
        };
        var book2 = new Book
        {
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            ISBN = "978-3-16-148410-1",
            YearPublished = 1925
        };

        var dvd = new Dvd
        {
            Title = "The Godfather",
            Author = "Francis Ford Coppola",
            DurationInMinutes = 175,
            YearPublished = 1972
        };

        AddItem(comic);
        AddItem(book1);
        AddItem(book2);
        AddItem(dvd);
    }
}