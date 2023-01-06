using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class ListProduitModel : PageModel
    {
        public List<Produit> Produit;
        private readonly ILogger<IndexPModel> _logger;
        private readonly VetBddContext _context;
        public ListProduitModel(ILogger<IndexPModel> logger, VetBddContext context)
        {
            _logger = logger;
            _context = context;

        }
        public void OnGet()
        {
            Produit = new List<Produit>();
            Produit = _context.Produits.ToList();
        }
        public void OnPostSoumettre()
        {

        }
    }
}
