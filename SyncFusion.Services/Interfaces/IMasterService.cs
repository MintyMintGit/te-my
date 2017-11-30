using _1TE_MY.Models.DTO;
using _1TE_MY.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Interfaces
{
   public interface IMasterService
    {
         Task<List<DropdownDTO>> GetMasterDetails(int moduleid);
        Task<List<DropdownDTO>> GetAllMasterDetailsbyIds(List< int> moduleid);
        Task<List<DropdownDTO>> GetAllMasterDetails();
          Task<List<DropdownDTO>> GetAllCountries();
          Task<List<DropdownDTO>> GetAllStatesbyCountry(int CountryId);
          Task<List<DropdownDTO>> GetAllCitiesbyStates(int StateId);

		Task<List<Country>> GetAllCountries_Cascading();
		Task<List<State>> GetAllStatesbyCountry_Cascading(int CountryId);
		Task<List<City>> GetAllCitiesbyStates_Cascading(int StateId);

	}
}
