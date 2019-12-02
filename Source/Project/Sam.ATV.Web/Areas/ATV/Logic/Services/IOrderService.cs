using Sam.ATV.Web.Areas.ATV.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public interface IOrderService
    {
        void AddBikeAsOrder(string bikeId, string bikeName, string bikePrice);

        IOrderClass GetOrderCardContent(string contentGuid);
    }
}
