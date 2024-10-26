using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gherman_Daria_Lab2.Data;
using Gherman_Daria_Lab2.Models;

namespace Gherman_Daria_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Gherman_Daria_Lab2.Data.Gherman_Daria_Lab2Context _context;

        public CreateModel(Gherman_Daria_Lab2.Data.Gherman_Daria_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
