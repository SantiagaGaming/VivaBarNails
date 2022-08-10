using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.Clients
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
        public Client Client { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Confirmed");
        }
    }
}