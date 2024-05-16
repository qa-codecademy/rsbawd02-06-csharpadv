namespace LibraryManagementSystem;

public interface ILibraryItem
{
    string Title { get; }
    bool IsBorrowed { get; }

    void BorrowItem();
    void ReturnItem();
    string GetDetails();
}