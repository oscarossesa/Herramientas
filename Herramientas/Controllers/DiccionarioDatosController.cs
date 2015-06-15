using Common.Entities;
using Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Herramientas.Controllers
{
    public class DiccionarioDatosController : Controller
    {
        //
        // GET: /DiccionarioDatos/
        public ActionResult DiccionarioDatos()
        {
            //IEnumerable<Diccionario> products = diccionarioDatosDominio.GetTablas();
            return View();
        }
    }
}