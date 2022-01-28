using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class GastosController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        public IActionResult Gastos()
        {
            return View();
        }
        public IActionResult GastosVista()
        {

            return PartialView("GastosVista", new List<RendTk>());
        }
        public int nGastosLista()
        {
            var listaGastos = bd.RendTks;
            return listaGastos.Count();
        }
        public IActionResult getGastosLista()
        {
            var listaGastos = bd.RendTks;
            return Json(listaGastos);
        }
    }
}
