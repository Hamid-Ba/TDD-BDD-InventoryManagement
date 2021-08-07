using Inventory_Application_Contract.InventoryAgg;
using Inventory_Presentation.Controllers;
using NSubstitute;
using Xunit;

namespace Inventory_Presentation_Tests_Unit.Tests
{
    public class InventoryControllerTests
    {
        private readonly InventoryController _controller;
        private readonly IInventoryApplication _application;

        public InventoryControllerTests()
        {
            _application = Substitute.For<IInventoryApplication>();
            _controller = new InventoryController(_application);
        }

        [Fact]
        public void Should_Create_Method_Work_Properly()
        {
            //arrange
            var command = Utils.Utils.SomeCreateCode();

            //act
            _controller.Create(command);

            //assertion
            _application.ReceivedWithAnyArgs().Define(Arg.Any<InventoryDefineVM>());
        }

    }
}
