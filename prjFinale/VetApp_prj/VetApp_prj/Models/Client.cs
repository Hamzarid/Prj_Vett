using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class Client
    {
        public int IdClient { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Adresse { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Reference { get; set; }
        public string? Login { get; set; }
        public string? Pwd { get; set; }
    }
}
