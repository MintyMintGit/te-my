using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;

namespace _1TE_MY.Repository.Interfaces
{
    public interface IContactRepository
    {
        List<Contact> AddContact(Contact contact);
        List<Contact> GetAllContacts();
        Contact GetContactById(int ContactId);
        int DeleteContact(int ContactId);
        List<Country> GetCountryList();
    }
}
