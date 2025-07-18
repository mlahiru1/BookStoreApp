using BookStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookStoreApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
