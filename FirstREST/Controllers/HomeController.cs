﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.artigos = Lib_Primavera.PriIntegration.ListaArtigosPorSTK();
            return View();
        }

        public ActionResult ProcuraArtigo(string id)
        {
            ViewBag.procura_artigo = Lib_Primavera.PriIntegration.ProcuraArtigos(id);
            return View();
        }
    }
}
