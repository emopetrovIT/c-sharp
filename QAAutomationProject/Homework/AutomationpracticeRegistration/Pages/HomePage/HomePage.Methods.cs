
namespace Homework.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage _homePage;

        public HomePage Navigate(HomePage _homePage)
        {
            this.Navigate(Url);
            return new HomePage(Driver);
        }

        public LoginPage NavigateToRegistrationPage(HomePage homePage)
        {
            SignInButton.Click();
            return new LoginPage(Driver);
        }
    }
}
