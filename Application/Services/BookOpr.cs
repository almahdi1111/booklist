using Application.Interfaces;
using Application.Repository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookOpr : IBook
    {
        private readonly IBookRepository dbRepository;
        public  BookOpr (IBookRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public string AddBook(Book book)
        {
           return dbRepository.AddBook(book);
        }

        public string DeleteBook(int Id)
        {
           return   dbRepository.DeleteBook(Id);
        }

        public IList<Book> GetAll()
        {
            return dbRepository.GetAll();
        }

        public Book GetBookById(int Id)
        {
            return (Book)dbRepository.GetBookById(Id);
        }

        public string UpdateBook(Book book)
        {
            return  dbRepository.UpdateBook(book);
        }
    }
}
