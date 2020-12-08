Feature: Select a dress
Log in the Automation Practice page, select a dress from Women collection

@AddToCart
Scenario: Select a dress and add to cart
	Given I navigate to the automation practice page
    When I select a dress from the Women collection
	Then I see the dress added in the Cart