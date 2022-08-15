using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.Masters
{
    public class DeleteMasterModel : PageModel
    {
        private ApplicationDbContext _context;
        private NailMaster _nailMaster;
        public DeleteMasterModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> OnGet(int id)
        {
            _nailMaster = await _context.NailMasters.FindAsync(id);
            _context.NailMasters.Remove(_nailMaster);
            _context.SaveChanges();
            return Page();
        }
    }
}
