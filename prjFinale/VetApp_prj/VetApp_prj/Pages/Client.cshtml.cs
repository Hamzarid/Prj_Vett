using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace VetApp_prj.Pages
{
    public class ClientModel : PageModel
    {
        private readonly VetApp_prj.Models.VetBddContext _context;

        public ClientModel(VetApp_prj.Models.VetBddContext context)
        {
            _context = context;
        }

        public IList<Models.Client> Client { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clients != null)
            {
                Client = await _context.Clients.ToListAsync();
            }
        }
    }
}
