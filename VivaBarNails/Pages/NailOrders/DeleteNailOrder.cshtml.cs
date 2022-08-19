using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.NailOrders
{
    [Authorize(Roles = "AdminRole")]
    public class DeleteNailOrderModel : PageModel
    {

        private ApplicationDbContext _context;
        private NailOrder _nailOrder;
        public DeleteNailOrderModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> OnGet(int id)
        {
            _nailOrder = await _context.NailOrders.FindAsync(id);
            _context.NailOrders.Remove(_nailOrder);
            _context.SaveChanges();
            return Page();
        }
    }
}
