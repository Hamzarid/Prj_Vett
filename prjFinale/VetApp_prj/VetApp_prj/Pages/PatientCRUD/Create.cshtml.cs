using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VetApp_prj.Models;

namespace VetApp_prj.Pages.PatientCRUD
{
    public class CreateModel : PageModel
    {
        private readonly VetBddContext _context;

        public CreateModel(VetBddContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Patient");
        }
    }
}
