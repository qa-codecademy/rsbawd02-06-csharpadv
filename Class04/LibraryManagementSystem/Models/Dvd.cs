namespace LibraryManagementSystem.Models;

public class Dvd : LibraryItem
{
    public required int DurationInMinutes { get; set; }
    public int Rating { get; set; } = 5;

    // DVD: The Godfather, director: Francis Ford Coppola, 175 minutes - year 1972, rated 5
    public override string GetDetails() => 
        $"DVD: {Title}, director: {Author}, {DurationInMinutes} minutes - year {YearPublished}, rated {Rating} {IsBorrowed}";
}