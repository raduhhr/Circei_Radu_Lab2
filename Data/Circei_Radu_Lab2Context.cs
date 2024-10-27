using Microsoft.EntityFrameworkCore;
using Circei_Radu_Lab2.Models;

namespace Circei_Radu_Lab2.Data
{
    public class Circei_Radu_Lab2Context : DbContext
    {
        public Circei_Radu_Lab2Context(DbContextOptions<Circei_Radu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<BookCategory> BookCategory { get; set; }
    }
}