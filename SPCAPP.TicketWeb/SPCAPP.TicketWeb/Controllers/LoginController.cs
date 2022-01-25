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
    public class LoginController : Controller
    {
        //conexion con la base de datos
        public readonly ApplicationDbContext _context;
        public readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult getUsuarios(string nomUsuario, string pass)
        {
            //Desencriptar clave
            var claveDesencriptada = Decrypter.Desencriptar(pass);
            var usuarioObj = bd.UserWinForms.Where(x => x.Usuario.Equals(nomUsuario) && x.Clave.Equals(claveDesencriptada)).FirstOrDefault();
            return Json(usuarioObj);
        }
    }
}
