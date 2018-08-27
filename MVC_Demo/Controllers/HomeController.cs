using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Paises"] = new List<string>()
            {
                "Brasil",
                "Argentina",
                "Paraguai"
            };
            return View();
        }

        public string Opa()
        {
            return "Venho do Opa do Index!";
        }

        public string Saudacao(int id)
        {
            return "Saudação de número " + id;
        }
    }
}