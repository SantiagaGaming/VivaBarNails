using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VivaBarNails.Pages.NailOrders
{
    public class Done : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Done(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}