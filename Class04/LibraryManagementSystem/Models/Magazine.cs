namespace LibraryManagementSystem.Models;

public class Magazine : LibraryItem
{
    public required int IssueNumber { get; set; }
    public string Publisher { get; set; } = string.Empty;

    // Magazine: [123] National Geographic, 2021 - published by: National Geographic Society
    public override string GetDetails() => 
        $"Magazine: [{IssueNumber}] {Title}, {YearPublished} - published by: {Publisher} {IsBorrowed}";
}