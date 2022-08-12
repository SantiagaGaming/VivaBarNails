using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.NailOrders
{
    public class DoneModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;
        public Client Client;
        public static string Name { get; set; }
          [BindProperty]
        public NailOrder NailOrder { get; set; }

        public DoneModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public async Task<IActionResult> OnGet(int id)
        {
            Client = await _context.Clients.FindAsync(id);
   
            if(Client==null)
                return NotFound();
            else
            {
                Name = Client.ClientName;
                return Page();
            }

        }
        public async Task<IActionResult> OnPostAsync()
        {
            _context.NailOrders.Add(NailOrder);
            Client client = _context.Clients.FirstOrDefault(c => c.ClientName == Name);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToPage("/AllNailsOrders");
        }
    }
}