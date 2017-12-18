using _1TE_MY.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using System.Threading.Tasks;
using System.Linq;
using _1TE_MY.Models.DTO;

namespace _1TE_MY.Repository.Implementations
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private _1TEDBContext _context;
        public RegistrationRepository(_1TEDBContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveRegistartion(_1TE_MY.Models.Models.Registeration registration)
        {
            try
            {
                if (registration.RegistrationID > 0)
                {
                    var regmodel = _context.Registration.Where(o => o.RegistrationID == registration.RegistrationID).FirstOrDefault();
                    regmodel.FullName = registration.FullName;
                    regmodel.MobileNo = registration.MobileNo;
                    regmodel.MobileCountryID = registration.MobileCountryID;
                    regmodel.SecurityQuestion = registration.SecurityQuestion;
                    regmodel.Answer = registration.Answer;
                    _context.Update(regmodel);
                }
                else
                {
                    _context.Add(registration);

                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<bool> SaveUser(User user)
        {
            try
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<_1TE_MY.Models.Models.Registeration> GetRegistartionDetails(int RegistrationID)
        {
            try
            {
                return await _context.Registration.Where(o => o.RegistrationID == RegistrationID).ToAsyncEnumerable().FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
		public async Task<Registration_CompanyInformation> UpdateCompanyInformation(Registration_CompanyInformation registration)
		{
			try
			{
				var  data= await _context.Registration.Where(o => o.RegistrationID == registration.RegistrationId).ToAsyncEnumerable().FirstOrDefault();
				

				return new Registration_CompanyInformation();
			}
			catch (Exception)
			{

				throw;
			}
		}


	}
}
