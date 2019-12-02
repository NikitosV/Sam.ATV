using System;
using System.Web.Security;
using Sam.ATV.Web.Areas.ATV.Models.Account.ViewModels;
using Sam.ATV.Web.Areas.ATV.Models.Order;
using Sam.Foundation.Repository.Content;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.SecurityModel;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public class OrderService : IOrderService
    {
        public static Database Master = Sitecore.Data.Database.GetDatabase("master");

        private readonly IContentRepository _contentRepository;

        public OrderService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public void AddBikeAsOrder(string bikeId, string bikeName, string bikePrice)
        {
            var emailName = User.Current.Name;

            using (new SecurityDisabler())
            {
                var itemName = emailName.Split('\\')[1];
                itemName = itemName.Replace("@", "__");
                itemName = itemName.Replace('.', '_');

                Item parent = Master.GetItem(ID.Parse("{08D7057C-369D-4900-9FA0-4BCD976216D8}")); // id folder
                TemplateItem temp = Master.GetItem(ID.Parse("{510E2C3A-FAE7-4285-8737-537CFC4CDEA7}")); // bikeOrder

                // Add the item to the site tree
                var newItem = parent.Add(itemName, temp);

                // Set the new item in editing mode
                // Fields can only be updated when in editing mode
                // (It's like the begin tarnsaction on a database)
                newItem.Editing.BeginEdit();

                try
                {
                    // Assign values to the fields of the new item
                    newItem.Fields["EmailName"].Value = emailName;
                    newItem.Fields["BikeId"].Value = bikeId;
                    newItem.Fields["BikeName"].Value = bikeName;
                    newItem.Fields["Price"].Value = bikePrice;
                    //newItem.Fields["Phone"].Value =

                    // End editing will write the new values back to the Sitecore
                    // database (It's like commit transaction of a database)
                    newItem.Editing.EndEdit();
                    GlobalLogic.PublishItem(newItem);
                }
                catch (Exception ex)
                {
                    // The update failed, write a message to the log
                    Sitecore.Diagnostics.Log.Error(
                        "Could not update item " + newItem.Paths.FullPath + ": " + ex.Message,
                        this); //TODO $"" и вынести в константу

                    // Cancel the edit (not really needed, as Sitecore automatically aborts
                    // the transaction on exceptions, but it wont hurt your code)
                    newItem.Editing.CancelEdit();
                }
            }

        }

        public IOrderClass GetOrderCardContent(string contentGuid)
        {
            return _contentRepository.GetContentItem<IOrderClass>(contentGuid);
        }
    }
}