## Library Management System

This is a simple **console-based library management system** developed in **C#**. It allows users to interact with the system as either a **Librarian** or a **Library User**. The system provides functionalities to manage a library's collection of books, including adding, removing, displaying, and borrowing books.

### Features

#### For Librarians:
- **Add Book**: Allows the librarian to add new books to the library by providing the title, author, and year of publication.
- **Remove Book**: Allows the librarian to remove a book from the library by specifying the book details.
- **Display Books**: Shows a list of all available books in the library.

#### For Regular Users:
- **Display Books**: Allows users to view all available books in the library.
- **Borrow Book**: Enables users to borrow books from the library by specifying the book details.

### Concepts Applied
- **Object-Oriented Programming (OOP)**: This project demonstrates the use of OOP concepts such as inheritance and encapsulation.
  - `LibraryUser` and `Librarian` classes inherit from the `User` class.
  - The `Book` class represents the entity of a book with properties such as title, author, and year.
- **Collections**: The system uses arrays to store books and manage the collection.
- **Error Handling**: Prevents adding books beyond capacity and ensures proper validation during book removal or borrowing.
- **User Input**: The program takes user input to perform actions such as adding or borrowing books.

### How to Use
1. Clone the repository.
2. Compile and run the project.
3. Interact with the system by choosing whether you're a **Librarian** or a **Regular User** and follow the prompts to perform actions.
