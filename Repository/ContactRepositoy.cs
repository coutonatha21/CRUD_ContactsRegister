using CRUD_ContactsRegister.Data;
using CRUD_ContactsRegister.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_ContactsRegister.Repository
{
	public class ContactRepositoy : IContactRepository
	{
		private readonly Context _context;
		public ContactRepositoy(Context context)
		{
			_context = context;
		}
		public List<ContactModel> GetAll()
		{
			return _context.Contacts.ToList();
		}

		public ContactModel Add(ContactModel contact)
		{
			_context.Contacts.Add(contact);
			_context.SaveChanges();
			return contact;
		}

		
	}
}
