
public class Library
{
    private string LIBRARY_CONFIGURATION_KEY = "#CONFIG123ID1234";

    private List<Book> _books = new List<Book>();
    private List<User> _users = new List<User>();
    private List<Transaction> _transactions = new List<Transaction>();

    public void AddBook(Book book)
    {
        _books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void AddUser(User user)
    {
        _users.Add(user);
        Console.WriteLine($"User '{user.Name}' added to the library.");
    }

    public Book FindBook(string keyword)
    {
        foreach (Book book in _books)
        {
            if (book.Title.ToLower().Contains(keyword.ToLower()) || 
                book.Author.ToLower().Contains(keyword.ToLower()) || 
                book.ISBN.ToLower().Contains(keyword.ToLower()))
            {
                return book;
            }
        }

        return null;
    }

    public void BorrowBook(User user, Book book)
    {
        if (book.IsAvailable == false) 
        { 
            Console.WriteLine($"Sorry, '{book.Title}' is already borrowed."); 
            return; 
        }

        book.IsAvailable = false;
        user.CheckedOutBooks.Add(book);

        _transactions.Add(new Transaction { User = user, Book = book, Date = DateTime.Now });

        Console.WriteLine($"'{book.Title}' has been borrowed by {user.Name}.");
    }

    public void ReturnBook(User user, Book book)
    {
        if (user.CheckedOutBooks.Contains(book) == false)
        {
            Console.WriteLine($"'{user.Name}' did not borrow '{book.Title}'.");
            return;
        }

        book.IsAvailable = true;
        user.CheckedOutBooks.Remove(book);
        _transactions.Add(new Transaction { User = user, Book = book, Date = DateTime.Now });

        Console.WriteLine($"'{book.Title}' has been returned by {user.Name}.");
    }

    public void ShowMenu()
    {
        Console.WriteLine("Library Management System");
        Console.WriteLine("1. Search for a book");
        Console.WriteLine("2. Borrow a book");
        Console.WriteLine("3. Return a book");
        Console.WriteLine("4. Exit");
    }

    public void Start()
    {
        while (true)
        {
            ShowMenu();

            int choice = GetUserInput();

            switch (choice)
            {
                case 1:

                    SearchForTheBook();

                    break;

                case 2:

                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine();

                    User user = _users
                        .Where(u => u.Name.ToLower() == userName.ToLower())
                        .FirstOrDefault();

                    if (user == null)
                    {
                        Console.WriteLine("User not found.");
                        break;
                    }

                    Console.WriteLine("Available Books:");

                    for (int i = 0; i < _books.Count; i++)
                    {
                        if (_books[i].IsAvailable)
                            Console.WriteLine($"{i + 1}. {_books[i].Title}");
                    }

                    Console.Write("Select the index of the book you want to borrow: ");

                    int bookIndex = int.Parse(Console.ReadLine()) - 1;

                    if (bookIndex >= 0 && bookIndex < _books.Count && _books[bookIndex].IsAvailable)
                        BorrowBook(user, _books[bookIndex]);
                    else
                        Console.WriteLine("Invalid book index or book not available.");
                    break;

                case 3:

                    Console.Write("Enter your name: ");
                    string returnUserName = Console.ReadLine();

                    User returnUser = _users.Find(u => u.Name == returnUserName);

                    if (returnUser == null)
                    {
                        Console.WriteLine("User not found.");
                        break;
                    }

                    Console.WriteLine("Books you've borrowed:");
                    for (int i = 0; i < returnUser.CheckedOutBooks.Count; i++)
                        Console.WriteLine($"{i + 1}. {returnUser.CheckedOutBooks[i].Title}");

                    Console.Write("Select the index of the book you want to return: ");
                    int returnBookIndex = int.Parse(Console.ReadLine()) - 1;

                    if (returnBookIndex >= 0 && returnBookIndex < returnUser.CheckedOutBooks.Count)
                        ReturnBook(returnUser, returnUser.CheckedOutBooks[returnBookIndex]);
                    else
                        Console.WriteLine("Invalid book index.");
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    private void SearchForTheBook()
    {
        Console.Write("Enter a keyword to search for a book: ");
        string keyword = Console.ReadLine();

        Book foundBook = FindBook(keyword);

        if (foundBook != null)
        {
            Console.WriteLine($"Found book: {foundBook.Title} by {foundBook.Author}");
            Console.WriteLine($"Is available: {(foundBook.IsAvailable ? "Yes" : "No")}");
        }
        else
            Console.WriteLine("No matching book found.");
    }

    private static int GetUserInput()
    {
        Console.Write("Select an option: ");

        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}
