using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Herramientas.Models
{
    public partial class PartialLogModel
    {
        public List<TicketLog> TicketLogList { get; set; }
    }

    public partial class PartialEstructuraTablasModel
    {
        public ObtenerTablas_Result EstructuraTablas { get; set; }
    }
}