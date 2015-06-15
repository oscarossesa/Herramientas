using Common.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Services.Implementations;

namespace Herramientas.Controllers
{
    public class PersonalController : Controller
    {
        private PersonalService _personalService;

        public PersonalController()
        {
            _personalService = new PersonalService();
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
            List<Personal> personas = _personalService.GetPersonal();
            return Json(personas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(Personal personal)
        {
            try
            {
                var path = Server.MapPath("~/personal.json");
                _personalService.AddPersonal(personal);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json("ok");
        }
    }
}