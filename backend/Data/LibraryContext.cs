using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Loan> Loans => Set<Loan>();
        public DbSet<User> Users => Set<User>();

    }
}
