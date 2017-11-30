using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace _1TE_MY.Models.Models
{
  public  class Address
    {
	    public int CountryID { get; set; }
		public int StateID { get; set; }
		public int CityID { get; set; }
		public string raAddress1 { get; set; }
		public string raAddress2 { get; set; }
		public string raAddress3 { get; set; }
		public string raPostCode { get; set; }
		

	}
}
