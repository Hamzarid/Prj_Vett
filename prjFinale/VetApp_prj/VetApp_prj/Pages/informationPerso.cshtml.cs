using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class informationPersoModel : PageModel
    {
        public String alert;
        public String nom, prenom,numero, adress, email, reference, user,pwd ;
        public int idClient = -1;
        private readonly ILogger<informationPersoModel> _logger;
        private readonly VetBddContext _context;
        public informationPersoModel(ILogger<informationPersoModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            var id = HttpContext.Session.GetString("IdClient");
            
            idClient =Convert.ToInt32(id);
            var listinformations = _context.Clients.Select(o => o).Where(o => o.IdClient == idClient).ToList();
          
            foreach (var s in listinformations)
            {
                nom = s.Nom;
                prenom = s.Prenom;
                numero = s.Tel;
                adress = s.Adresse;
                email = s.Email;
                reference = s.Reference;
                user = s.Login;
                pwd = s.Pwd; 
            }

        }

        public void OnPostSoumettre()
        { var id = HttpContext.Session.GetString("IdClient");
            idClient = Convert.ToInt32(id);
           var result = _context.Clients.SingleOrDefault(o => o.IdClient == idClient);
           
            if (result!= null)
            {
                result.Reference= Request.Form["reference"];
                result.Email= Request.Form["email"];
                result.Login= Request.Form["user"];
                result.Pwd= Request.Form["Pwd"];
                result.Adresse=Request.Form["address"];
                result.Tel = Request.Form["phone"];
                result.Nom = Request.Form["nom"];
                result.Prenom= Request.Form["prenom"];
                _context.SaveChanges();

                //Pour re afficher les informations personnelles 

                var listinformations = _context.Clients.Select(o => o).Where(o => o.IdClient == idClient).ToList();

                foreach (var s in listinformations)
                {
                    nom = s.Nom;
                    prenom = s.Prenom;
                    numero = s.Tel;
                    adress = s.Adresse;
                    email = s.Email;
                    reference = s.Reference;
                    user = s.Login;
                    pwd = s.Pwd;
                }

            }
            alert = "<div class='alert success'><span class='closebtn'>&times;</span>  <strong>Success!</strong> Vos informations sont bien modifiées .</div>";


        }
    }
}
