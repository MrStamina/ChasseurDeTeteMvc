﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HeadHunterProject.ViewModel;
using HeadHunterProject.Models;


namespace HeadHunterProject.Controllers
{
    public class SitutationFamilialeController : Controller
    {
        // GET: SitutationFamiliale
        public ActionResult Index()
        {
            return View();
        }
    }
}