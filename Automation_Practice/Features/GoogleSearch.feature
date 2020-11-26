Feature: Google Search
This feature search a keyword from Google site

@GoogleSearch
Scenario: Google Search
Given I navigate to the Google page 
And I see the page loaded
When I enter keyword search "SpecFlow" in the Search Text box
And I click on Search button
Then Search items shows the items related to SpecFlow