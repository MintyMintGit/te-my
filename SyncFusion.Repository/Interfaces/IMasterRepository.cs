using _1TE_MY.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Repository.Interfaces
{
  public  interface IMasterRepository
    {
        Task<List<UDC_Details>> GetMasterDetails(int moduleid);
        Task<List<UDC_Details>> GetAllMasterDetailsbyIds(List<int> moduleid);
        Task<List<UDC_Details>> GetAllMasterDetails();
        Task<List<Country>> GetAllCountries();
        Task<List<State>> GetAllStatesbyCountry(int CountryId);
        Task<List<City>> GetAllCitiesbyStates(int StateId);
		
	}
}
