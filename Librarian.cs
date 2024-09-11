using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : User
    {
        public int EmpNumber { get; set; }
        public Librarian (string LibName)
        {
            Name = LibName;
        }

        public void AddBook(Book newBook, Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook(Book rBook , Library library)
        {
            library.Remove(rBook);
        }
    }
}
