using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public string AuthorName { get; set; }
    }
}
