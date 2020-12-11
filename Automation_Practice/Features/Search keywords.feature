Feature: Search keywords
	This feature define outline, example

@Search
Scenario Outline: Search keywords
    Given I am logged in to the practice automation page as a customer
  	When I select "<keyword>" below
	Then I see the "<keyword>" dislayed 
	Examples:
        | keyword	  | 
        | dress       | 
		| t-shirt     | 
	    | blouse      | 