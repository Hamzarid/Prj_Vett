using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class ListDossierMedicalModel : PageModel
    {
        public int idClient = -1;
        public List<Patient> patient = new List<Patient>();
        private readonly ILogger<informationPersoModel> _logger;
        private readonly VetBddContext _context;
        public ListDossierMedicalModel(ILogger<informationPersoModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            var id = HttpContext.Session.GetString("IdClient");

            idClient = Convert.ToInt32(id);
            List<Models.ClientPatient> idpatientClient = _context.ClientPatients.Select(o => o).Where(o => o.IdClient == idClient).ToList();
            foreach(ClientPatient dd in idpatientClient) 
            {
                patient.Add((Patient)_context.Patients.Select(o => o).Where(o => o.IdPatient == dd.IdPatient).First());
            }
        }
    }
}
