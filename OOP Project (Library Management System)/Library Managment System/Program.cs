namespace Library_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Welcome to the library!");
            
            Console.WriteLine("Enter your type (Librarian/Customer): (L/C):");
            var userType = Console.ReadLine()?.ToUpper()[0];

            if(userType == 'L') {  
                Console.WriteLine("Welcome Libarian!\n");

                Console.WriteLine("Please enter your name:");
                string librarianName = Console.ReadLine() ?? "Hamza";
                
                var random = new Random();
                int randomLibrarianId = random.Next();

                Librarian librarian = new Librarian(librarianName, randomLibrarianId);
                Console.WriteLine($"Welcome {librarian.Name}\n");

                while (true) {
                    Console.WriteLine("Available actions:");
                    Console.WriteLine("A - Add a new book");
                    Console.WriteLine("D - Display all books");
                    Console.WriteLine("R - Remove a book");
                    Console.WriteLine("E - Exit the system");
                    Console.WriteLine("Enter your choice (A/D/R/E):");

                    char librarianChoice = Console.ReadLine()?.ToUpper()[0] ?? 'D';
                    switch (librarianChoice) {
                        case 'A':
                            Console.WriteLine("\nEnter book details ... Title, Author and Year:");

                            string bookName = Console.ReadLine() ?? "New Book Name";
                            string bookAuthor = Console.ReadLine() ?? "New Book Author";
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book newBook = new Book() {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            librarian.AddBook(newBook, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter Book Title To Remove:");

                            var removedBookName = Console.ReadLine();
                            bool isDeletionSuccess = librarian.RemoveBook(removedBookName ?? "Book", library);
                            if (isDeletionSuccess) {
                                Console.WriteLine("The Book Is Deleted Successfully!");
                            }
                            else {
                                Console.WriteLine("The Book Isn't Found.");
                            }

                            break;

                        case 'D':
                            librarian.DisplayAllBooks(library);
                            break;

                        case 'E':
                            Environment.Exit(0);
                            break;

                        default:
                            librarian.DisplayAllBooks(library);
                            break;
                    }
                }

            } else if(userType == 'C') {
                Console.WriteLine("Welcome Customer!\n");

                var random = new Random();
                int randomLibraryCardId = random.Next();
                LibraryCard libCard = new LibraryCard(randomLibraryCardId);

                Console.WriteLine("Please enter your name:");
                string customerName = Console.ReadLine() ?? "Hamza";

                Customer newCustomer = new Customer(customerName, libCard);
                Console.WriteLine($"Welcome {newCustomer.Name}\n");

                while (true) {
                    Console.WriteLine("Available actions:");
                    Console.WriteLine("B - Borrow book");
                    Console.WriteLine("D - Display all books");
                    Console.WriteLine("E - Exit the system");
                    Console.WriteLine("Enter your choice (B/D/E):");

                    char customerChoice = Console.ReadLine()?.ToUpper()[0] ?? 'D';
                    switch (customerChoice) {
                        case 'B':
                            Console.WriteLine("Please enter the book's title you want to borrow:");
                            var bookTitle = Console.ReadLine();
                            bool borrowingResult = newCustomer.borrowBook(bookTitle ?? "Book Title", library);
                            if (borrowingResult) {
                                Console.WriteLine("Happy Reading!");
                            } else {
                                Console.WriteLine("Sorry the book isn't found.");
                            }

                            break;

                        case 'D':
                            newCustomer.DisplayAllBooks(library);
                            break;

                        case 'E':
                            Environment.Exit(0);
                            break;

                        default:
                            newCustomer.DisplayAllBooks(library);
                            break;
                    }
                }
            } else {
                Console.WriteLine("Invalid type.");
            }
        }
    }   
}
