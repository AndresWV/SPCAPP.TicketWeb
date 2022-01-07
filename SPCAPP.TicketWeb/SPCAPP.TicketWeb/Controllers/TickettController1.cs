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
        public SPCTKContext bd = new SPCTKContext();
        public TickettController(ApplicationDbContext context)
        {
            _context = context;
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

        public IActionResult GetAlias(string term)
        {
            var alias = (from U in bd.ViewAuxis.ToList() where U.NoFaux.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.NoFaux });
            var tel1 = (from U in bd.ViewAuxis.ToList() where U.FonAux1.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.FonAux1 });
            var tel2 = (from U in bd.ViewAuxis.ToList() where U.FonAux2.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.FonAux2 });
            var tel3 = (from U in bd.ViewAuxis.ToList() where U.FonAux3.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.FonAux3 });
            var email = (from U in bd.ViewAuxis.ToList() where U.Email.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.Email });
            var emailEmpr = (from U in bd.ViewAuxis.ToList() where U.EMailDte.Contains(term, System.StringComparison.CurrentCultureIgnoreCase) select new { value = U.EMailDte });
            List<dynamic> result = new List<dynamic>();
            result.Add(alias);
            result.Add(tel1);
            result.Add(tel2);
            result.Add(tel3);
            result.Add(email);
            result.Add(emailEmpr);
            return Json(result);
        }
    }
}
