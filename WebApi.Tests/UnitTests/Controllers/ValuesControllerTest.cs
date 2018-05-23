namespace WebApi.Tests.UnitTests.Controllers
{
    using FluentAssertions;
    using WebApi.Controllers;
    using NUnit.Framework;

    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get(1);

            // Assert
            result.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void GetAll()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            result.Should().NotBeNullOrEmpty();
        }
    }
}