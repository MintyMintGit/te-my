using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;
using _1TE_MY.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace _1TE_MY.Repository.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private _1TEDBContext _context;
        public ContactRepository(_1TEDBContext context)
        {
            _context = context;
        }
       
        public List<Contact> AddContact(Contact contact)
        {
            try
            {
                if (contact != null)
                {
                    _context.Contact.Add(contact);
                    _context.SaveChanges();
                   
                }
                return GetAllContacts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<Contact> AddCompany(Contact contact)
		{
			try
			{
				if (contact != null)
				{
					_context.Contact.Add(contact);
					_context.SaveChanges();

				}
				return GetAllContacts();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int DeleteContact(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllContacts()
        {
            return _context.Contact.Where(d => d.IsActive == true).ToList();
        }

        public Contact GetContactById(int ContactId)
        {
            return _context.Contact.Where(d => d.IsActive == true && d.ContactID== ContactId).FirstOrDefault();
        }

        public List<Country> GetCountryList()
        {
            return _context.Country.Where(d => d.IsActive == true).ToList();

        }
    }
}
