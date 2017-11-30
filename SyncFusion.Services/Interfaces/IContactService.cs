using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;

namespace _1TE_MY.Services.Interfaces
{
    public interface IContactService
    {
        int AddContact(List<Registration_ContactPerson> ContactDto);
        List<Registration_ContactPerson> GetAllContact();
        Registration_ContactPerson GetContactByContactId(int ContactId);
        int Delete(int ContactId);
        List<CountryCodeDTO> GetCountryList(); 
		
	}
}
