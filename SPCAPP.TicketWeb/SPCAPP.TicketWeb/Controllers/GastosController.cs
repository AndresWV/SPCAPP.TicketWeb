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
        public GastosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult CreateGasto(string gasto, int cantidad, float precio)
        {
            RendTk rendTk = new RendTk();
            rendTk.Id = 0;
            rendTk.GastoId = gasto;
            rendTk.Cantidad = cantidad;
            rendTk.Precio = precio;
            rendTk.Tk = (int)TempData["idTkEdit"];
            rendTk.Fecha = DateTime.Now;
            rendTk.Total = (float) rendTk.Precio * rendTk.Cantidad;
            _context.RendTk.Add(rendTk);
            _context.SaveChanges();

            return View();
        }
    }
}
