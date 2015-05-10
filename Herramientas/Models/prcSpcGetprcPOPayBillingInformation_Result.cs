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
    
    public partial class prcSpcGetprcPOPayBillingInformation_Result
    {
        public int porID { get; set; }
        public Nullable<int> porRequisition { get; set; }
        public Nullable<int> porSourceDocumentType { get; set; }
        public Nullable<int> porSourceDocumentNumber { get; set; }
        public Nullable<int> porIsEnabled { get; set; }
        public Nullable<System.DateTime> porCreationDate { get; set; }
        public Nullable<System.DateTime> porSendDate { get; set; }
        public Nullable<int> porIsIntegrated { get; set; }
        public string porMkpDocumentReference { get; set; }
        public string porMkpBuyerReference { get; set; }
        public string porMkpUserReference { get; set; }
        public string porMkpSellerReference { get; set; }
        public Nullable<int> porLanguage { get; set; }
        public Nullable<int> porSchema { get; set; }
        public string porCategory { get; set; }
        public string porCode { get; set; }
        public string porName { get; set; }
        public string porDescription { get; set; }
        public Nullable<int> porOrderType { get; set; }
        public Nullable<int> porOrderPurpose { get; set; }
        public Nullable<int> porJustifyType { get; set; }
        public string porCurrency { get; set; }
        public string porAccount { get; set; }
        public string porBuyerOrganization { get; set; }
        public string porBuyerUser { get; set; }
        public string porBuyerReference { get; set; }
        public Nullable<int> porBuyerStatus { get; set; }
        public Nullable<int> porBuyerAlternateStatus { get; set; }
        public Nullable<System.DateTime> porBuyerStatusDate { get; set; }
        public string porBuyerNotes { get; set; }
        public string porSellerOrganization { get; set; }
        public string porSellerUser { get; set; }
        public string porSellerReference { get; set; }
        public Nullable<int> porSellerStatus { get; set; }
        public Nullable<int> porSellerAlternateStatus { get; set; }
        public Nullable<System.DateTime> porSellerStatusDate { get; set; }
        public string porSellerNotes { get; set; }
        public Nullable<int> porPaymentType { get; set; }
        public Nullable<int> porPaymentMethod { get; set; }
        public Nullable<int> porShipmentType { get; set; }
        public Nullable<int> porInvoiceAddress { get; set; }
        public Nullable<int> porShipAddress { get; set; }
        public string porShipInstructions { get; set; }
        public string porHandlingInstructions { get; set; }
        public string porSpecialInstructions { get; set; }
        public string porDeliveryInstructions { get; set; }
        public Nullable<double> porTotalCharges { get; set; }
        public Nullable<double> porTotalDiscounts { get; set; }
        public Nullable<double> porTotalTaxes { get; set; }
        public Nullable<double> porTotalAmount { get; set; }
        public string porDiscountsComments { get; set; }
        public string porChargesComments { get; set; }
        public Nullable<double> porPercentTaxes { get; set; }
        public Nullable<int> porTaxCode { get; set; }
        public string porUserDefined1 { get; set; }
        public string porUserDefined2 { get; set; }
        public string porUserDefined3 { get; set; }
        public Nullable<System.DateTime> porCancelDate { get; set; }
        public Nullable<System.DateTime> porDateDelivery { get; set; }
        public Nullable<int> porBuyerCity { get; set; }
        public Nullable<System.DateTime> porDateModification { get; set; }
        public string porBuyerEnterprise { get; set; }
        public string porSellerEnterprise { get; set; }
        public string presupuestoCode { get; set; }
        public Nullable<int> psrID { get; set; }
        public Nullable<int> psrOrder { get; set; }
        public string psrBuyerOrganizationName { get; set; }
        public string psrBuyerOrganizationLegalName { get; set; }
        public string psrBuyerTaxID { get; set; }
        public string psrBuyerActivity { get; set; }
        public string psrBuyerAddress { get; set; }
        public string psrBuyerAddressComplement { get; set; }
        public string psrBuyerCountry { get; set; }
        public string psrBuyerCity { get; set; }
        public string psrBuyerDistrict { get; set; }
        public string psrBuyerPhone { get; set; }
        public string psrBuyerFax { get; set; }
        public string psrBuyerContactFirstName { get; set; }
        public string psrBuyerContactLastName { get; set; }
        public string psrBuyerContactPosition { get; set; }
        public string psrBuyerContactEmail { get; set; }
        public string psrBuyerContactPhone { get; set; }
        public string psrBuyerContactMobile { get; set; }
        public string psrBuyerContactFax { get; set; }
        public string psrSellerOrganizationName { get; set; }
        public string psrSellerOrganizationLegalName { get; set; }
        public string psrSellerTaxID { get; set; }
        public string psrSellerActivity { get; set; }
        public string psrSellerAddress { get; set; }
        public string psrSellerAddressComplement { get; set; }
        public string psrSellerCountry { get; set; }
        public string psrSellerCity { get; set; }
        public string psrSellerDistrict { get; set; }
        public string psrSellerPhone { get; set; }
        public string psrSellerFax { get; set; }
        public string psrSellerContactFirstName { get; set; }
        public string psrSellerContactLastName { get; set; }
        public string psrSellerContactPosition { get; set; }
        public string psrSellerContactEmail { get; set; }
        public string psrSellerContactPhone { get; set; }
        public string psrSellerContactMobile { get; set; }
        public string psrSellerContactFax { get; set; }
        public Nullable<int> orgID { get; set; }
        public Nullable<short> orgIsActive { get; set; }
        public string orgCode { get; set; }
        public Nullable<short> orgIsTest { get; set; }
        public string orgEnterprise { get; set; }
        public string orgParentOrganization { get; set; }
        public Nullable<int> orgClass { get; set; }
        public Nullable<int> orgType { get; set; }
        public Nullable<int> orgSubType { get; set; }
        public string orgName { get; set; }
        public string orgLegalName { get; set; }
        public string orgTaxID { get; set; }
        public string orgMarketplaceID { get; set; }
        public string orgActivity { get; set; }
        public string orgUrl { get; set; }
        public string orgUserDefined1 { get; set; }
        public string orgUserDefined2 { get; set; }
        public string orgUserDefined3 { get; set; }
        public Nullable<short> orgInformation { get; set; }
        public Nullable<System.DateTime> orgCreationDate { get; set; }
        public Nullable<int> entCalifications { get; set; }
        public Nullable<double> entScore { get; set; }
    }
}
