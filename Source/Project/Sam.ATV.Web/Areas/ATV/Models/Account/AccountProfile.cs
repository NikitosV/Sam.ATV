using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Account
{
    public class AccountProfile : ICmsEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NameUser { get; set; }
        public string SurnameUser { get; set; }
        public string PhoneUser { get; set; }
    }
}