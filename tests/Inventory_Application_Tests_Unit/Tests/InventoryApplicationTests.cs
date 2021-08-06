using FluentAssertions;
using Inventory_Application;
using Inventory_Application_Contract.InventoryAgg;
using Inventory_Domain.InventoryAgg;
using NSubstitute;
using Xunit;

namespace Inventory_Application_Tests_Unit.Tests
{
    public class InventoryApplicationTests
    {
        private readonly IInventoryRepository _repository;
        private readonly IInventoryApplication _application;

        public InventoryApplicationTests()
        {
            _repository = Substitute.For<IInventoryRepository>();
            _application = new InventoryApplication(_repository);
        }

        [Fact]
        public void Should_Define_New_Inventory_Work_Properly()
        {
            //arrange
            var command = Utils.Utils.SomeCreateCode();

            //act
            _application.Define(command);

            //assertion
            _repository.ReceivedWithAnyArgs().Create(Arg.Any<Inventory>());
        }

        [Fact]
        public void Should_Return_True_When_Inventory_Defined()
        {
            //arrange
            var command = Utils.Utils.SomeCreateCode();

            //act
            var actual = _application.Define(command);

            //assertion
            actual.Should().BeTrue();
        }

    }
}