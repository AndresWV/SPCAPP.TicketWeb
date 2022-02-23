using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class AvancesController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        public IActionResult AvancesVista(int idd)
        {
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            return PartialView("AvancesVista");
        }

        public IActionResult passwordVista(int idd)
        {
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            return PartialView("passwordVista");
        }

        public IActionResult trbRealizadoVista(int idd)
        { 
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            return PartialView("trbRealizadoVista", ticket);
        }
        public IActionResult gastos()
        {
            return PartialView("gastos");
        }

        public IActionResult TablaGastos(int idd)
        {
            var lista = bd.RendTks.Where(x => x.Tk == idd);
            return PartialView("TablaGastos", lista);
        }

        
    }
}
