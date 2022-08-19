using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Authorization;
using VivaBarNails.Data;
using VivaBarNails.Models;

namespace VivaBarNails.Pages.Masters
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _context;
        public bool IsAdmin => HttpContext.User.IsInRole(Constants.AdminRole);
        public CreateModel(ApplicationDbContext context)
        {
           _context = context;
        }
        public IActionResult OnGet()
        {
            if (IsAdmin)
                return Page();
            else return Forbid();
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