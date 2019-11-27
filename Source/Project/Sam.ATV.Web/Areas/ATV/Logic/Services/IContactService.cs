using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public interface IContactService
    {
        void AddContactRev(string ContactName, string ContactSurname, string ContactPhone, string ContactCompany, string ContactMessage);
    }
}
