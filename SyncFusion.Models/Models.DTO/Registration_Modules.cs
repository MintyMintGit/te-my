using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Models.DTO
{
    public class Registration_Modules
    {
        public int Id { get; set; }

        public string ModuleId { get; set; }

        public string ModuleDescription { get; set; }

        public double ModulePrice { get; set; }

        public bool IsSubscribe { get; set; }
    }
}
