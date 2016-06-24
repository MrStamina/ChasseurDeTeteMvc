using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HeadHunterProject.Models
{
    public class Niveau
    {
        public byte Id { get; set; }

        [Required, StringLength(50)]
        public string Libelle { get; set; }
    }
}