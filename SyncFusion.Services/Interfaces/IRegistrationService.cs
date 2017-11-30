﻿using _1TE_MY.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Interfaces
{
   public interface IRegistrationService
    {
        Task<bool> SaveRegistartion(Registration_UserInformation registrationdto);
        Task<bool> SaveUser(Registration_UserInformation user);
        Task<Registration_UserInformation> GetRegistartionDetails(int RegistrationID);
		Task<Registration_CompanyInformation> UpdateCompanyInformation(Registration_CompanyInformation registrationdto);
	}
}
