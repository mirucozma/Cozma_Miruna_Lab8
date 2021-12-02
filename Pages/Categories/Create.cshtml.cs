using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cozma_Miruna_Lab8.Data;
using Cozma_Miruna_Lab8.Models;

namespace Cozma_Miruna_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Cozma_Miruna_Lab8.Data.Cozma_Miruna_Lab8Context _context;

        public CreateModel(Cozma_Miruna_Lab8.Data.Cozma_Miruna_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
