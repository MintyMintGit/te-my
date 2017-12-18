using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("Merchant", Schema = "Master")]
    public class Merchant
    {
        [Key]
        public int MerchantCodeID { get; set; }
        public Nullable<int> BranchCodeID { get; set; }
        public string MerchantName { get; set; }
        public string RegNo { get; set; }
        public string GSTNo { get; set; }
        public string WebSite { get; set; }
        public string BillingCustomer { get; set; }
        public Nullable<short> BusinessType { get; set; }
        public string ForwardingAgentCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string FreeZoneAgentCode { get; set; }
        public string DirectDeclareAgentCode { get; set; }
        public string Remarks { get; set; }
        public bool IsBillingCustomer { get; set; }
        public bool IsShipper { get; set; }
        public bool IsPrincipal { get; set; }
        public bool IsConsignee { get; set; }
        public bool IsForwardingAgent { get; set; }
        public Nullable<bool> IsFreightForwarder { get; set; }
        public Nullable<bool> IsOriginAgent { get; set; }
        public Nullable<bool> IsDestinationAgent { get; set; }
        public bool IsHaulier { get; set; }
        public Nullable<bool> IsAirlineOperator { get; set; }
        public Nullable<bool> IsShippingAgent { get; set; }
        public bool IsTransporter { get; set; }
        public Nullable<bool> IsPortOperator { get; set; }
        public bool IsVendor { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string PortCode { get; set; }
        public string OwnerCode { get; set; }
        public string AgentCode { get; set; }
        public string YardCode { get; set; }
        public short BillingMethod { get; set; }
        public int CreditTerm { get; set; }
        public decimal CreditLimit { get; set; }
        public string DefaultCurrency { get; set; }
        public string CreditorCode { get; set; }
        public string DebtorCode { get; set; }
        public string EDIMappingCode { get; set; }
        public bool IsLiner { get; set; }
        public bool IsYard { get; set; }
        public bool IsCFS { get; set; }
        public bool IsRailOperator { get; set; }
        public bool IsTerminal { get; set; }
        public bool IsVMIVendor { get; set; }
        public bool IsRailYard { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsSelectContainer { get; set; }
        public decimal CurrentBalance { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> AddBy { get; set; }
        public System.DateTime AddOn { get; set; }
        public Nullable<int> ModBy { get; set; }
        public Nullable<System.DateTime> ModOn { get; set; }
        public bool IsVerified { get; set; }
        public string VerifiedBy { get; set; }
        public Nullable<System.DateTime> VerifiedOn { get; set; }
        public long CompanyCodeID { get; set; }
        public Nullable<bool> IsOverseasAgent { get; set; }
        public Nullable<bool> IsSubscriber { get; set; }
        public Nullable<bool> IsOriginal { get; set; }
        public Nullable<long> SubscriberCompanyCode { get; set; }
    }
}
