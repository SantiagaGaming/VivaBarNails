using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VivaBarNails.Authorization;

namespace VivaBarNails.Pages
{
    public class IndexModel : PageModel
    {
        public bool IsAdmin => HttpContext.User.IsInRole(Constants.AdminRole);
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}