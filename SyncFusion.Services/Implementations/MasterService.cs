using _1TE_MY.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.DTO;
using _1TE_MY.Repository.Interfaces;
using AutoMapper;
using _1TE_MY.Models.Models;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Implementations
{
    public class MasterService : IMasterService
    {
        private IMasterRepository _masterRepository;
        public MasterService(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task< List<DropdownDTO>> GetAllMasterDetailsbyIds(List<int> moduleid)
        {
            var listmaster = await _masterRepository.GetAllMasterDetailsbyIds(moduleid);
            List<DropdownDTO> masterDtoList = Mapper.Map<List<UDC_Details>, List<DropdownDTO>>(listmaster);
            return masterDtoList;

        }
        public async Task<List<DropdownDTO>> GetAllMasterDetails()
        {
            var listmaster = await _masterRepository.GetAllMasterDetails();
            List<DropdownDTO> masterDtoList = Mapper.Map<List<UDC_Details>, List<DropdownDTO>>(listmaster);
            return masterDtoList;

        }
        public async Task<List<DropdownDTO>> GetMasterDetails(int moduleid)
        {
            var listmaster = await _masterRepository.GetMasterDetails(moduleid);
            List<DropdownDTO> masterDtoList = Mapper.Map<List<UDC_Details>, List<DropdownDTO>>(listmaster);
            return masterDtoList;
        }
        public async Task<List<DropdownDTO>> GetAllCountries()
        {
            var listmaster = await _masterRepository.GetAllCountries();
            List<DropdownDTO> masterGetAllCountries = Mapper.Map<List<Country>, List<DropdownDTO>>(listmaster);
            return masterGetAllCountries;
        }
        public async Task<List<DropdownDTO>> GetAllStatesbyCountry(int CountryId)
        {
            var liststatemaster = await _masterRepository.GetAllStatesbyCountry(CountryId);
            List<DropdownDTO> masterstate = Mapper.Map<List<State>, List<DropdownDTO>>(liststatemaster);
            return masterstate;
        }
        public async Task<List<DropdownDTO>> GetAllCitiesbyStates(int StateId)
        {
            var liststatemaster = await _masterRepository.GetAllCitiesbyStates(StateId);
            List<DropdownDTO> mastercity = Mapper.Map<List<City>, List<DropdownDTO>>(liststatemaster);
            return mastercity;
        }




		public async Task<List<Country>> GetAllCountries_Cascading()
		{
			var listmaster = await _masterRepository.GetAllCountries();
			 
			return listmaster;
		}
		public async Task<List<State>> GetAllStatesbyCountry_Cascading(int CountryId)
		{
			var liststatemaster = await _masterRepository.GetAllStatesbyCountry(CountryId);
				return liststatemaster;
		}
		public async Task<List<City>> GetAllCitiesbyStates_Cascading(int StateId)
		{
			var liststatemaster = await _masterRepository.GetAllCitiesbyStates(StateId);
			return liststatemaster;
		}

	}
}
