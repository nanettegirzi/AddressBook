using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpGet("/contacts/details/{id}")]
        public ActionResult Details(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }

        [HttpPost("/contacts")]
        public ActionResult Create()
        {
            Contact newContact = new Contact (Request.Form["first-name"], Request.Form["last-name"], Request.Form["address"], Request.Form["phone"]);

            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }

        [HttpPost("/contacts/delete")]
        public ActionResult DeleteAll()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
