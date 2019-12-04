using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductApplication.Data;
using ProductApplication.Models;

namespace ProductApplication.Pages_ProductPages
{
    public class CreateModel : PageModel
    {
        private readonly ProductApplication.Data.ItemContext _context;

        public CreateModel(ProductApplication.Data.ItemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Items Items { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Items.Add(Items);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
