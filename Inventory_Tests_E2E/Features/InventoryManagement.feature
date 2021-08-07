@api
Feature: Inventory Management
	As A Warehouse Keeper
	I Want To Keep Track About Products Stock
	So That I Always Have Accurate Info Of Inventory

Scenario: Defining A New Inventory
	Given I Want To Define The Following Inventory
	| Product | UnitPrice |
	| Asus    | 1100      |
	When I Try To Define This Inventory
	Then The Inventory Should Be Created
	And It Should Be Empty