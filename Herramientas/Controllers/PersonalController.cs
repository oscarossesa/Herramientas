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

        [HttpPost]
        public ActionResult Create(Personal personal)
        {
            try
            {
                var path = Server.MapPath("~/personal.json");

                //using (StreamReader r = new StreamReader(path))
                //{
                //    string json = r.ReadToEnd();
                //    List<Personal> items = JsonConvert.DeserializeObject<List<Personal>>(json);
                //}

                //string json = System.IO.File.ReadAllText(path);
                //dynamic jsonObj = JsonConvert.DeserializeObject(json);
                //jsonObj["Personal"][0]["Nombre"] = "Oscar Osses Arriaza";
                //string output = JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                //System.IO.File.WriteAllText(path, output);


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

    public class Item
    {
        public int millis;
        public string stamp;
        public DateTime datetime;
        public string light;
        public float temp;
        public float vcc;
    }
}
