using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.Clients
{
    public class DeleteClientModel : PageModel
    {
        private ApplicationDbContext _context;
        private Client _client;
        public DeleteClientModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> OnGet(int id)
        {
            _client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(_client);
            _context.SaveChanges();
            return Page();
        }
    }
}
