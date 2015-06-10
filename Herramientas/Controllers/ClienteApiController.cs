using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Herramientas.Controllers
{
    public class ClienteApiController : Controller
    {
        //
        // GET: /ClienteApi/

        public ActionResult Index()
        {
            //LogTicket();

            return View();

            //return View(new PartialModel2() { partialModel = Sampledetails() });
            //return View(new PartialLogModel() { TicketLogList = LogTicket() });
        }

        //private List<PartialLogModel> Sampledetails()
        //{
        //    List<PartialLogModel> model = new List<PartialLogModel>();

        //    model.Add(new PartialLogModel()
        //    {
        //        Name = "Rima",
        //        Age = 20,
        //        Address="Kannur"
        //    });

        //    model.Add(new PartialLogModel()
        //    {
        //        Name = "Rohan",
        //        Age = 23,
        //        Address = "Ernakulam"
        //    });

        //    model.Add(new PartialLogModel()
        //    {
        //        Name = "Reshma",
        //        Age = 22,
        //        Address = "Kannur"
        //    });

        //    return model;
        //}

        //public List<TicketLog> LogTicket()
        //{
        //    var viewModel = new List<TicketLog>();

        //    //using (DCCPProcurementEntities db = new DCCPProcurementEntities())
        //    //{
        //    //    var result = from ticketLog in db.TicketLog
        //    //                 where ticketLog.IdTicket == 0
        //    //                 select ticketLog;
                
        //    //    foreach (var ticketLog in result)
        //    //        {
        //    //            viewModel.Add(new TicketLog
        //    //            {
        //    //                Id = ticketLog.Id,
        //    //                Fecha = ticketLog.Fecha,
        //    //                Ip = ticketLog.Ip,
        //    //                Texto = ticketLog.Texto,
        //    //                IdTicket = ticketLog.IdTicket,
        //    //                MasInformacion = ticketLog.MasInformacion
        //    //            });                       
        //    //        }
        //    //}            

        //    return viewModel;
        //}
    }
}
