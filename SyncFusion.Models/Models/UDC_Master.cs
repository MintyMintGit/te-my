using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models.Models
{
    [Table("UDC_Master", Schema = "Config")]
    public class UDC_Master
    {[Key]
        public int UDC_mID { get; set; }

        public string UDC_mCode { get; set; }

        public string UDC_mDesc { get; set; }

        public bool? isActive { get; set; }

        public bool? isDEL { get; set; }

        public int? AddBy { get; set; }

        public DateTime? AddOn { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }
    }
}
