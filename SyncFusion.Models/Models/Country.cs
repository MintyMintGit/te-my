using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace _1TE_MY.Models.Models
{
    [Table("Country", Schema = "Master")]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public string ISOc2 { get; set; }

        public string ISOc3 { get; set; }

        public string ISOno { get; set; }

        public string DailingCode { get; set; }

        public string EDIMapping { get; set; }

        public bool IsActive { get; set; }

        public bool IsVoid { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }
    }
}
