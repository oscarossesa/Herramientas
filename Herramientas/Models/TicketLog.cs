//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Herramientas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketLog
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Ip { get; set; }
        public string Texto { get; set; }
        public int IdTicket { get; set; }
        public string MasInformacion { get; set; }
    }
}