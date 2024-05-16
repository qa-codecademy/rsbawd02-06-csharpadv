namespace LibraryManagementSystem;

public interface ILibraryItem
{
    void BorrowItem();
    void ReturnItem();
    string GetDetails();
}