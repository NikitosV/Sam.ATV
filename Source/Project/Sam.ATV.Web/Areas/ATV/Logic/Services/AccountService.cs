using System;
using System.Web.Security;
using Sam.ATV.Web.Areas.ATV.Models;
using Sam.ATV.Web.Areas.ATV.Models.Account;
using Sam.ATV.Web.Areas.ATV.Models.Account.ViewModels;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.SecurityModel;


namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public class AccountService : IAccountService
    {
        public static Database Master = Sitecore.Data.Database.GetDatabase("master");

        public bool Login(LoginViewModel model)
        {
            model.Email = $@"{"extranet"}\{model.Email}";

            try
            {
                if (Sitecore.Security.Authentication.AuthenticationManager.Login(model.Email, model.Password, true))
                {
                    return true;
                }
            }
            catch (System.Security.Authentication.AuthenticationException exception)
            {
                Sitecore.Diagnostics.Log.Error(exception.StackTrace + " Login error", "");
            }

            return false;
        }

        public void Register(RegisterViewModel model)
        {
            var userName = model.Email;
            userName = $@"{"extranet"}\{userName}";

            try
            {
                if (User.Exists(userName))
                {
                    return;
                }

                Membership.CreateUser(userName, model.Password, model.Email);

                var user = User.FromName(userName, true);

                user.Roles.Add(Role.FromName(@"extranet\User"));

                //user.Profile.FullName = $"{model.Email} {model.Surname}";

                using (new SecurityDisabler())
                {
                    // Assigning the user profile template
                    user.Profile.ProfileItemId = "{5A8608F8-9F9A-4D67-80DE-8C95C1A8435A}";
                    user.Profile.Save();

                    // Have modified the user template to also contain telephone number and patronomyc.
                    //user.Profile.SetCustomProperty("Surname", vm.Surname);
                    user.Profile.SetCustomProperty("Phone", model.Phone);
                }

                user.Profile.Save();

                this.CreateUser(userName);

                //Login(new LoginViewModel { Email = vm.Email, Password = vm.Password });
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error(
                    $"Error with (AddUser): Message: {ex.Message}; Source:{ex.Source}", this);
            }
        }

        public void LogOut()
        {
            Sitecore.Security.Authentication.AuthenticationManager.Logout();
        }

        private void CreateUser(string email)
        {
            using (new SecurityDisabler())
            {
                var itemName = email.Split('\\')[1];
                itemName = itemName.Replace("@", "__");
                itemName = itemName.Replace('.', '_');

                Item parent = Master.GetItem(ID.Parse("{670F3170-CDF1-481F-A5F7-891248E364D0}")); // id folder
                TemplateItem temp = Master.GetItem(ID.Parse("{4D06567A-3CC1-49FA-81A5-19400E23F995}")); // account

                // Add the item to the site tree
                var newItem = parent.Add(itemName, temp);

                // Set the new item in editing mode
                // Fields can only be updated when in editing mode
                // (It's like the begin tarnsaction on a database)
                newItem.Editing.BeginEdit();

                try
                {
                    // Assign values to the fields of the new item
                    newItem.Fields["EmailField"].Value = email;
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

        public void UpdateAccountProfile(AccountProfileViewModel model)
        {
            using (new SecurityDisabler())
            {
                var editAccount = Master.GetItem(model.Id.ToString());

                editAccount.Editing.BeginEdit();

                try
                {
                    editAccount.Fields["NameField"].Value = model.NameUVM;
                    editAccount.Fields["SurnameField"].Value = model.SurnameUVM;
                    editAccount.Fields["PhoneField"].Value = model.PhoneUVM;

                    editAccount.Editing.EndEdit();
                    GlobalLogic.PublishItem(editAccount);
                }
                catch (Exception ex)
                {
                    Sitecore.Diagnostics.Log.Error(
                        "Could not update item " + editAccount.Paths.FullPath + ": " + ex.Message, this);

                    editAccount.Editing.CancelEdit();
                }
            }
        }

    }
}