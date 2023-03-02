using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface iBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
