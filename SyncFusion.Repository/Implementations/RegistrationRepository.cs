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
        public async Task<bool> SaveRegistartion(Registration registration)
        {
            try
            {
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
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
        public async Task<Registration> GetRegistartionDetails(int RegistrationID)
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
				var  data= _context.Registration.Where(o => o.RegistrationID == registration.RegistrationId).ToAsyncEnumerable().FirstOrDefault();
				

				return new Registration_CompanyInformation();
			}
			catch (Exception)
			{

				throw;
			}
		}


	}
}
