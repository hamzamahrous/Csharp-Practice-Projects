using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System {
    internal abstract class User(string name) {
        public string Name { get; set; } = name;

        public void DisplayAllBooks(Library library) {
            library.DisplayAllBooks();
        }
    }
}
    