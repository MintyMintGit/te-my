using _1TE_MY.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using System.Linq;

namespace _1TE_MY.Repository.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private _1TEDBContext _context;
        public AddressRepository(_1TEDBContext context)
        {
            _context = context;
        }
        public Address GetAddressByCodeID(int addressID)
        {
            return _context.Addresses.Where(m => m.AddressID == addressID).FirstOrDefault();
        }

        public List<Address> GetAllAddress()
        {
            return _context.Addresses.ToList();
        }

        public void UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
