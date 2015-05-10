using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Herramientas.Models
{
    public class EstructuraTabla
    {
        public string Columna { get; set; }
        public string EsAutonumerico { get; set; }
        public string ForeignKey { get; set; }
        public int MaxLength { get; set; }
        public int ObjectId { get; set; }
        public string PermiteNulos { get; set; }
        public Nullable<byte> Presicion { get; set; }
        public string ReferenciaNombreColumna { get; set; }
        public string ReferenciaNombreTabla { get; set; }
        public string Tabla { get; set; }
        public string Tipo { get; set; }
    }
}