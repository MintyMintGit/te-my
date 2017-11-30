using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("City", Schema = "Master")]
 public   class City
    {
        [Key]
        public int CityID { get; set; }

        public int StateID { get; set; }

        public int CountryID { get; set; }

        public string CityName { get; set; }

        public string CityCode { get; set; }

        public bool? Active { get; set; }

        public bool? Void { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }
    }
}
