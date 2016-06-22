using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeadHunterProject.Models;

namespace HeadHunterProject.ViewModel
{
    public class CandidatFormViewModel
    {
        public Candidat Candidat { get; set; }
        public IEnumerable<PoleEmbauche> PoleEmbauche { get; set; }
        public IEnumerable<SituationFamiliale> SituationFamiliale { get; set; }
        public string Title
        {
            get
            {
                if (Candidat!= null && Candidat.Id != 0)
                    return "Modifier Candidat";
                else
                    return "Nouveau Candidat";
            }
        }
    }
}