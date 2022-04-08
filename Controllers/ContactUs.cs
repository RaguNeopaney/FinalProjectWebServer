﻿using FinalProjectWebServer.DBContext;
using FinalProjectWebServer.Models.DomainModels;
using FinalProjectWebServer.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectWebServer.Controllers
{
    public class ContactUs : Controller
    {
        // DBContext stuff
        private ContactUsDbContext _context { get; set; }

        public ContactUs(ContactUsDbContext ctx)
        {
            _context = ctx;
        }

        public IActionResult ContactUsHome()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUsPost(ContactUsViewModel ContactUsViewModelForDB)
        {
            if (ModelState.IsValid)
            {
                ContactUsDomainModel contactUstosave = new ContactUsDomainModel
                {
                    Name = ContactUsViewModelForDB.Name,
                    Email = ContactUsViewModelForDB.Email,
                    Messsage = ContactUsViewModelForDB.Message
                };
                _context.ContactUs.Add(contactUstosave);
                _context.SaveChanges();
            }

            return RedirectToAction("ContactUsHome", "ContactUs");
        }
    }
}