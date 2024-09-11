namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library System!" +
                "\nAre you a Librarian or a regular user? (L / R)");
            Library library = new Library();
            //To reach the first char of the user input -> [0]
            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                Console.WriteLine("Enter ur name :");
                string libName = Console.ReadLine();
                Librarian L1 = new Librarian(libName);
                Console.WriteLine($"{libName}! Welcome!");
                while (true)
                {
                    Console.WriteLine("Please choose one of the options below : " +
                            "\n A: Add Book" +
                            "\n R: Remove Book" +
                            "\n D: Display Books");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter Books Details: Title , Author and Year published:");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book b0 = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            L1.AddBook(b0, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter Books Details to remove");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            b0 = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            L1.RemoveBook(b0, library);
                            break;
                        case 'D':
                            Console.WriteLine("Book List :\n");
                            L1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (userType == 'R')
            {
                Console.WriteLine("Enter ur name :");
                string RegUserName = Console.ReadLine();
                LibraryUser user1 = new LibraryUser(RegUserName);
                Console.WriteLine($"{RegUserName} ! Hello!");
                while (true)
                {
                    Console.WriteLine("Please choose one of the options below : " +
                            "\n D: Display Books" +
                            "\n B: Borrow Book");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("Book List :\n");
                            user1.DisplayBooks(library);
                            break;
                        case 'B':
                            Console.WriteLine("Enter Books Details to borrow");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book b0 = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            user1.Borrow(b0, library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter only L or R");
            }


        }
    }
}