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
    
    public partial class prcSpcReadprcBIDQuoteAndBidItemInformar_Result
    {
        public int bidID { get; set; }
        public Nullable<int> bidRFBCode { get; set; }
        public string bidOrganization { get; set; }
        public Nullable<short> bidCorrelative { get; set; }
        public string bidUser { get; set; }
        public string bidName { get; set; }
        public string bidDescription { get; set; }
        public string bidSupplierReference { get; set; }
        public Nullable<int> bidDocumentStatus { get; set; }
        public Nullable<short> bidAdministrativeQualify { get; set; }
        public string bidAdministrativeScore { get; set; }
        public Nullable<int> bidTechnicalStatus { get; set; }
        public Nullable<System.DateTime> bidTechnicalIssueDate { get; set; }
        public Nullable<short> bidTechnicalQualify { get; set; }
        public string bidTechnicalScore { get; set; }
        public Nullable<int> bidEconomicStatus { get; set; }
        public Nullable<System.DateTime> bidEconomicIssueDate { get; set; }
        public Nullable<short> bidEconomicQualify { get; set; }
        public string bidEconomicScore { get; set; }
        public Nullable<short> bidIsAwarded { get; set; }
        public string bidFinalScore { get; set; }
        public string bidAwardComment { get; set; }
        public string bidRQuoteComment { get; set; }
        public int bitID { get; set; }
        public int bitBID { get; set; }
        public int bitItem { get; set; }
        public Nullable<short> bitIsBidded { get; set; }
        public Nullable<double> bitQuantity { get; set; }
        public string bitCurrency { get; set; }
        public Nullable<double> bitUnitNetPrice { get; set; }
        public Nullable<double> bitHomologatedPrice { get; set; }
        public Nullable<double> bitUniqueCurrencyPrice { get; set; }
        public Nullable<short> bitIsLowestPrice { get; set; }
        public Nullable<short> bitIsSelected { get; set; }
        public Nullable<double> bitAwardedQuantity { get; set; }
        public string bitSupplierComment { get; set; }
        public string Rut { get; set; }
        public string orgLegalName { get; set; }
    }
}