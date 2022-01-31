using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class TicketSpcController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();
        public TicketSpcController(ApplicationDbContext context)
        {
            _context = context;
           // _bd = bd;

        }
        //http get index
        public IActionResult Index()
        {
            var ultimoTicket = _context.TicketSpc.Count();
            var primerTicket = ultimoTicket - 200;
            IEnumerable<TicketSpc> listaTicket = _context.TicketSpc.Skip(Math.Max(0,primerTicket));
           
            return View(listaTicket);
        }

        //http get create
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        //http post create, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TicketSpc ticket)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                var newFecha = new DateTime();
                newFecha = ticket.Fecha.Value;
                newFecha =      newFecha.AddSeconds(ticket.HrsInicio.Value.TimeOfDay.Seconds).AddMinutes(ticket.HrsInicio.Value.TimeOfDay.Minutes).AddHours(ticket.HrsInicio.Value.TimeOfDay.Hours);
                ticket.Id= _context.TicketSpc.Count() == 0 ? 1 : _context.TicketSpc.Max(x => x.Id) + 1;
                ticket.Fecha = newFecha;
                ticket.HrsInicio = null;
                ticket.UserCreaTk = "MIGUEL";
                ticket.CerradoId = 0;
                ticket.Passwords = "";
                ticket.Fk_procede = "";
                ticket.Realizado = "N";
                ticket.Programado = "N";
                _context.TicketSpc.Add(ticket);
               
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
            var ticket = _context.TicketSpc.Find(id);
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            return PartialView("Edit",ticket);
        }
        //http post edit, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTicket(TicketSpc ticket, int id)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                ticket.Id = id;
                _context.TicketSpc.Update(ticket);
                
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
            var ticket = _context.TicketSpc.Find(id);
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            return PartialView("Delete",ticket);
        }
        //http post delete, el validate se encarga de limitar solicitudes en caso de uso de bot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTicket(int? id)
        {
            var ticket = _context.TicketSpc.Find(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.TicketSpc.Remove(ticket);
            _context.SaveChanges();
            //Mensaje para cuandos se cree el ticket
            TempData["mensaje"] = "El ticket se ha eliminado correctamente";
            //Cuando se cree un ticket volver al index
            return RedirectToAction("Index");

        }
        //http get view
        public IActionResult View(int? id)
        {
            //validar que la id
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //obtener ticket
            var ticket = _context.TicketSpc.Find(id);
            //verificar que el ticket existe
            if (ticket == null)
            {
                return NotFound();
            }
            return PartialView("View", ticket);
        }
        /*********************************************DATOS PARA PRECARGAR CON AUTOCOMPLETADO**************************************************************************/
        public IActionResult GetNombresClientes(string term)
        {
            var result = bd.Empresas.ToList().Where(clientee => clientee.NomAux.Contains(term, System.StringComparison.CurrentCultureIgnoreCase)).Select(clientee => clientee.Codigo);

            return Json(result);
        }
        public IActionResult GetNombresClientesNom(string term)
        {
            var result = bd.Empresas.ToList().Where(x => x.Codigo.Equals(term)).Select(x=>x.NomAux);
            return Json(result);
        }
        //Devuelve el primer objeto con la data de la empresa
        public ViewAuxi GetAlias(string term)
        {

            var clienteData = bd.ViewAuxis.Where( x => x.NomAux == term ).FirstOrDefault();
            return clienteData;
        }
        //Busqueda por el codigo obtenid en viewAuxi (empresa)
        public IActionResult GetContactos(string term)
        {
            var contactoData = bd.Contactos.Where(x => x.CodAuc == term);
            return Json(contactoData);
        }
        public String GetContactoSelect(string term)
        {
            var contactoData = bd.TicketSpcs.Where(x => x.CodAux == term).Select(y => y.Contacto).FirstOrDefault();
            return contactoData;
        }
        //Busqueda por nombre del contacto
        public Contacto GetContacto(string term)
        {
            var contactoData = bd.Contactos.Where(x => x.NomCon == term).FirstOrDefault();
            return contactoData;
        }
        //Traer todos los tecnicos
        public IActionResult GetTecnico()
        {
            var contactoData = bd.Tecnicos;
            return Json(contactoData);
        }
        //Traer todos los gastos
        public IActionResult GetGastos()
        {
            var contactoData = bd.Gastos;
            return Json(contactoData);
        }
        //Traer todos los medios de contacto de la tabla medios
        public IActionResult GetMContacto()
        {
            var medio = bd.Medios;
            return Json(medio);
        }
        //Traer todos los tipos de soporte de la tabla TipoSoporte
        public IActionResult GetTSoporte()
        {
            var soporte = bd.TipoSoportes;
            return Json(soporte);
        }
        //Traer todas las areas de trabajo de la TKGrupos
        public IActionResult GetTKgrupos()
        {
            var areas = bd.TkGrupos;
            return Json(areas);
        }
        public TicketSpc GetTicket(int id)
        {
            var ticket = bd.TicketSpcs.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return ticket;
        }
    }
    
}
