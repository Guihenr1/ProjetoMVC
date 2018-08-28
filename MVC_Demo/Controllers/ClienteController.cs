using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente
        public ActionResult Detalhe()
        {
            Cliente cliente = new Cliente()
            {
                ClienteId = 2,
                Nome = "Guilherme",
                Email = "guilherme.pomp@gmail.com",
                Telefone = "98130-7601"
            };

            return View(cliente);
        }

        [HttpPost]
        public ActionResult SalvarCliente(Cliente cli)
        {
            return View(cli);
        }
    }
}