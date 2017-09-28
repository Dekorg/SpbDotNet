using FunnyTask.Controllers;
using Xunit;

namespace FunnyTask.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void DeadlockTest()
        {
            //Arrange
            var controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.Equal("Bang", result);
        }
    }
}
