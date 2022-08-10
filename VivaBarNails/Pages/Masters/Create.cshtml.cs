using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.Masters
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
           _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
       public NailMaster Master { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            _context.NailMasters.Add(Master);
            await _context.SaveChangesAsync();

            return RedirectToPage("/AllMasters");
        }
    }
}