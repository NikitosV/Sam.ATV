using Sam.Foundation.Repository.Content;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.SecurityModel;
using System;


namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public class ContactService : IContactService
    {

        public static Database Master = Sitecore.Data.Database.GetDatabase("master");

        private readonly IContentRepository _contentRepository;

        public ContactService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public void AddContactRev(string ContactName, string ContactSurname, string ContactPhone, string ContactCompany, string ContactMessage)
        {
            var emailName = User.Current.Name;

            using (new SecurityDisabler())
            {
                var itemName = emailName.Split('\\')[1];
                itemName = itemName.Replace("@", "__");
                itemName = itemName.Replace('.', '_');

                Item parent = Master.GetItem(ID.Parse("{9B751520-3D50-4A08-A437-B1576A3549BF}")); // id folder
                TemplateItem temp = Master.GetItem(ID.Parse("{693EFA96-9C09-4764-A5FD-E90F3EE9394D}")); // conatct

                // Add the item to the site tree
                var newItem = parent.Add(itemName, temp);

                // Set the new item in editing mode
                // Fields can only be updated when in editing mode
                // (It's like the begin tarnsaction on a database)
                newItem.Editing.BeginEdit();

                try
                {
                    // Assign values to the fields of the new item
                    newItem.Fields["Name"].Value = ContactName;
                    newItem.Fields["Surname"].Value = ContactSurname;
                    newItem.Fields["Email"].Value = emailName;
                    newItem.Fields["Phone"].Value = ContactPhone;
                    newItem.Fields["Company"].Value = ContactCompany;
                    newItem.Fields["Message"].Value = ContactMessage;

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
    }
}