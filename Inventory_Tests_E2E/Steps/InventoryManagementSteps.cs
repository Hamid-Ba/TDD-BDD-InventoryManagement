using System;
using TechTalk.SpecFlow;

namespace Inventory_Tests_E2E.Steps
{
    [Binding]
    public class InventoryManagementSteps
    {
        [Given(@"I Want To Define The Following Inventory")]
        public void GivenIWantToDefineTheFollowingInventory(Table table)
        {
            throw new NotImplementedException();
        }
        
        [When(@"I Try To Define This Inventory")]
        public void WhenITryToDefineThisInventory()
        {
        }
        
        [Then(@"The Inventory Should Be Created")]
        public void ThenTheInventoryShouldBeCreated()
        {
        }
        
        [Then(@"It Should Be Empty")]
        public void ThenItShouldBeEmpty()
        {
        }
    }
}
