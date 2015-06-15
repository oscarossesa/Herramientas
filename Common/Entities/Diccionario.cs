using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Diccionario
    {
        public string Tabla { get; set; }
        public string Columna { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }

    //public class Diccionario
    //{
    //    public Tabla Tabla { get; set; }
    //}


    public class Tabla
    {
        public string Nombre { get; set; }

        IList<Columna> _columnas;
    }

    public class Columna
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }
}
