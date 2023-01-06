using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class identificationClientModel : PageModel
    {
        public String alert; 
        private readonly ILogger<identificationClientModel> _logger;
        private readonly VetBddContext _context;
        public identificationClientModel(ILogger<identificationClientModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public void OnGet()
        {
           
        }
       
        public void OnPostSoumettre()
        {

            var client = _context.Clients.Select(o => o).Distinct().ToList();
            foreach( var s in client)
            {
                if (s.Login == Request.Form["Login"] && s.Pwd==Request.Form["Pwd"])
                {
                  
                    Response.Redirect("indexClient");
                    HttpContext.Session.SetString("IdClient", s.IdClient.ToString());
                }
                else
                {
                    alert = "<div class='alert '><span class='closebtn' onclick='this.parentElement.style.display='none';>&times;</span>  <strong>Danger!</strong> Votre Mot de passe ET/OU nom utilisateur n'est pas valide .</div>";
                }
            }

        }
    }

}
