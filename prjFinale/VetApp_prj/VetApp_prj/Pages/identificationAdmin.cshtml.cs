using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class identificationAdminModel : PageModel
        
    {
        public String alert;
        private readonly ILogger<identificationAdminModel> _logger;
        private readonly VetBddContext _context;
        public identificationAdminModel(ILogger<identificationAdminModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public void OnPostSoumettre()
        {

            var client = _context.Admins.Select(o => o).Distinct().ToList();
            foreach (var s in client)
            {
                if (s.Login == Request.Form["Login"] && s.Pwd == Request.Form["Pwd"])
                {
                    Response.Redirect("indexAdmin");
                    HttpContext.Session.SetString("IdAdmin", s.IdAdmin.ToString());
                }
                else
                {
                    alert = "<div class='alert '><span class='closebtn' onclick='this.parentElement.style.display='none';>&times;</span>  <strong>Danger!</strong> Votre Mot de passe ET/OU nom utilisateur n'est pas valide .</div>";
                }
            }

        }
    }
}
