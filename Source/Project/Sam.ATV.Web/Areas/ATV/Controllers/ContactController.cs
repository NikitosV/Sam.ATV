using Sam.ATV.Web.Areas.ATV.Logic.Services;
using Sam.ATV.Web.Areas.ATV.Models.Account;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.ATV.Web.Areas.ATV.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ViewResult Index()
        {
            return View("~/Areas/ATV/Views/Contact/Index.cshtml");
        }

        public void AddSocialRev(string ContactName, string ContactSurname, string ContactPhone, string ContactCompany, string ContactMessage)
        {
            using (new SecurityDisabler())
            {
                if (ContactName != null & ContactSurname != null & ContactPhone != null & ContactCompany != null & ContactMessage != null)
                {
                    _contactService.AddContactRev(ContactName, ContactSurname, ContactPhone, ContactCompany, ContactMessage);
                }
            }
        }
    }
}