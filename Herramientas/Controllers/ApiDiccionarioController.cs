using Common.Entities;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Services.Implementations;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Herramientas.Controllers
{
    public class ApiDiccionarioController : ApiController
    {
        private DiccionarioSerivice _diccionarioService;

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

        //[Route("customers/{customerId}/orders")]
        //[HttpGet]
        //public HttpResponseMessage WordDocument()
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        using (WordprocessingDocument package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
        //        {
        //            MainDocumentPart mainPart = package.AddMainDocumentPart();
        //            mainPart.Document = new Document();
        //            var body = new Body();
        //            Paragraph paragraph = new Paragraph();
        //            Run run = new Run(new Text("Hello World!"));
        //            //run.Append(new Text("Hello World!"));
        //            paragraph.Append(run);
        //            body.Append(paragraph);
        //            mainPart.Document.Append(body);
        //            package.Close();
        //        }

        //        HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
        //        result.Content = new ByteArrayContent(ms.ToArray());
        //        result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.ms-word");
        //        result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
        //        result.Content.Headers.ContentDisposition.FileName = "HelloWorld.docx";
        //        return result;
        //    }
        //}
    }
}