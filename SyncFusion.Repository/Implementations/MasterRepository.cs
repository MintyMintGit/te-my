using _1TE_MY.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _1TE_MY.Repository.Interfaces;
using System.Threading.Tasks;

namespace _1TE_MY.Repository.Implementations
{
    public class MasterRepository: IMasterRepository
    {
        private _1TEDBContext _context;
        public MasterRepository(_1TEDBContext context)
        {
            _context = context;
        }
        public async Task< List<UDC_Details>> GetMasterDetails(int moduleid)
        {
            return await _context.UDC_Detail.Where(d => (d.isActive == true && (d.isDEL==false || d.isDEL==null)) && d.UDC_mID== moduleid).ToAsyncEnumerable().ToList();
        }
        public async Task<List<UDC_Details>> GetAllMasterDetailsbyIds(List< int> moduleid)
        {
            return await _context.UDC_Detail.Where(d => (  d.isActive == true && (d.isDEL == false || d.isDEL == null)) &&  moduleid.Contains(d.UDC_mID)).ToAsyncEnumerable().ToList();
        }
        public async Task<List<UDC_Details>> GetAllMasterDetails()
        {
            return await _context.UDC_Detail.Where(d => (d.isActive == true && (d.isDEL == false || d.isDEL == null))).ToAsyncEnumerable().ToList();
        }

        public async Task<List<Country>> GetAllCountries()
        {
            return await _context.Country.Where(o=>o.IsActive==true).ToAsyncEnumerable().ToList();
        }
        public async Task<List<State>> GetAllStatesbyCountry(int CountryId)
        {if (CountryId == 0)
			{
				return await _context.State.Where(o => (o.Active == true || o.Active == null)).ToAsyncEnumerable().ToList();
			}
		else
            return await _context.State.Where(o => (o.Active == true || o.Active==null) && o.CountryID==CountryId).ToAsyncEnumerable().ToList();
        }
        public async Task<List<City>> GetAllCitiesbyStates(int StateId)
        {
			if (StateId == 0)
			{
				return await _context.City.Where(o => (o.Active == true || o.Active == null)).ToAsyncEnumerable().ToList();
			}
			else
            return await _context.City.Where(o => (o.Active == true || o.Active == null) && o.StateID == StateId).ToAsyncEnumerable().ToList();
        }
    }


}
