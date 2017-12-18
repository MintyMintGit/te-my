using _1TE_MY.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using System.Collections;
using _1TE_MY.Repository.Interfaces;

namespace _1TE_MY.Services.Implementations
{
    public class AddressService : IAddressService
    {

        private IAddressRepository _addressRepository;
        public AddressService(IAddressRepository AddressRepository)
        {
            _addressRepository = AddressRepository;
        }

        public Address GetAddressByCodeID(int addressID)
        {
            return _addressRepository.GetAddressByCodeID(addressID);
        }

        public List<Address> GetAllAddress()
        {
            return _addressRepository.GetAllAddress();
        }

        public void UpdateAddress(Address address)
        {
            _addressRepository.UpdateAddress(address);
        }
    }
}
