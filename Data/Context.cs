using CRUD_ContactsRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ContactsRegister.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options) 
		{
		}
		public DbSet<ContactModel> Contacts { get; set; }
	}
}