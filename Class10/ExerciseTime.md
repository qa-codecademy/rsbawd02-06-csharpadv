### Exercise 1: Implementing and Using Interfaces with LINQ in C#

**Objective:**
In this exercise, you will create a simple application that demonstrates your understanding of classes, interfaces, and LINQ in C#. You will implement an interface, create classes that implement this interface, and use LINQ to query and manipulate a collection of these objects.

**Tasks:**

1. **Define an Interface:**
    - Create an interface called `IProduct` with the following properties:
        - `int Id { get; set; }`
        - `string Name { get; set; }`
        - `decimal Price { get; set; }`
    - Add a method `string GetProductDetails();`

2. **Implement the Interface:**
    - Create a class `Product` that implements the `IProduct` interface.
    - Implement the `GetProductDetails` method to return a string in the format: `"Id: {Id}, Name: {Name}, Price: {Price:C}"`

3. **Create a Collection:**
    - Create a list of `Product` objects with at least 10 different products.
    
    ```csharp
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Mouse", Price = 25.50m },
            new Product { Id = 3, Name = "Keyboard", Price = 49.99m },
            new Product { Id = 4, Name = "Monitor", Price = 150.00m },
            new Product { Id = 5, Name = "USB Cable", Price = 5.99m },
            new Product { Id = 6, Name = "External Hard Drive", Price = 89.99m },
            new Product { Id = 7, Name = "Webcam", Price = 45.00m },
            new Product { Id = 8, Name = "Desk Lamp", Price = 30.00m },
            new Product { Id = 9, Name = "Headphones", Price = 70.00m },
            new Product { Id = 10, Name = "Microphone", Price = 120.00m }
        };

4. **Use LINQ to Query the Collection:**
    - Write a LINQ query to find all products with a price greater than a specified value (e.g., 20).
    - Write a LINQ query to find the product with the highest price.
    - Write a LINQ query to order the products by name.

5. **Display the Results:**
    - Display the details of the products that match the LINQ queries using the `GetProductDetails` method.

### Exercise 2: Creating and Querying a Simple Book Library

**Objective:**
In this exercise, you will create a simple book library application that demonstrates your understanding of classes, interfaces, and LINQ in C#. You will define an interface for a book, implement this interface in a class, create a collection of books, and use LINQ to query and manipulate this collection.

**Tasks:**

1. **Define an Interface:**
    - Create an interface called `IBook` with the following properties:
        - `int Id { get; set; }`
        - `string Title { get; set; }`
        - `string Author { get; set; }`
        - `int Year { get; set; }`
    - Add a method `string GetBookInfo();`

2. **Implement the Interface:**
    - Create a class `Book` that implements the `IBook` interface.
    - Implement the `GetBookInfo` method to return a string in the format: `"Id: {Id}, Title: {Title}, Author: {Author}, Year: {Year}"`

3. **Create a Collection:**
    - Create a list of `Book` objects with at least 10 different books.

    ```csharp
        // Step 3: Create a collection of books
        List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
            new Book { Id = 4, Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez", Year = 1967 },
            new Book { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932 },
            new Book { Id = 6, Title = "Moby-Dick", Author = "Herman Melville", Year = 1851 },
            new Book { Id = 7, Title = "War and Peace", Author = "Leo Tolstoy", Year = 1869 },
            new Book { Id = 8, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 },
            new Book { Id = 9, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 },
            new Book { Id = 10, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866 }
        };

4. **Use LINQ to Query the Collection:**
    - Write a LINQ query to find all books written by a specific author.
    - Write a LINQ query to find the most recent book.
    - Write a LINQ query to order the books by title.

5. **Display the Results:**
    - Display the details of the books that match the LINQ queries using the `GetBookInfo` method.

### Exercise 3: Using StreamReader and StreamWriter in C#

**Objective:**
In this exercise, you will create a simple application that demonstrates your understanding of file input and output in C# using `StreamReader` and `StreamWriter`. You will ask the user for input, write it to a file, and then read the contents of the file back to the user.

**Tasks:**

1. **Ask for User Input:**
    - Prompt the user to enter some text.

2. **Write User Input to a File:**
    - Use .NET to write the user's input to a file called `userInput.txt`.

3. **Read the File Content:**
    - Use .NET to read the content of `userInput.txt`.

4. **Display the File Content:**
    - Display the content of the file back to the user.

### Exercise 4: Creating and Using Extension Methods in C#

**Objective:**
In this exercise, you will create a simple application that demonstrates your understanding of extension methods in C#. You will define an extension method for the `string` class, use it to manipulate a string, and display the result.

**Tasks:**

1. **Define an Extension Method:**
    - Create a static class called `StringExtensions`.
    - Define an extension method called `ReverseWords` that takes a `string` and returns a new string with the words in reverse order.

2. **Use the Extension Method:**
    - In your main program, prompt the user to enter a sentence.
    - Use the `ReverseWords` extension method to reverse the order of the words in the sentence.

3. **Display the Result:**
    - Display the original and the modified sentences.
