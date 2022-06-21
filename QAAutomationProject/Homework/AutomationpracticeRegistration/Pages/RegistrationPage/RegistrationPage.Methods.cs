using Homework.Extensions;
using Homework.Utilities;
using System;


namespace Homework.Pages
{
    public partial class RegistrationPage
    {       
        public void FillForm(RegistrationUser user)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            RadioButtons[1].Click();
            CustomerFirstName.Type(user.FirstName);
            CustomerLastName.Type(user.LastName);
            Password.Type(user.Password);
            Days.SelectByValue(user.Date);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            RealFirstName.Type(user.RealFirstName);
            RealLastName.Type(user.RealLastName);
            Address.Type(user.Address);
            City.Type(user.City);
            State.SelectByText(user.State);
            PostCode.Type(user.PostCode);
            Phone.Type(user.Phone);
            Alias.Type(user.Alias);
            RegisterButton.Click();            
        }

        public void Navigate(LoginPage loginPage)
        {
            var randomEmail = RandomGenerator.GenerateMail();
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");
            loginPage.Email.Type(randomEmail.ToString());
            loginPage.Submit.Click();
        }
    }
}
