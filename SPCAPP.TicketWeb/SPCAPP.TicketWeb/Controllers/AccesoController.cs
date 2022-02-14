using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using SPCAPP.TicketWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SPCAPP.TicketWeb.Controllers
{
    public class AccesoController : Controller
    {
        //private readonly SignInManager<IdentityUser> signInManager;

        //conexion con la base de datos
        private readonly ApplicationDbContext _context;
        private readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        //public AccesoController(SignInManager<IdentityUser> signInManager)
        //{
        //    this.signInManager = signInManager;
        //}
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

                return RedirectToAction("Index", "TicketSpc");
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(string nomUsuario, string pass)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        BackLogin log = new BackLogin();
        //        UserWinForm usuarioo = log.getUsuarios(nomUsuario, pass);
        //        var res = await signInManager.PasswordSignInAsync(usuarioo.Tecnico, usuarioo.Clave, false, false);
        //        if (res.Succeeded)
        //        {
        //            return RedirectToAction("Index", "Acceso");

        //        }
        //        else
        //        {
        //            return RedirectToAction("Index", "TicketSpc");
        //        }
        //    }
        //    return RedirectToAction("Index", "TicketSpc");

        //}
    }
}
