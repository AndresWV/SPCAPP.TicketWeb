using Microsoft.AspNetCore.Mvc;
using SPCAPP.TicketWeb.Data;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Clases
{
    public class BackLogin
    {
        //conexion con la base de datos
        public readonly ApplicationDbContext _context;
        public readonly SPCTKContext _bd;
        public SPCTKContext bd = new SPCTKContext();

        public UserWinForm getUsuarios(string nomUsuario, string pass)
        {
            //Desencriptar clave
            var claveDesencriptada = Decrypter.Encriptar(pass);
            var usuarioObj = bd.UserWinForms.Where(x => x.Usuario.Equals(nomUsuario) && x.Clave.Equals(claveDesencriptada)).FirstOrDefault();
            return usuarioObj;
        }
    }
}
