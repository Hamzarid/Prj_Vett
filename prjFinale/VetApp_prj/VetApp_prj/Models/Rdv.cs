using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class Rdv
    {
        public int IdRdv { get; set; }
        public string Raison { get; set; } = null!;
        public int IdClient { get; set; }
        public int IdPatient { get; set; }
        public DateTime PlageHoraire { get; set; }
        public string Details { get; set; } = null!;
        public DateTime Fin { get; set; }
    }
}
