﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio_Attributor.Controllers
{
    //controlador da Home
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); //retorna exibição da view Index
        }

        public ActionResult About()
        {
            ViewBag.Message = "Startup de tecnologia especializada em recuperação de impostos para empresas do Simples Nacional.";

            return View(); //retorna exibição da view About
        }

        public ActionResult Contact()
        {
            return View(); //retorna exibição da view Contact
        }
    }
}