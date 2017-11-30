using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("State", Schema = "Master")]
    public class State
    {
        [Key]
        public int StateID { get; set; }

        public int CountryID { get; set; }

        public string StateName { get; set; }

        public string StateCode { get; set; }

        public string STDCode { get; set; }

        public bool? Active { get; set; }

        public bool? Void { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }

    }
}
