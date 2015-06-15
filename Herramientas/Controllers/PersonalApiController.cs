using Services.Implementations;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace Herramientas.Controllers
{
    public class PersonalApiController : ApiController
    {
        private PersonalService _personalService;

        public PersonalApiController()
        {
            _personalService = new PersonalService();
        }

        public JsonResult Get()
        {
            List<Personal> personas = _personalService.GetPersonal();
            return Json(personas, JsonRequestBehavior.AllowGet);
        }

        private JsonResult Json(List<Personal> personas, JsonRequestBehavior jsonRequestBehavior)
        {
            throw new NotImplementedException();
        }
    }
}