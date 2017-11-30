using _1TE_MY.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1TE_MY.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAll();
        Task<Country> GetById(int countryId);
    }
}
