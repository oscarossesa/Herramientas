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
    
    public partial class prcSpcReadprcBIDItemToConfirm_Result
    {
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
        public string rbhEstimatedCurrency { get; set; }
        public string itemCurrName { get; set; }
        public string estimatedCurrName { get; set; }
        public string bidUser { get; set; }
        public string bidOrganization { get; set; }
    }
}
