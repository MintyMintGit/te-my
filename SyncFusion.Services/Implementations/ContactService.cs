using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;
using _1TE_MY.Services.Interfaces;
using _1TE_MY.Repository.Interfaces;


namespace _1TE_MY.Services.Implementations
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public int AddContact(List<Registration_ContactPerson> ContactDto)
        {
            try
            {
                foreach (var item in ContactDto)
                {
                    Registration_ContactPerson contact = item;
                    var contactsave = Mapper.Map<Registration_ContactPerson, Contact>(contact);
                    //return _contactRepository.AddContact(contact);
                    _contactRepository.AddContact(contactsave);
                }

                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
		
		public int Delete(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Registration_ContactPerson> GetAllContact()
        {
            var dbcontact = _contactRepository.GetAllContacts();
            List<Registration_ContactPerson> contactDtoList = Mapper.Map<List<Contact>, List<Registration_ContactPerson>>(dbcontact);
            return contactDtoList;
        }

        public Registration_ContactPerson GetContactByContactId(int ContactId)
        {
            var dbcontact = _contactRepository.GetContactById(ContactId);
            Registration_ContactPerson contactDto = Mapper.Map<Contact, Registration_ContactPerson>(dbcontact);
            return contactDto;
        }

        public List<CountryCodeDTO> GetCountryList()
        {
            var dbCountry = _contactRepository.GetCountryList();
            Registration_ContactPerson contact = new Registration_ContactPerson();
            contact.CountryList = Mapper.Map<List<Country>, List<CountryCodeDTO>>(dbCountry);
            return contact.CountryList;
        }
    }
}
