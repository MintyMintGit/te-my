using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Models.DTO
{
    public class Registeration
    {
        public Registration_UserInformation Registration_UserInformation { get; set; }
        public Registration_ContactPerson Registration_ContactPerson { get; set; }
        public Registration_CompanyInformation Registration_CompanyInformation { get; set; }
        public Registration_Modules Registration_Modules { get; set; }

        public List<Registration_Documents> Registration_Documents { get; set; }
    }
}
