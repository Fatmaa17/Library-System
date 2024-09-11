using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryUser(string RegUserName)
        {
            Name = RegUserName;
        }
        public LibCard Card { get; set; } 


        public void Borrow(Book book , Library library)
        {
            library.BorrowBook(book);

        }
    }
}
