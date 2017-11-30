using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Models.DTO
{
    public class Registration_CompanyInformation
    {
		public int RegistrationId { get; set; }
		public string CompanyName { get; set; }
		public string Address1 { get; set; }
		public int OganizationType { get; set; }
		public string Address2 { get; set; }
		public string CompanyRegisterationNumber { get; set; }
		public string Address3 { get; set; }
		public string GSTRegisterationNumber { get; set; }
		public string City { get; set; }
		public DateTime GSTRegisterationDate { get; set; }
		public string State { get; set; }
		public string DagangNetAccountNo { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
		public string ForwardingAgentCode { get; set; }
		public string ShippingAgentCode	{ get; set; }
		
		public int AddressId { get; set; }
	}
}
