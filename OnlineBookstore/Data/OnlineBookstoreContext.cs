using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Models;

namespace OnlineBookstore.Data
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext (DbContextOptions<OnlineBookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineBookstore.Models.Book> Book { get; set; } = default!;
    }
}
