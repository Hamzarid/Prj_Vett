using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class DiagnosPrediction
    {
        public int IdDiangnos { get; set; }
        public int Fievre { get; set; }
        public int Henaturie { get; set; }
        public int PentDapp { get; set; }
        public int Oxalote { get; set; }
        public int Conjonctive { get; set; }
        public int Colique { get; set; }
        public int Diachere { get; set; }
        public int Polyrie { get; set; }
        public int Trc { get; set; }
        public int Lethargie { get; set; }
        public int Hyperunicerie { get; set; }
        public int InfoParo { get; set; }
        public int Basophilie { get; set; }
        public int Chlomydiose { get; set; }
        public int Icterie { get; set; }
        public string LaMaladiePredict { get; set; } = null!;
    }
}
