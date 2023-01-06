using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class Patient
    {
        public int IdPatient { get; set; }
        public string? Nom { get; set; }
        public int? Age { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string? Espece { get; set; }
        public string? Race { get; set; }
        public string? Couleur { get; set; }
        public string? MicroPuce { get; set; }
        public string? Sexe { get; set; }
        public string? Sterilise { get; set; }
        public string? AlerteMedical { get; set; }
        public string? Vaccination { get; set; }
        public string? Image { get; set; }
    }
}
