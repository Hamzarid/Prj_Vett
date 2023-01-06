using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace VetApp_prj.Pages
{
    public class AjoutPatientModel : PageModel
    {
        private IHostingEnvironment Environment;
        public String alert;
        private readonly ILogger<AjoutPatientModel> _logger;
        private readonly VetBddContext _context;
        public AjoutPatientModel(ILogger<AjoutPatientModel> logger, VetBddContext context, IHostingEnvironment _environment)
        {
            _logger = logger;
            _context = context;
            Environment = _environment;
        }
        
        [BindProperty]
        public IFormFile Upload { get; set; }
       

        public void OnGet()
        {

        }
            
        public void OnPostSoumettre(List<IFormFile> postedFiles)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            string fileName ="" ;
            foreach (IFormFile postedFile in postedFiles)
            {
                fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                   
                }
            }
            Patient newPatient = new Patient();
            newPatient.Couleur = Request.Form["clr"];
            newPatient.MicroPuce = Request.Form["micropuce"];
            newPatient.Espece = Request.Form["espece"];
            newPatient.Nom = Request.Form["nomAnimal"];
            newPatient.AlerteMedical = Request.Form["textarea"];
            newPatient.Sexe = Request.Form["selectSexe"];
            newPatient.Sterilise = Request.Form["sterilisation"];
            newPatient.Age = Convert.ToInt16( Request.Form["ageAnimal"]);
            newPatient.Race = Request.Form["race"];
            newPatient.Vaccination = Request.Form["radiobutton"];
            newPatient.Image = fileName;

             _context.Patients.Add(newPatient);
            _context.SaveChanges();
            alert = "<div class='alert success'><span class='closebtn'>&times;</span>  <strong>Success!</strong> Ajout Avec succes de votre patient "+ Request.Form["nomAnimal"].ToString() + ".</div>";


        }
    }
}
