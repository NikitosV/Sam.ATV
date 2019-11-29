using Sam.ATV.Web.Areas.ATV.Models.Account;
using Sam.ATV.Web.Areas.ATV.Models.Account.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public interface IAccountService
    {
        bool Login(LoginViewModel model);
        void Register(RegisterViewModel model);
        void LogOut();
        void UpdateAccountProfile(AccountProfileViewModel model);
    }
}
