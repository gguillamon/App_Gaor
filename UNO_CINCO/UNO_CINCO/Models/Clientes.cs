using System;

namespace UNO_CINCO.Models
{
    public class Clientes
    {
        

        public string codigo { get; set; }
        public string Codigo { get; internal set; }
        public string razon { get; set; }
        public string Razon { get; internal set; }
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

    
    }
}