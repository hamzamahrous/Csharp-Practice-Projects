using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System {
    internal class Customer(string name, LibraryCard libCard): User(name) {
        public LibraryCard Card { get; set; } = libCard;

        public bool borrowBook(string bookTitle, Library library) {
            return library.borrowBook(bookTitle);
        }
    }
}
