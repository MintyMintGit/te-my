using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;

namespace _1TE_MY.Repository.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddressByCodeID(int addressID);
        List<Address> GetAllAddress();
        void UpdateAddress(Address address);
    }
}
