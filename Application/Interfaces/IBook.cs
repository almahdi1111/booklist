using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBook
    {
        public string AddBook(Book book);

        public string DeleteBook(int Id);
        public Book GetBookById(int Id);

        public IList<Book> GetAll();
        public string UpdateBook(Book book);
    }
}
