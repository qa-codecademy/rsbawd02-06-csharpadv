namespace LibraryManagementSystem.Models;

public class Book : LibraryItem
{
    public required string ISBN { get; set; }
    public string Genre { get; set; } = "Fiction";

    // Book: [978-3-16-148410-0] The Catcher in the Rye, J.D. Salinger, 1951 - Fiction
    public override string GetDetails() => 
        $"Book: [{ISBN}] {Title}, {Author}, {YearPublished} - {Genre}";
}
