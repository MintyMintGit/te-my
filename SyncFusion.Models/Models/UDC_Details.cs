using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("UDC_Details",Schema = "Config")]
    public class UDC_Details
    {
        [Key]
        public int UDC_dID { get; set; }

        public int UDC_mID { get; set; }

        public string UDC_dCode { get; set; }

        public string UDC_dDesc { get; set; }

        public bool? isActive { get; set; }

        public bool? isDEL { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }

    }

}
