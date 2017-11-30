using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models.Models
{
    public class User
    {
        [Key]
        public int usrID { get; set; }

        public int? cmpID { get; set; }

        public string usrFullName { get; set; }

        public string usrEmailID { get; set; }

        public string usrPassword { get; set; }

        public string usrNRICNo { get; set; }

        public int? usrDesignation { get; set; }

        public string usrContactNo { get; set; }

        public int? usrType { get; set; }

    }
}
