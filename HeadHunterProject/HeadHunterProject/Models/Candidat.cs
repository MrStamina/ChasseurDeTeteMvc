using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeadHunterProject.Models
{
    public class Candidat
    {
        public int Id { get; set; }
        [Required, StringLength(40)]
        public string Nom { get; set; }

        [Required, StringLength(50)]
        public string Prenom { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [MajeurOuPas]
        public DateTime? DateNaissance { get; set; }

        [Required, StringLength(12)]
        [Phone]
        public string Telephone { get; set; }

        [Required, StringLength(30)]
        [EmailAddress]
        
        public string AdresseMail { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "Veuillez indiquer votre situation professionnelle")]
        //[Display(Name ="Etes-vous en poste?")]
        public bool SituationPro { get; set; }

        //[Range(typeof(bool),"true","true", ErrorMessage ="Veuillez indiquer votre mobilité")]
        //[Display(Name ="Etes-vous mobile?")]
        public bool Mobilite { get; set; }

        public SituationFamiliale SitutationFamiliale { get; set; }
        [Display(Name = "Situation Familiale")]
        public byte SituationFamilialeId { get; set; }

        public PoleEmbauche PoleEmbauche { get; set; }
        [Display(Name = "Secteur géographique")]
        public byte PoleEmbaucheId { get; set; }

        public Diplome Diplome { get; set; }

        [Display(Name="Diplôme")]
        public byte DiplomeId { get; set; }
    }
}