// See https://aka.ms/new-console-template for more information

using LibraryManagementSystem;
using LibraryManagementSystem.Models;

Console.WriteLine("*** Library Management System ***");
Console.WriteLine();

var library = new Library();
library.SeedItems();

Console.WriteLine("Items in the library:");
library.DisplayItems();
Console.WriteLine();

while (true)
{
    DisplayOptions();
    
    var option = Console.ReadLine();

    if (option == "1")
    {
        AddNewItem();
    }
    else if (option == "6")
    {
        // TODO: Implement search
        library.DisplayItems();
    }
    else if (option == "0")
    {
        break;
    }
}




void AddNewItem()
{
    Console.WriteLine("Enter the type of item (Comic, Book, Magazine, Dvd):");
    var itemType = Console.ReadLine()!.ToLower();

    if (itemType != "comic" && itemType != "book" && itemType != "magazine" && itemType != "dvd")
    {
        Console.WriteLine("ERROR: Invalid item type.");
        return;
    }

    Console.WriteLine("Enter the title:");
    var title = Console.ReadLine()!;

    Console.WriteLine("Enter the author:");
    var author = Console.ReadLine()!;

    Console.WriteLine("Enter the year published:");
    var yearPublishedInput = Console.ReadLine()!;
    int? yearPublished = string.IsNullOrWhiteSpace(yearPublishedInput) 
        ? null 
        : int.Parse(yearPublishedInput); // TODO: Handle invalid input

    if (itemType == "comic")
    {
        Console.WriteLine("Enter the artist:");
        var artist = Console.ReadLine()!;

        var comic = new Comic
        {
            Title = title,
            Author = author,
            Artist = artist,
            YearPublished = yearPublished
        };
        library.AddItem(comic);
    } 
    else if (itemType == "book") 
    {
        Console.WriteLine("Enter the ISBN:");
        var isbn = Console.ReadLine()!;

        Console.WriteLine("Enter the genre:");
        var genre = Console.ReadLine()!;

        var book = new Book
        {
            Title = title,
            Author = author,
            ISBN = isbn,
            Genre = genre,
            YearPublished = yearPublished
        };
        library.AddItem(book);
    }
    else if (itemType == "magazine")
    {
        Console.WriteLine("Enter the issue number:");
        var issueNumberInput = Console.ReadLine()!;
        var issueNumber = int.Parse(issueNumberInput);

        Console.WriteLine("Enter the publisher:");
        var publisher = Console.ReadLine()!;

        var magazine = new Magazine
        {
            Title = title,
            Author = author,
            IssueNumber = issueNumber,
            Publisher = publisher,
            YearPublished = yearPublished
        };
        library.AddItem(magazine);
    }
    else if (itemType == "dvd")
    {
        Console.WriteLine("Enter the duration:");
        var durationInMinutesInput = Console.ReadLine()!;
        var duration = int.Parse(durationInMinutesInput);

        Console.WriteLine("Enter IMDB rating:");
        var imdbRatingInput = Console.ReadLine()!;
        var imdbRating = int.Parse(imdbRatingInput);

        var dvd = new Dvd
        {
            Title = title,
            Author = author,
            DurationInMinutes = duration,
            Rating = imdbRating,
            YearPublished = yearPublished
        };
        library.AddItem(dvd);
    }
}

void DisplayOptions()
{
    Console.WriteLine();
    Console.WriteLine("Pick one of the following options:");
    Console.WriteLine("1. Add an item");
    Console.WriteLine("2. Remove an item");
    Console.WriteLine("3. Borrow an item");
    Console.WriteLine("4. Return an item");
    Console.WriteLine("5. Display item from the library");
    Console.WriteLine("6. Search for item");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
}