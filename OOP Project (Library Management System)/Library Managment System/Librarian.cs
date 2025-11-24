using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System {
    internal class Librarian(string name, int id) : User(name) {
        public int EmployeeId { get; set; } = id;

        public void AddBook(Book book, Library library) {
            library.AddBook(book);
            Console.WriteLine("Book Added Successfully!");
        }

        public bool RemoveBook(string bookTitle, Library library) {
            return library.DeleteBook(bookTitle); 
        }
    }
}
