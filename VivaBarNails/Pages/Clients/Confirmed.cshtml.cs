using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VivaBarNails.Pages.Clients
{
    public class ConfirmedModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ConfirmedModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}