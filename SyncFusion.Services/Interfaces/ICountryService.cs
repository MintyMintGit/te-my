using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Services.Interfaces
{
    public interface ICountryService
    {
      Task< List<CountryCodeDTO>> GetAll();

        Task<CountryCodeDTO> GetById(int countryId);
    }
}
