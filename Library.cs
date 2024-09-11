using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books = new Book[100]; //max capacity
        private Book[] BorrowedBooks = new Book[50];
        private int currentBookCount = 0;
        private int currentBorrowedBookCount = 0;
        public void Display()
        {
            for (int i = 0; i < currentBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book Added Successfully ^^) ");
            }
            else
            {
                Console.WriteLine("Cannot add new books, Already full!");
            }


        }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book Removed Successfully ^^( ");
        }
        public void BorrowBook(Book book)
        {
            if (currentBorrowedBookCount < books.Length)
            {
                books[currentBorrowedBookCount] = book;
                currentBorrowedBookCount++;
                Console.WriteLine("Book borrowed Successfully ^^) ");
            }
            else
            {
                Console.WriteLine("Cannot borrow anymore books, Already borrowed enough!");
            }
        }


    }
}
