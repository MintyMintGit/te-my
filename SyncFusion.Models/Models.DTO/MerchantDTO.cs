using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models.Models.DTO
{
    public class MerchantDTO
    {
        public int MerchantCodeID { get; set; }
        public int? BranchCodeID { get; set; }
        [Required]
        public string MerchantName { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string GSTNo { get; set; }
        [Required]
        [Url]
        public string WebSite { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string BillingCustomer { get; set; }//
        public int? BusinessType { get; set; }//
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string ForwardingAgentCode { get; set; }//need clarify
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string ShippingAgentCode { get; set; }//
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string FreeZoneAgentCode { get; set; }//
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string DirectDeclareAgentCode { get; set; }//

        [Required]
        public string Remarks { get; set; }//
        [Required]
        public bool IsBillingCustomer { get; set; }//
        [Required]
        public bool IsShipper { get; set; }//
        [Required]
        public bool IsPrincipal { get; set; } //
        [Required]
        public bool IsConsignee { get; set; }//
        [Required]
        public bool IsForwardingAgent { get; set; }//
        [Required]
        public bool IsFreightForwarder { get; set; }//
        [Required]
        public bool IsOriginAgent { get; set; } //
        [Required]
        public bool IsDestinationAgent { get; set; }//
        [Required]
        public bool IsHaulier { get; set; }//
        [Required]
        public bool IsAirlineOperator { get; set; }//
        [Required]
        public bool IsShippingAgent { get; set; }//
        [Required]
        public bool IsTransporter { get; set; }//
        [Required]
        public bool IsPortOperator { get; set; }//
        [Required]
        public bool IsVendor { get; set; }//

        public int? AddressID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string PortCode { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string OwnerCode { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string AgentCode { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The length of the string must be less 10 characters")]
        public string YardCode { get; set; }
        [Required]
        public int BillingMethod { get; set; }
        [Required]
        public int CreditTerm { get; set; }
        [Required]
        public double CreditLimit { get; set; }
        [Required]
        public string DefaultCurrency { get; set; }
        [Required]
        public string CreditorCode { get; set; }
        [Required]
        public string DebtorCode { get; set; }
        [Required]
        public string EDIMappingCode { get; set; }
        [Required]
        public bool IsLiner { get; set; }
        [Required]
        public bool IsYard { get; set; }
        [Required]
        public bool IsCFS { get; set; }
        [Required]
        public bool IsRailOperator { get; set; }
        [Required]
        public bool IsTerminal { get; set; }
        [Required]
        public bool IsVMIVendor { get; set; }
        [Required]
        public bool IsRailYard { get; set; }
        [Required]
        public bool IsTaxable { get; set; }
        [Required]
        public bool IsSelectContainer { get; set; }
        [Required]
        public decimal CurrentBalance { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public int? AddBy { get; set; }
        [Required]
        public DateTime AddOn { get; set; }

        public int? ModBy { get; set; }
        public DateTime? ModOn { get; set; }
        [Required]
        public bool IsVerified { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        [Required]
        public long CompanyCodeID { get; set; }

        public bool? IsOverseasAgent { get; set; }
        public bool? IsSubscriber { get; set; }
        public bool? IsOriginal { get; set; }
        public long? SubscriberCompanyCode { get; set; }

        //public List<BusinessType> BusinessType { get; set; }
    }
}
