using System.Threading.Tasks;
using FluentAssertions;
using Inventory_Application_Contract.InventoryAgg;
using Inventory_Presentation;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using Xunit;

namespace Inventory_Presentation_Tests_Integration.Tests
{
    public class InventoryPresentationTests
    {
        private const string Url = "https://localhost:5001/api/Inventory";
        private readonly RESTFulApiFactoryClient _client;

        public InventoryPresentationTests()
        {
            var factory = new WebApplicationFactory<Startup>();
            var httpClient = factory.CreateClient();
            _client = new RESTFulApiFactoryClient(httpClient);
        }

        [Fact]
        public async Task Should_Define_Inventory_Post_Work_Properly()
        {
            //arrange
            var command = Utils.Utils.SomeCreateCode();

            //act
            var actual = await _client.PostContentAsync<InventoryDefineVM, bool>(Url, command);

            //assertions
            actual.Should().BeTrue();
        }
    }
}
