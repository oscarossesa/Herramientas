using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Herramientas.Models;
using Dominio;
using Entidades;
using System.IO;
using Newtonsoft.Json;

namespace Herramientas.Controllers
{
    public class PersonalController : Controller
    {
        //
        // GET: /Personal/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Personal/

        public JsonResult Get()
        {
            var path = Server.MapPath("~/personal.json");

            //do something with model
            DominioPersonal dominioPersonal = new DominioPersonal();
            List<Personal> personas = dominioPersonal.GetPersonal(path);

            return Json(personas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(Personal personal)
        {
            try
            {
                var path = Server.MapPath("~/personal.json");

                //do something with model
                DominioPersonal dominioPersonal = new DominioPersonal();
                if (!dominioPersonal.AgregarPersonal(personal, path))
                    return Json("error");
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
            
            return Json("ok");
        }
    }
}
