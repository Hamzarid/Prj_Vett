using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace VetApp_prj.Pages
{
    public class PatientModel : PageModel
    {
        private readonly VetApp_prj.Models.VetBddContext _context;

        public IList<Models.Patient> Patient { get; set; } = default!;

        public PatientModel(VetApp_prj.Models.VetBddContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            if (_context.Patients != null)
            {
                Patient = await _context.Patients.ToListAsync();
            }
        }
    }
}
