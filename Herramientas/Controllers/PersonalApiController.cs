using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Herramientas.Controllers
{
    public class PersonalApiController : ApiController
    {
        DominioPersonal _dominioPersonal;

        public PersonalApiController()
        {
            DominioPersonal _dominioPersonal = new DominioPersonal();
        }
        
        public JsonResult Get()
        {
            //var path = Server.MapPath("~/personal.json");
            List<Personal> personas = _dominioPersonal.GetPersonal();

            return Json(personas, JsonRequestBehavior.AllowGet);
        }

        private JsonResult Json(List<Personal> personas, JsonRequestBehavior jsonRequestBehavior)
        {
            throw new NotImplementedException();
        }
    }
}
