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
    
    public partial class ObtenerAutorizacion_Result
    {
        public string IdUsuario { get; set; }
        public string Token { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaExpiracion { get; set; }
        public Nullable<System.DateTime> FechaUltimoAcceso { get; set; }
        public bool Autenticado { get; set; }
        public long SessionId { get; set; }
    }
}
