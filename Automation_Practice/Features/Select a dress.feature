Feature: Select a dress
Log in the Automation Practice page, select a dress from Women collection

@AddToCart
Scenario: Select a dress and add to cart
	Given I am logged in to the practice automation page as a customer
	When I select a item from the Women collection to add to cart
	Then I see the dress added in the Cart