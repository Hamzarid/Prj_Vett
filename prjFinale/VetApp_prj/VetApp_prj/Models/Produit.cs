using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; } = null!;
        public int Prix { get; set; }
        public string Description { get; set; } = null!;
        public int QuantiteDispo { get; set; }
        public string Type { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
