using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Entidades;
using System.IO;
using Newtonsoft.Json;

namespace Herramientas.Controllers
{
    public class PersonalController : Controller
    {
        DominioPersonal _dominioPersonal;
        public PersonalController()
        {
            _dominioPersonal = new DominioPersonal();
        }
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
            //var path = Server.MapPath("~/personal.json");        
            List<Personal> personas = _dominioPersonal.GetPersonal();

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
                dominioPersonal.AddPersonal(personal);
                    
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
            
            return Json("ok");
        }
    }
}
