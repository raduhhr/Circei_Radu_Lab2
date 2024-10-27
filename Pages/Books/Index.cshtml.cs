using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Circei_Radu_Lab2.Data;
using Circei_Radu_Lab2.Models;

namespace Circei_Radu_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Circei_Radu_Lab2.Data.Circei_Radu_Lab2Context _context;

        public IndexModel(Circei_Radu_Lab2.Data.Circei_Radu_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
             .Include(b => b.Author)       // Load autor
             .Include(b => b.Publisher)    // Load Editura
             .ToListAsync();
        }
    }
}
