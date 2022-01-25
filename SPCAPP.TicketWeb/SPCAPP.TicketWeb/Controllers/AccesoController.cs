using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using SPCAPP.TicketWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SPCAPP.TicketWeb.Controllers
{
    public class AccesoController : Controller
    {
        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string nomUsuario, string pass)
        {
            BackLogin log = new BackLogin();
            UserWinForm usuarioo = log.getUsuarios(nomUsuario, pass);
            if(usuarioo == null)
            {
                return RedirectToAction("Index", "Acceso");
                
            }
            else
            {

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
