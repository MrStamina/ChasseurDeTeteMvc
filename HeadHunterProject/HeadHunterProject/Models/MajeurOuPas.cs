using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HeadHunterProject.Models
{
    public class MajeurOuPas : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var candidat = (Candidat)validationContext.ObjectInstance;
            var age = DateTime.Now.Year - candidat.DateNaissance.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Vous devez être majeur pour vous inscrire");
        }
    }
}