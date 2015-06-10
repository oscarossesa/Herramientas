using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Herramientas.Controllers
{
    public class DiccionarioDatosController : Controller
    {
        //
        // GET: /DiccionarioDatos/
        public ActionResult DiccionarioDatos()
        {

            return View();

            //using (DCCPProcurementEntities db = new DCCPProcurementEntities())
            //{

            //    //var result = db.ObtenerTablas();

            //    //Console.WriteLine("paso");

            //    //foreach (ObtenerTablas_Result otr in result)
            //    //{
            //    //    //Console.WriteLine(otr);

            //    //    //new EstructuraTabla {
            //    //    //    Tabla = otr.table,
            //    //    //    Columna = otr.column,
            //    //    //    EsAutonumerico = otr.Es_Autonumerico,
            //    //    //    ForeignKey = otr.ForeignKey,
            //    //    //    Presicion = otr.Precision,
            //    //    //    PermiteNulos = otr.Permite_Nulls,
            //    //    //    ObjectId = otr.object_id,
            //    //    //    MaxLength = otr.max_length,
            //    //    //    Tipo = otr.type,
            //    //    //    ReferenciaNombreColumna = otr.ReferenceColumnName,
            //    //    //    ReferenciaNombreTabla = otr.ReferenceTableName
            //    //    //}
            //    //}

            //    ////var result = db.ObtenerTablas();

            //    ////var tableList = db.Database.SqlQuery<EstructuraTabla>("exec ObtenerTablas").ToList<EstructuraTabla>();

            //    ////foreach (EstructuraTabla et in tableList)
            //    ////{
            //    ////    Console.WriteLine(et);
                    
            //    ////}

            //    ////return RESULT;
            //    return View(db.ObtenerTablas().AsEnumerable());
            //}      

            
        }
        
        //public void ObtenerEstructuraTablas()
        //{
        //    //TicketLog tl = null;

        //    return View();

        //    //using (DCCPProcurementEntities db = new DCCPProcurementEntities())
        //    //{

        //    //    var result = db.ObtenerTablas();

        //    //    Console.WriteLine("paso");

        //    //    foreach (ObtenerTablas_Result otr in result)
        //    //    {
        //    //        //Console.WriteLine(otr);
        //    //    }

        //    //    //return RESULT;
        //    //}            
        //}

    }
}
