using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Circei_Radu_Lab2.Data;
using Circei_Radu_Lab2.Models;

namespace Circei_Radu_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Circei_Radu_Lab2.Data.Circei_Radu_Lab2Context _context;

        public IndexModel(Circei_Radu_Lab2.Data.Circei_Radu_Lab2Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
