using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class IndexPModel : PageModel
    {
        private readonly ILogger<IndexPModel> _logger;

        public IndexPModel(ILogger<IndexPModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;

        }
        //Apporter le context necessary
        private readonly VetBddContext _context;
        public void OnGet()
        {
            
        }
    }
}
