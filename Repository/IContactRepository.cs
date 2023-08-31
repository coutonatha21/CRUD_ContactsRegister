using CRUD_ContactsRegister.Models;
using System.Collections.Generic;

namespace CRUD_ContactsRegister.Repository
{
	public interface IContactRepository
	{
		List<ContactModel>GetAll();
		ContactModel Add(ContactModel contact);
	}
}
