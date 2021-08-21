using System;
using System.Collections.Generic;
using System.Text;

namespace UNO_CINCO.Models
{
    class Usuarios
    {
        public string usuario { get; set; }
        public string contrasenia { get; set; }

        public Usuarios(string usuario, string contrasenia)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
    }
}
