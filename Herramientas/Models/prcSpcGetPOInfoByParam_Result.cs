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
    
    public partial class prcSpcGetPOInfoByParam_Result
    {
        public int porID { get; set; }
        public string porCode { get; set; }
        public Nullable<int> porBuyerStatus { get; set; }
        public Nullable<int> porBuyerOrganization { get; set; }
        public Nullable<int> porSellerStatus { get; set; }
        public string porSellerOrganization { get; set; }
        public Nullable<System.DateTime> porCreationDate { get; set; }
        public Nullable<System.DateTime> porSendDate { get; set; }
        public string orgCode { get; set; }
        public string orgTaxID { get; set; }
    }
}
