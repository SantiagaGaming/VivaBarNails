using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages
{
    public class AllMastersModel : PageModel
    {
        private ApplicationDbContext _context;
        public List<NailMaster> Masters;

        public AllMastersModel(ApplicationDbContext context)
        {
           _context = context;
        }

        public void OnGet()
        {
            Masters= _context.NailMasters.ToList();
        }
    }
}