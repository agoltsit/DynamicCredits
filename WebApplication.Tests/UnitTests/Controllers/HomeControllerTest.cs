namespace WebApplication.Tests.UnitTests.Controllers
{
    using System.Web.Mvc;
    using FluentAssertions;
    using WebApplication.Controllers;
    using NUnit;
    using NUnit.Framework;

    public class HomeControllerTest
    {
        [Test]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            "Your application description page.".Should().Be(result?.ViewBag?.Message);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }

        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }
    }
}