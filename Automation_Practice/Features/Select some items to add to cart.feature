@AddToCart
Feature: Select some items to add to cart
	Select some items in each collection to add to cart

Background:
    Given I am logged in to the practice automation page as a customer

@AddToCart
Scenario: Select a item from Dress collection
	When I select a item from the Dresss collection to add to cart
	Then I see the item added in the Cart

@AddToCart
Scenario: Select a item from T-Shirt collection
	When I select a item from the TShirt collection to add to cart
	Then I see the item added in the Cart