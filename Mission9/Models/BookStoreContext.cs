using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
        public partial class BookStoreContext : DbContext
        {
            public BookStoreContext()
            {
            }

            public BookStoreContext(DbContextOptions<BookStoreContext> options)
                : base(options)
            {
            }

            public DbSet<Book> Books { get; set; }

            public DbSet<Purchase> Purchases { get; set; }

        }
}
