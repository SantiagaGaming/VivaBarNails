using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages
{
    public class AllNailsOrders : PageModel
    {
        private ApplicationDbContext _context;
        public List<NailOrder> Orders;

        public AllNailsOrders(ApplicationDbContext context)
        {
           _context = context;
        }

        public void OnGet()
        {
            Orders = _context.NailOrders.ToList();
        }
    }
}