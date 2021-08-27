using System;
using System.Collections.Generic;
using System.Text;

namespace UNO_CINCO.Models
{
    public class PartesAsistencia
    {
        public int IdParte { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Usuario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public DateTime Fecha { get; set; }
        public string ContactoId { get; set; }
        public string TipoAsistencia { get; set; }
        public string Mantenimiento { get; set; }
        public string TipoCliente { get; set; }
        public string Descripcion { get; set; }
        public byte [] FirmaUser { get; set; }
        public byte[] FirmaCliente { get; set; }

    }
}
