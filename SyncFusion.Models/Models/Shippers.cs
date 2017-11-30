using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models
{
    public class Shippers
    {
        [Key]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
}
}
