using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductApplication.Data;
using ProductApplication.Models;

namespace ProductApplication.Pages_ProductPages
{
    public class IndexModel : PageModel
    {
        private readonly ProductApplication.Data.ItemContext _context;

        public IndexModel(ProductApplication.Data.ItemContext context)
        {
            _context = context;
        }

        public IList<Items> Items { get;set; }

        public async Task OnGetAsync()
        {
            Items = await _context.Items.ToListAsync();
        }
    }
}
