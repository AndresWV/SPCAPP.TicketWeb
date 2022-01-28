using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class AvancesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvancesVista()
        {
            return PartialView("AvancesVista");
        }

        [HttpGet]
        public IActionResult passwordVista()
        {
            return PartialView("passwordVista");
        }

        [HttpGet]
        public IActionResult trbRealizadoVista()
        {
            return PartialView("trbRealizadoVista");
        }
    }
}
