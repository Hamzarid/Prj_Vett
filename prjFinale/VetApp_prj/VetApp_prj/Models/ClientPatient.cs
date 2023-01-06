using System;
using System.Collections.Generic;

namespace VetApp_prj.Models
{
    public partial class ClientPatient
    {
        public int IdRelation { get; set; }
        public int? IdPatient { get; set; }
        public int? IdClient { get; set; }
    }
}
