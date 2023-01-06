using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class sinscrireModel : PageModel
    {
        private readonly ILogger<sinscrireModel> _logger;
        private readonly VetBddContext _context;
        public sinscrireModel(ILogger<sinscrireModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            
        }

        public void OnPostSoumettre()
        {

            Client newClient = new Client();
            newClient.Adresse = Request.Form["address"];
            newClient.Reference = Request.Form["reference"];
            newClient.Tel = Request.Form["phone"];
            newClient.Email = Request.Form["email"];
            newClient.Nom = Request.Form["name"];
            newClient.Prenom = Request.Form["lastName"];
            newClient.Login = Request.Form["Login"];
            newClient.Pwd = Request.Form["Pwd"];

            _context.Clients.Add(newClient);
            _context.SaveChanges();
            Response.Redirect("identificationClient");

        }
    }

}
