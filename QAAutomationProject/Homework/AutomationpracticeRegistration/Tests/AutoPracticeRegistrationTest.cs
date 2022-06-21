using Homework.Pages;
using Homework.Pages.HomePage;
using NUnit.Framework;


namespace Homework.Tests
{
    [TestFixture]
    public class AutoPracticeRegistrationTest : BaseTest
    {
        private HomePage _homePage;
        private LoginPage _loginPage;

        [SetUp]
        public void ClassInit()
        {
            _homePage = new HomePage(Driver);
            _loginPage = new LoginPage(Driver);
        }

        [Test]
        public void VerifyAccessToRegistrationPage()
        {
            _homePage
            .Navigate(_homePage)
            .NavigateToRegistrationPage(_homePage)
            .VerifyHomeIconIsDisplayed(_loginPage);            
        }
    }
}
