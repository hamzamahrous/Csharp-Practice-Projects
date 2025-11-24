using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System {
    internal class Library {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Book> _borrowedBooks = new List<Book>();

        public void AddBook(Book book) {
            _books.Add(book);
        }

        public bool DeleteBook(string bookTitle) {
            foreach(Book book in _books) {
                if(book.Title == bookTitle) {
                    return _books.Remove(book);
                }
            }

            return false;
        }

        public void DisplayAllBooks() {
            if (_books.Count > 0) {
                for (int i = 0; i < _books.Count; i++) {
                    Console.WriteLine($"{i + 1}. The book {_books[i].Title} is written by {_books[i].Author} and was published at {_books[i].Year}.");
                }
            } else {
                Console.WriteLine("\nThere's no books to show.");
            }

            Console.Write("\n");
        }

        public void DisplayAllBorrowedBooks() {
            if (_borrowedBooks.Count > 0) {
                for (int i = 0; i < _borrowedBooks.Count; i++) {
                    Console.WriteLine($"{i + 1}. The book {_borrowedBooks[i].Title} is written by {_borrowedBooks[i].Author} and was published at {_borrowedBooks[i].Year}.");
                }
            }
            else {
                Console.WriteLine("There's no books to show.");
            }

            Console.Write("\n");
        }

        public bool borrowBook(string bookTitle) {
            foreach (Book book in _books) {
                if (book.Title == bookTitle) {
                    _borrowedBooks.Add(book);
                    _books.Remove(book);
                    return true;
                }
            }

            return false;
        }
    }
}
