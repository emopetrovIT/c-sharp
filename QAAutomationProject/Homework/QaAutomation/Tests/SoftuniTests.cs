using Homework.Pages.SoftuniPage;
using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class SoftuniTests : BaseTest
    {
        private SoftuniPage _softUniPage;

        [SetUp]
        public void ClassInit()
        {
            _softUniPage = new SoftuniPage(Driver);
        }

        [Test]
        public void CheckTitleQaCoursePage()
        {
            _softUniPage.NavigateHomePage(_softUniPage);
            _softUniPage.NavigateToCourses();
            _softUniPage.SelectQaCourse();

            _softUniPage.AssertHeadingAutoCoursePage("QA Automation - септември 2019");
        }
    }
}
