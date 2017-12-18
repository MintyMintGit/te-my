using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;

namespace _1TE_MY.Services.Interfaces
{
    public interface IAddressService
    {
        void UpdateAddress(Address address);
        Address GetAddressByCodeID(int addressID);
        List<Address> GetAllAddress();
    }
}
