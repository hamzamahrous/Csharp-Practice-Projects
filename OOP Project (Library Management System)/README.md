# 📚 Library Management System

## Description

A console-based Library Management System implemented in C#, where librarians can manage books and users can borrow them. This project uses `List<T>` to manage both available and borrowed books efficiently.

## Features

**Librarians:**

- Add books to the library.
- Remove books from the library.
- Display all available books.

**Users:**

- Borrow books from the library.
- View available books.

**Library Card System:**

- Users need a library card to borrow books.

## Files

- `Program.cs` – Main program logic.
- `Library.cs` – Handles book storage and borrowing, using `List<Book>` for available and borrowed books.
- `Book.cs` – Represents book data.
- `Librarian.cs` & `LibraryUser.cs` – Manage librarian and user functionalities.
