using FluentAssertions;
using Inventory_Application_Contract.InventoryAgg;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Inventory_Tests_E2E.Steps
{
    [Binding]
    public class InventoryManagementSteps
    {
        private bool _result;
        private RestClient _client;
        private InventoryDefineVM _inventory;

        [Given(@"I Want To Define The Following Inventory")]
        public void GivenIWantToDefineTheFollowingInventory(Table table)
        {
            _inventory = table.CreateInstance<InventoryDefineVM>();
        }

        [When(@"I Try To Define This Inventory")]
        public void WhenITryToDefineThisInventory()
        {
            _client = new RestClient(HostConstants.Endpoint);
            var request = new RestRequest("Inventory", DataFormat.Json);

            request.AddJsonBody(_inventory);
            var actual = _client.Post<bool>(request);

            _result = JsonConvert.DeserializeObject<bool>(actual.Content);
        }

        [Then(@"The Inventory Should Be Created")]
        public void ThenTheInventoryShouldBeCreated()
        {
            _result.Should().BeTrue();
        }

        [Then(@"It Should Be Empty")]
        public void ThenItShouldBeEmpty()
        {
        }
    }
}
