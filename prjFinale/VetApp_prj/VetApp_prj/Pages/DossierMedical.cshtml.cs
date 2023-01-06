using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class DossierMedicalModel : PageModel
    {
        private readonly VetBddContext _context;

        public DossierMedicalModel(VetBddContext context)
        {
            _context = context;
        }
       
        public Models.Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Patients == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FirstOrDefaultAsync(m => m.IdPatient == id);
            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                Patient = patient;
            }
            return Page();
        }
    }
}

