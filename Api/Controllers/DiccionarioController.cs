using Common.Entities;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Services.Implementations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Api.Controllers
{
    public class DiccionarioController : ApiController
    {
        private DiccionarioSerivice _diccionarioService;

        public DiccionarioController()
        {
            _diccionarioService = new DiccionarioSerivice();
        }

        // GET api/Diccionario
        public IEnumerable<Diccionario> Get()
        {
            return _diccionarioService.GetTablas().ToList();
        }

        // GET: api/Diccionario/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/diccionario/word")]
        [HttpGet]
        public HttpResponseMessage WordDocument()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (WordprocessingDocument package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = package.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = new Body();
                    Paragraph paragraph = new Paragraph();
                    Run run = new Run(new Text("Hello World!"));
                    //run.Append(new Text("Hello World!"));
                    paragraph.Append(run);
                    body.Append(paragraph);
                    mainPart.Document.Append(body);
                    package.Close();
                }

                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(ms.ToArray());
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.ms-word");
                result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                result.Content.Headers.ContentDisposition.FileName = "HelloWorld.docx";
                return result;
            }
        }

        // POST: api/Diccionario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Diccionario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Diccionario/5
        public void Delete(int id)
        {
        }
    }
}
