# Class 3 Homework 📒

The tasks below are created with the help from [GitHub Copilot](https://copilot.github.com/). The prompt was to create a homework assignment for students that have just learned about interfaces, abstract classes and inheritance. Additional parameter was that the tasks should be related to real-world scenarios.

## Task 1: Library Management System

Create a simple library management system using inheritance, interfaces, and abstract classes. The system should be able to manage books, magazines, comics and DVDs.

1. **LibraryItem Interface**: Create an interface `ILibraryItem` that includes the following methods:
    - `BorrowItem()`: Changes the status of the item to borrowed.
    - `ReturnItem()`: Changes the status of the item to available.
    - `GetDetails()`: Returns the details of the item.

2. **LibraryItem Abstract Class**: Create an abstract class `LibraryItem` that implements the `ILibraryItem` interface. This class should include common properties like `Title`, `Author/Creator`, `YearPublished`, `IsBorrowed` and implement the `BorrowItem()` and `ReturnItem()` methods. The `GetDetails()` method should be left as abstract.

3. **Book, Magazine, Comic, and Dvd Classes**: Create `Book`, `Magazine`, `Comic` and `Dvd` classes that inherit from the `LibraryItem` abstract class. Each class should have additional properties specific to its type. For example, the `Book` class can have `ISBN` and `Genre` properties, the `Magazine` class can have `IssueNumber` and `Publisher` properties, the `Comic` class can have `Artist` property, and the `DVD` class can have `Duration` and `Rating` properties. Each class should provide its own implementation of the `GetDetails()` method.

4. **Library Class**: Create a `Library` class that manages a collection of `ILibraryItem`. It should have methods to `AddItem()`, `RemoveItem()`, `BorrowItem()`, `ReturnItem()`, and `DisplayItemDetails()`.

## Task 2: Console Driver Application for Library Management System

Your task is to create a console application that interacts with the library management system. This application will allow the user to add, remove, borrow, return, and display details of library items.

Here are the steps you need to follow:

1. **Welcome Message and Options**: When the application starts, display a welcome message and a list of options that the user can choose from. The options should include: Add a library item, Remove a library item, Borrow a library item, Return a library item, Display details of a library item, and Exit.

2. **Add a Library Item**: If the user chooses to add a library item, ask for the type of the item (Book, Magazine, Comic, DVD), the title of the item, the author/creator of the item, and the year the item was published. Depending on the type of the item, ask for additional information. For example, if the item is a book, ask for the ISBN and the genre. Then, add the item to the library.

3. **Remove a Library Item**: If the user chooses to remove a library item, ask for the title of the item and then remove the item from the library.

4. **Borrow a Library Item**: If the user chooses to borrow a library item, ask for the title of the item and then change the status of the item to borrowed.

5. **Return a Library Item**: If the user chooses to return a library item, ask for the title of the item and then change the status of the item to available.

6. **Display Details of a Library Item**: If the user chooses to display the details of a library item, ask for the title of the item and then display the details of the item.

7. **Exit**: If the user chooses to exit, terminate the application.

Remember to handle invalid inputs and provide appropriate feedback to the user. For example, if the user enters an invalid option, display a message saying "Invalid option."

Sure, here are some additional tasks that could be added to the homework assignment:

## Task 3: Search Functionality

Add a search functionality to the `Library` class. The user should be able to search for a library item by words in its title. If items are found, display the details. If no items were found, display a message saying "No items found."

## Task 4: List All Items

Add a feature to list all items in the library. The user should be able to see a list of all items currently in the library, whether they are borrowed or available.

## Task 5: Extend `LibraryItem` Classes

Extend the `Book`, `Magazine`, `Comic`, and `Dvd` classes with additional properties. For example, the `Book` class could have a `PageCount` property, the `Magazine` class could have a `Category` property, the `Comic` class could have a `Series` property, and the `Dvd` class could have a `Director` property.

## Task 6: User Accounts

Create a `User` class with properties like `Name`, `LibraryCardNumber`, and a list of `BorrowedItems`. Modify the `BorrowItem()` and `ReturnItem()` methods in the `Library` class to require a `User` as a parameter. When an item is borrowed, add it to the `User`'s list of `BorrowedItems`.

## Task 7: Due Dates and Fines

Add a `DueDate` property to the `LibraryItem` class. When an item is borrowed, set the `DueDate` to two weeks from the current date. If an item is returned after its due date, calculate a fine based on the number of days late.

## Task 8: Seeding Initial Data

Create a method in your `Library` class that will seed some initial data into your library management system. This method should create a few `User` objects and a few `LibraryItem` objects (like `Book`, `Magazine`, `Comic`, and `Dvd`) and add them to the library.

Here's a brief description of what the method could do:

1. **Create Users**: Create a few `User` objects with different `Name` and `LibraryCardNumber` values.

2. **Create Library Items**: Create a few `LibraryItem` objects. For each type of item (`Book`, `Magazine`, `Comic`, `Dvd`), create a few objects with different values for their properties.

3. **Add Items to Library**: Add the `LibraryItem` objects to the library.

4. **Borrow Items**: Have some of the users borrow some of the items.

This method should be called at the start of your console application, so that there is some initial data in the system when it starts.

Remember, the goal of this task is to provide a set of initial data that can be used for testing and demonstration purposes. It's not about creating a realistic set of data, but rather about creating a diverse set of data that shows off the different features of your library management system.

## Task 9: Unit Tests

Write unit tests for your classes and methods. Ensure that your library management system behaves as expected when adding, removing, borrowing, and returning items, as well as when searching for items and displaying item details.

## Task 10: Save and Load Library State

Implement functionality to save the current state of the library to a file and load it back. This could be done using serialization. When the application starts, it should load the library state from the file. When the application exits, it should save the current library state to the file.

## Task 11: Advanced Search

Enhance the search functionality to allow searching by other fields, such as author/creator or year published. The user should be able to choose the field they want to search by.

## Task 12: Sort Library Items

Implement functionality to sort the library items. The user should be able to choose the field to sort by (e.g., title, author/creator, year published) and the sort order (ascending or descending).

## Task 13: Limit Borrowed Items

Add a limit to the number of items a user can borrow at once. If a user tries to borrow more than the limit, display a message informing them of the limit.

## Task 14: User Interface Improvements

Improve the user interface of the console application. For example, clear the console screen after each operation, add more user-friendly messages, or add a confirmation message before removing an item.

## Task 15: Code Documentation

Add XML comments to your classes and methods. This will help other developers understand your code and it can also be used to generate a documentation file.

# Summary

In this homework assignment, you have been tasked with creating a comprehensive Library Management System. This system will utilize key concepts such as interfaces, abstract classes, and inheritance, which are fundamental to object-oriented programming.

You will start by defining a basic structure for the system, including a variety of library items and operations that can be performed on them. As you progress through the tasks, you will gradually enhance the system by adding more features and improving existing ones.

These tasks will give you a chance to practice and reinforce what you've learned about interfaces, abstract classes, and inheritance. You will also gain experience with other important programming concepts, such as handling user input, managing collections of objects, implementing search and sort functionality, and writing unit tests.

By the end of this assignment, you will have a fully functional Library Management System that can manage a variety of library items, interact with the user through a console interface, and even save and load its state to a file.

Of course, you don't need to complete all the tasks. Pick up ones that you find interesting and challenging.

Remember, the goal of this assignment is not just to create a working system, but also to practice using interfaces, abstract classes, and inheritance in a real-world context. So, take your time, think through each task carefully, and make sure you understand how everything works.

Good luck! 🚀
