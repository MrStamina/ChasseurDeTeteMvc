using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HeadHunterProject.ViewModel;
using HeadHunterProject.Models;
using System.Data.Entity.Validation;

namespace HeadHunterProject.Controllers
{
    public class CandidatController : Controller
    {
        // GET: Candidat

        private ApplicationDbContext _context;
        public CandidatController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); ;
        }
        public ActionResult New()
        {
            var poleEmbauche = _context.PoleEmbauche.ToList();
            var situFamiliale = _context.SituationFamiliale.ToList();
            var viewModel = new CandidatFormViewModel
            {
                Candidat = new Candidat
                {
                    DateNaissance = null
                },              
                
                PoleEmbauche = poleEmbauche,
                SituationFamiliale = situFamiliale,
            };
            return View("CandidatForm",viewModel);
        }
        [HttpPost]
        public ActionResult Save(Candidat candidat)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CandidatFormViewModel
                {
                    Candidat = candidat,
                    PoleEmbauche = _context.PoleEmbauche.ToList(),
                    SituationFamiliale = _context.SituationFamiliale.ToList()
                };
                return View("CandidatForm",viewModel);
            }
            if(candidat.Id == 0)
            {
                _context.Candidat.Add(candidat);
            }
            else
            {
                var candidatInDb = _context.Candidat.Single(p => p.Id == candidat.Id);
                candidatInDb.Nom = candidat.Nom;
                candidatInDb.Prenom = candidat.Prenom;
                candidatInDb.DateNaissance = candidat.DateNaissance;
                candidatInDb.Mobilite = candidat.Mobilite;
                candidatInDb.PoleEmbauche = candidat.PoleEmbauche;
                candidatInDb.SitutationFamiliale = candidat.SitutationFamiliale;
                candidatInDb.SituationPro = candidat.SituationPro;
                candidatInDb.Telephone = candidat.Telephone;
                candidatInDb.AdresseMail = candidat.AdresseMail;
            }
            try
            {
               
                _context.SaveChanges();
                
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index", "Home");


        }
           
    }
}