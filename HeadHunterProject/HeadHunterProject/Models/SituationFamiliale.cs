using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeadHunterProject.Models
{
    public class SituationFamiliale
    {
        public byte Id { get; set; }
        [Required, StringLength(40)]
        public string Libelle { get; set; }
    }
}