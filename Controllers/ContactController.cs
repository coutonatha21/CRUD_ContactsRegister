using CRUD_ContactsRegister.Models;
using CRUD_ContactsRegister.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactsRegister.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
		public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.GetAll();
            return View(contacts);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            _contactRepository.Add(contact);
            return RedirectToAction("Index");

		}
    }
}
