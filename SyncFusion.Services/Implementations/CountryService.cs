using AutoMapper;
using _1TE_MY.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;
using _1TE_MY.Repository.Interfaces;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task<List<CountryCodeDTO>> GetAll()
        {
            var dbcountry = await   _countryRepository.GetAll();
            List<CountryCodeDTO> countryList = Mapper.Map<List<Country>, List<CountryCodeDTO>>(dbcountry);
            return countryList;
        }

        public async Task<CountryCodeDTO>  GetById(int countryId)
        {
            var dbcountry = await _countryRepository.GetById(countryId);
            CountryCodeDTO country = Mapper.Map<Country, CountryCodeDTO>(dbcountry);
            return country;
        }
    }
}
