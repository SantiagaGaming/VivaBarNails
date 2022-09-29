using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.NailOrders
{
    [Authorize]
    public class InWorkModel : PageModel
    {
        private ApplicationDbContext _context;
        public List<Client> Clients;

        public InWorkModel(ApplicationDbContext context)
        {
           _context = context;
        }

        public void OnGet()
        {
            Clients = _context.Clients.ToList();
        }

    }
}