using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Implementations;

namespace Herramientas.Controllers
{
    public class ApiDiccionarioController : ApiController
    {
        DiccionarioSerivice _diccionarioService;

        public ApiDiccionarioController()
        {
            _diccionarioService = new DiccionarioSerivice();
        }

        // GET api/apidiccionario
        public IEnumerable<Diccionario> Get()
        {
            return _diccionarioService.GetTablas().ToList();
        }

        // GET api/apidiccionario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/apidiccionario
        public void Post([FromBody]string value)
        {
        }

        // PUT api/apidiccionario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/apidiccionario/5
        public void Delete(int id)
        {
        }
    }
}
