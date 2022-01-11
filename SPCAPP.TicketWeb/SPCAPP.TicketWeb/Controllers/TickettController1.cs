using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Controllers
{
    public class TickettController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();
        public TickettController(ApplicationDbContext context)
        {
            _context = context;
           // _bd = bd;

        }
        //http get index
        public IActionResult Index()
        {
            IEnumerable<Tickett> listaTicket = _context.Tickett;
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
        public IActionResult Create(Tickett ticket)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                _context.Tickett.Add(ticket);
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
            var ticket = _context.Tickett.Find(id);
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
        public IActionResult Edit(Tickett ticket)
        {
            //valida que cumpla con todo las restricciones de la tabla ticket establecidas por las Data
            if (ModelState.IsValid)
            {
                _context.Tickett.Update(ticket);
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
            var ticket = _context.Tickett.Find(id);
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
            var ticket = _context.Tickett.Find(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Tickett.Remove(ticket);
            _context.SaveChanges();
            //Mensaje para cuandos se cree el ticket
            TempData["mensaje"] = "El ticket se ha eliminado correctamente";
            //Cuando se cree un ticket volver al index
            return RedirectToAction("Index");

        }
        /*********************************************DATOS PARA PRECARGAR CON AUTOCOMPLETADO**************************************************************************/
        public IActionResult GetNombresClientes(string term)
        {
            //Con la comparacion deja que ingrese minusculas o mayusculas
            var result = (from U in bd.ViewAuxis.ToList() where U.NomAux.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.NomAux });
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
        //Busqueda por nombre del contacto
        public Contacto GetContacto(string term)
        {
            var contactoData = bd.Contactos.Where(x => x.NomCon == term).FirstOrDefault();
            return contactoData;
        }
        public IActionResult GetTecnico()
        {
            //Con la comparacion deja que ingrese minusculas o mayusculas
            var result = (from U in bd.Tecnicos.ToList() select new { value = U });
            return Json(result);
        }
    }
    
}
