using _1TE_MY.Models.DTO;
using _1TE_MY.Models.Models;
using _1TE_MY.Repository.Interfaces;
using _1TE_MY.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Implementations
{
    public class RegistrationService : IRegistrationService
    {
        private IRegistrationRepository _registrationRepository;
        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }
        public async Task<bool> SaveRegistartion(Registration_UserInformation registrationdto)
        {
            try
            {
                var registration = Mapper.Map<Registration_UserInformation, _1TE_MY.Models.Models.Registration>(registrationdto);
                await _registrationRepository.SaveRegistartion(registration);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> SaveUser(Registration_UserInformation user)
        {
            try
            {
                var usermodel = Mapper.Map<Registration_UserInformation, _1TE_MY.Models.Models.User>(user);
                await _registrationRepository.SaveUser(usermodel);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Registration_UserInformation> GetRegistartionDetails(int RegistrationID)
        {
            try
            {
                var usermodel =await _registrationRepository.GetRegistartionDetails(RegistrationID);
                var registermodel =  Mapper.Map<_1TE_MY.Models.Models.Registration, Registration_UserInformation>(usermodel);
                return registermodel;
            }
            catch (Exception)
            {

                throw;
            }
        }
		
		public async Task<Registration_CompanyInformation> UpdateCompanyInformation(Registration_CompanyInformation RegistrationID)
		{
			try
			{
				var usermodel = await _registrationRepository.UpdateCompanyInformation(RegistrationID);
				var registermodel = Mapper.Map< Registration_CompanyInformation>(usermodel);
				return registermodel;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
