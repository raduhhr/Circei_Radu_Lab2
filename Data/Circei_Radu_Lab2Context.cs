using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Circei_Radu_Lab2.Models;

namespace Circei_Radu_Lab2.Data
{
    public class Circei_Radu_Lab2Context : DbContext
    {
        public Circei_Radu_Lab2Context (DbContextOptions<Circei_Radu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Circei_Radu_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Circei_Radu_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Circei_Radu_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
