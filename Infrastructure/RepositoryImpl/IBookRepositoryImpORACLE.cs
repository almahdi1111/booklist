using Application.Repository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryImpl
{
    public  class IBookRepositoryImpORACLE:IBookRepository
    {
        public const string DbName = "ORACLE Server";
        public static List<Book> Books = new List<Book>()
        {
            new Book() { BookId = 1, BookName ="Introduction to Python", AuthorName ="Martin" },
            new Book() { BookId = 2, BookName ="Introduction to C++", AuthorName ="John" },

        };

        public string AddBook(Book book)
        {
            Book curBook = new Book();
            {
                curBook.BookId = Books.Max(x => x.BookId) + 1;
                curBook.BookName = book.BookName;
                curBook.AuthorName = book.AuthorName;

            }
            Books.Add(curBook);
            return "Book is Added To ORACLE Server";


        }

        public string DeleteBook(int Id)
        {
            var curBook = Books.Where(x => x.BookId == Id).SingleOrDefault();
            Books.Remove(curBook);
            return "Book is Deleted from   ORACLE Server";

        }

        public IList<Book> GetAll()
        {
            return Books;

        }

        public Book GetBookById(int Id)
        {
            return Books.Where(x => x.BookId == Id).FirstOrDefault();
        }

        public string UpdateBook(Book book)
        {
            Book curBook = new Book();
            {
                curBook.BookId = Books.Max(x => x.BookId);
                book.BookName = book.BookName;
                curBook.AuthorName = book.AuthorName;

            }
            return "Book is Updated at  ORACLE Server";
        }
    }
}
