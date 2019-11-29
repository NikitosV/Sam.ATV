using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Account
{
    public class AccountProfileViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string NameUVM { get; set; }
        public string SurnameUVM { get; set; }
        public string PhoneUVM { get; set; }
    }
}