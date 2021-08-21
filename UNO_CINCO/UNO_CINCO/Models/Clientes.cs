using System;

namespace UNO_CINCO.Models
{
    public class Clientes
    {
        

        public string codigo { get; set; }
        public string razon { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public string cp { get; set; }
        public string pais { get; set; }
        public string telefono1{ get; set; }
        public string telefono2 { get; set; }
        public string fax { get; set; }
        public string web { get; set; }

        public Clientes(string codigo, string razon, string nombre, string alias, string email, string direccion, string localidad, string provincia, string cp, string pais, string telefono1, string telefono2, string fax, string web)
        {
            this.codigo = codigo;
            this.razon = razon;
            this.nombre = nombre;
            this.alias = alias;
            this.email = email;
            this.direccion = direccion;
            this.localidad = localidad;
            this.provincia = provincia;
            this.cp = cp;
            this.pais = pais;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.fax = fax;
            this.web = web;
        }
    }
}