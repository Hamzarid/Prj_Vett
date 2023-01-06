using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class indexClientModel : PageModel
    {
        public string name;
        private readonly ILogger<indexClientModel> _logger;
        private readonly VetBddContext _context;
        public indexClientModel(ILogger<indexClientModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            var id = HttpContext.Session.GetString("IdClient");
            var idClient = Convert.ToInt32(id);
            var result = _context.Clients.SingleOrDefault(o => o.IdClient == idClient);

            if (result != null)
            {
                name = result.Nom;
                name += " "+result.Prenom;
            }


        }
    }
}
