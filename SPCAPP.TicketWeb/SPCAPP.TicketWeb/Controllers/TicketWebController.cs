using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class TicketWebController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;

        public TicketWebController(ApplicationDbContext context)
        {
            _context = context;
        }
        //http get index
        public IActionResult Index()
        {
            IEnumerable<Ticket> listaTicket = _context.Ticket;
            return View(listaTicket);
        }
    
        //http get create
        public IActionResult Create()
        {
            return View();
        }
        //http post create, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                _context.Ticket.Add(ticket);
                _context.SaveChanges();
                //Mensaje para cuandos se cree el ticket
                TempData["mensaje"] = "El ticket se ha creado correctamente";
                //Cuando se cree un ticket volver al index
                return RedirectToAction("Index");
            }
            return View();
        }
        //http get edit
        public IActionResult Edit(int? id)
        {
            //validar que la id
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //obtener ticket
            var ticket = _context.Ticket.Find(id);
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }
        //http post edit, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ticket ticket)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                _context.Ticket.Update(ticket);
                _context.SaveChanges();
                //Mensaje para cuandos se cree el ticket
                TempData["mensaje"] = "El ticket se ha actualizado correctamente";
                //Cuando se cree un ticketvolver al index
                return RedirectToAction("Index");
            }
            return View();
        }
        //http get delete
        public IActionResult Delete(int? id)
        {
            //validar que la id
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //obtener ticket
            var ticket = _context.Ticket.Find(id);
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }
        //http post delete, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTicket(int? id)
        {
            var ticket = _context.Ticket.Find(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Ticket.Remove(ticket);
            _context.SaveChanges();
            //Mensaje para cuandos se cree el ticket
            TempData["mensaje"] = "El ticket se ha eliminado correctamente";
            //Cuando se cree un ticket volver al index
            return RedirectToAction("Index");

        }
    }
}
