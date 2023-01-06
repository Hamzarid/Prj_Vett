using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VetApp_prj.Models;

namespace VetApp_prj.Pages
{
    public class DetailProduitModel : PageModel
    {
        private readonly VetBddContext _context;

        public DetailProduitModel(VetBddContext context)
        {
            _context = context;
        }

        public Produit Produit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produits == null)
            {
                return NotFound();
            }

            var produit = await _context.Produits.FirstOrDefaultAsync(m => m.IdProduit == id);
            if (produit == null)
            {
                return NotFound();
            }
            else
            {
                Produit = produit;
            }
            return Page();
        }
    }
}
