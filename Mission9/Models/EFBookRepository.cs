using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class EFBookRepository : iBookRepository
    {
        public BookStoreContext context { get; set; }

        public EFBookRepository (BookStoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
