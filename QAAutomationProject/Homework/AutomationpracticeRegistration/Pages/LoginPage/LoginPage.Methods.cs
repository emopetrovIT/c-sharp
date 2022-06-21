﻿using Homework.Utilities;

namespace Homework.Pages
{
    public partial class LoginPage : BasePage
    {
        public RegistrationPage NavigateToRegistrationPage(LoginPage loginPage)
        {
            var randomEmail = RandomGenerator.GenerateMail();
            loginPage.Email.SendKeys(randomEmail.ToString());
            loginPage.Submit.Click();
            return new RegistrationPage(Driver);
        }
    }
}
