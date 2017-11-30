using _1TE_MY.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using System.Linq;
using System.Threading.Tasks;

namespace _1TE_MY.Repository.Implementations
{
    public class CountryRepository : ICountryRepository
    {
        private _1TEDBContext _context;
        public CountryRepository(_1TEDBContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetAll()
        {
            return await  _context.Country.Where(d => d.IsActive == true).ToAsyncEnumerable<Country>().ToList();
        }

        public async Task<Country> GetById(int countryId)
        {
            return await _context.Country.Where(d => d.IsActive == true && d.CountryID== countryId).ToAsyncEnumerable().FirstOrDefault();
        }
    }
}
