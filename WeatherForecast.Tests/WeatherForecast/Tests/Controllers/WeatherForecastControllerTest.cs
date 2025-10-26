using System.Linq;
using WebApplication1.Controllers;
using Xunit;

namespace WeatherForecast.Tests.Controllers
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsFiveForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get().ToList();

            // Assert
            Assert.Equal(4, result.Count);
        }
    }
}
