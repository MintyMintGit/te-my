﻿using _1TE_MY.Models.DTO;
using _1TE_MY.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Repository.Interfaces
{
    public interface IRegistrationRepository
    {
        Task<bool> SaveRegistartion(_1TE_MY.Models.Models.Registeration registration);
        Task<bool> SaveUser(User user);
        Task<_1TE_MY.Models.Models.Registeration> GetRegistartionDetails(int RegistrationID);
		Task<Registration_CompanyInformation> UpdateCompanyInformation(Registration_CompanyInformation registration); 
	}
}
