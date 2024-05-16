namespace LibraryManagementSystem.Models;

public class Comic : LibraryItem
{
    public required string Artist { get; set; }

    // Comic: The Amazing Spiderman, author: Stan Lee, artist: Steve Ditko, 1963
    public override string GetDetails() => 
        $"Comic: {Title}, author: {Author}, artist: {Artist}, {YearPublished}";
}