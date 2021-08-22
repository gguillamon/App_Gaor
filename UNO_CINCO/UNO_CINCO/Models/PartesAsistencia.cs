using System;
using System.Collections.Generic;
using System.Text;

namespace UNO_CINCO.Models
{
    class PartesAsistencia
    {
        public string idParte { get; set; }
        public string codigoEmpresa { get; set; }
        public string usuario { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public DateTime fecha { get; set; }
        public string contactoId { get; set; }
        public string tipoAsistencia { get; set; }
        public string Mantenimiento { get; set; }
        public string tipoCliente { get; set; }
        public string descripcion { get; set; }
        public byte [] firmaUser { get; set; }
        public byte[] firmaCliente { get; set; }

    }
}
