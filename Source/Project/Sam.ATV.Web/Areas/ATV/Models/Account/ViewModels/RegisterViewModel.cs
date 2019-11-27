using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Account.ViewModels
{
    public class RegisterViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]        //[Compare("Password", ErrorMessage = "Passwords don't confirmed")]
        public string ConfirmPassword { get; set; }
    }
}