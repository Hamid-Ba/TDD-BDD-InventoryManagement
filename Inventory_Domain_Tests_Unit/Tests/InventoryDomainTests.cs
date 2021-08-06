using System;
using FluentAssertions;
using Inventory_Domain.InventoryAgg;
using Inventory_Domain_Tests_Unit.Builder;
using Xunit;

namespace Inventory_Domain_Tests_Unit.Tests
{
    public class InventoryDomainTests
    {
        private readonly InventoryBuilder _builder;

        public InventoryDomainTests() => _builder = new InventoryBuilder();

        [Fact] 
        public void Should_InventoryConstruct_Properly()
        {
            //arrange
            string product = new Guid().ToString();
            int unitPrice = 1200;

            //act
            var actual = _builder.WriteProduct(product).WriteUnitPrice(unitPrice).Build();

            //assertion
            actual.Product.Should().Be(product);
            actual.UnitPrice.Should().Be(unitPrice);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Should_ThrowInvalidProductException_WhenProductIs(string nullOrEmpty)
        {
            //act
            Action actual = () => _builder.WriteProduct(nullOrEmpty).WriteUnitPrice(1100).Build();

            //assertion
            actual.Should().ThrowExactly<InvalidProductException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Should_ThrowInvalidUnitPriceException_WhenUnitPriceIs(int zeroOrNegative)
        {
            //act
            Action actual = () => _builder.WriteProduct(new Guid().ToString()).WriteUnitPrice(zeroOrNegative).Build();

            //assertion
            actual.Should().ThrowExactly<InvalidUnitPriceException>();
        }
    }
}
