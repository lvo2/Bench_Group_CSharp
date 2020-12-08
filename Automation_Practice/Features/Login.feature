Feature: Login
	Sign the the automation practice page
	#login the practice automation page
@Login 
Scenario: Sign In the Automation Practice page
	Given I navigate to the automation practice page
	And I see the automation practice sign in page is loaded
	When I sign in the automation practice page by end user
	Then I see the user name is displayed in the home page