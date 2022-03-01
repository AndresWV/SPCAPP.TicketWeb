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
            ViewBag.Avances = "N";
            ViewBag.Programado = "N";
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            if (ticket.Avance == "S")
            {
                ViewBag.Avances = "S";
            }
            if (ticket.Programado == "S")
            {
                ViewBag.Programado = "S";
            }
            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0);
            if (ticket.FechaTrabajo == null)
            {
                ticket.FechaTrabajo = hm;
            }
            return PartialView("AvancesVista",ticket);
        }
        public IActionResult AvancesVistaBlock()
        {
            return PartialView("AvancesVistaBlock");
        }
        public IActionResult passwordVista(int idd)
        {
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            return PartialView("passwordVista");
        }
        public IActionResult passwordVistaBlock(int idd)
        {
            return PartialView("passwordVistaBlock");
        }

        public IActionResult trbRealizadoVista(int idd)
        {
            ViewData["idTrb"] = idd;
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            ViewBag.Realizado = ticket.Realizado;
            ViewBag.Tw = ticket.Tw;
            ViewBag.Visita = ticket.Visita;
            ViewBag.Taller = ticket.Taller;
            ViewBag.Telefono = ticket.Telefono;
            ViewBag.Remoto = ticket.Remoto;
            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0);
            if (ticket.FechaCierre == null)
            {
                ticket.FechaCierre = hm;
            }
            if (ticket.HrsInicio == null)
            {
                ticket.HrsInicio = hm;
            }
            if (ticket.HrsTermino == null)
            {
                ticket.HrsTermino = hm;
            }
            return PartialView("trbRealizadoVista", ticket);
        }
        public IActionResult trbRealizadoVistaBlock(int idd)
        {
            ViewData["idTrb2"] = idd;
            var ticket = bd.TicketSpcs.Where(x => x.Id == idd).FirstOrDefault();
            return PartialView("trbRealizadoVistaBlock", ticket);
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
