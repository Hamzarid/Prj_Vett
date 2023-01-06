using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Syncfusion.EJ2.Schedule;
using VetApp_prj.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VetApp_prj.Pages
{
    public class calendarModel : PageModel
    {
        public List<Models.Rdv> aLLrDVS;
        private VetBddContext db;

        public calendarModel(VetBddContext _db)
        {
            db = _db;
        }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Doc { get; set; }
        [BindProperty]
        public string Pat { get; set; }
        [BindProperty]
        public string dec { get; set; }
        [BindProperty]
        public DateTime date { get; set; }

        private Schedule schedule;
        [BindProperty]
        public JsonResult result { get; set; }

        public List<eventShow> events { get; set; }


        public string today = DateTime.Today.ToString();

        public void OnGet()
        {

            result = (JsonResult)OnGetEvents();
        }


        public class eventShow
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string start { get; set; }
            public string end { get; set; }



        }


        public IActionResult OnGetEvents()
        {
            events = new List<eventShow>();

            List<Rdv> query = db.Rdvs.ToList();

            if(query.Count() > 0 )
            {

                foreach (var item in query)
                {
                    eventShow show = new eventShow();
                    show.id = item.IdClient;
                    show.title = item.Raison;
                    show.description = item.Details;
                    show.start = item.PlageHoraire.ToString("yyyy/dd/MM HH:mm");
                    show.end = item.Fin.ToString("yyyy/dd/MM HH:mm");
                    events.Add(show);
                }

            }

            return new JsonResult(events);

           

        }
    }
}