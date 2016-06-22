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
        [Required(ErrorMessage ="Le nom de famille est requis"), StringLength(40)]
        public string Nom { get; set; }

        [Required(ErrorMessage ="Le prénom est requis"), StringLength(50)]
        public string Prenom { get; set; }

        [Required(ErrorMessage ="La date de naissance est obligatoire"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime DateNaissance { get; set; }

        [Required, StringLength(12)]
        [Phone]
        public string Telephone { get; set; }

        [Required(ErrorMessage ="L'adresse mail est obligatoire"), StringLength(30)]
        [EmailAddress]
        
        public string AdresseMail { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "Veuillez indiquer votre situation professionnelle")]
        [Display(Name ="Etes-vous en poste?")]
        public bool SituationPro { get; set; }

        //[Range(typeof(bool),"true","true", ErrorMessage ="Veuillez indiquer votre mobilité")]
        [Display(Name ="Etes-vous mobile?")]
        public bool Mobilite { get; set; }

        public SituationFamiliale SitutationFamiliale { get; set; }
        public byte SituationFamilialeId { get; set; }

        public PoleEmbauche PoleEmbauche { get; set; }
        public byte PoleEmbaucheId { get; set; }
    }
}