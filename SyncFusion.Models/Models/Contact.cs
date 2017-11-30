using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("Contact", Schema = "root")]
    public class Contact
    {
        public int ContactID { get; set; }

        public int ContactTypeID { get; set; }

        public string FullName { get; set; }

        public int? DesignationID { get; set; }

        public string ContactEmail { get; set; }

        public int? OfficeCountryCodeID { get; set; }

        public string OfficePhoneNo { get; set; }

        public string Extention { get; set; }

        public int? MobileCountryCodeID { get; set; }

        public string MobilePhoneNo { get; set; }

        public int? FaxCountryCodeID { get; set; }

        public string FaxNo { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsVoid { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }
    }
}
