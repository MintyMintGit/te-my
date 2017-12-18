using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("Registration", Schema = "Root")]
    public class Registeration
    {
        [Key]
        public int RegistrationID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? SecurityQuestion { get; set; }

        public string Answer { get; set; }

        public string NRIC { get; set; }

        public int? MobileCountryID { get; set; }

        public string MobileNo { get; set; }

        public bool? IsOTPSent { get; set; }

        public string OTPNo { get; set; }

        public DateTime? OTPSentDate { get; set; }

        public bool? IsOTPVerified { get; set; }

        public DateTime? OPTVerifiedOn { get; set; }

        public bool? IsOTPReSent { get; set; }

        public byte? OTPSentCount { get; set; }

        public string EmailToken { get; set; }

        public bool? IsEmailSent { get; set; }

        public DateTime? EmailOn { get; set; }

        public bool? IsEmailVerified { get; set; }

        public DateTime? EmailVerifiedOn { get; set; }

        public string CompanyName { get; set; }

        public int? OrganisationType { get; set; }

        public string Comp_RegNo { get; set; }

        public string AgentCode { get; set; }

        public bool? IsDeclared { get; set; }

        public DateTime? DeclaredDate { get; set; }

        public DateTime? Comp_GSTRegistrationDate { get; set; }

        public string Comp_GSTNo { get; set; }

        public string CPAMAccountNo { get; set; }

        public int? RegistrationStatus { get; set; }

        public string Remarks { get; set; }

        public int? RegCountryID { get; set; }

        public int? AddressID { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }

        public bool? isApproved { get; set; }

        public bool? isTransfer { get; set; }

        public bool? isAdminEntry { get; set; }

        public bool? isDelete { get; set; }

        public int? MapID { get; set; }

    }
}
