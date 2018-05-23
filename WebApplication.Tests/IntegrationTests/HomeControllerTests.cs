namespace WebApplication.Tests.IntegrationTests
{
    using FluentAssertions;
    using OpenQA.Selenium.PhantomJS;
    using Xunit;

    public class HomeControllerTests
    {
        [Fact]
        public void Index()
        {
            // TODO: put the development environment url
            const string baseUrl = "";
            var driver = new PhantomJSDriver();


            driver.Navigate().GoToUrl(baseUrl);
            var element = driver.FindElementById("learn_more");

            element.Should().NotBeNull();
        }
    }
}