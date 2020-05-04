Feature: AddNote
	Test the AddNote functionality of application
	will verify if the Title and Description combination are working as expected

@Browser:Chrome
Scenario:Verify if the AddNote functionality is working (+ve case) 
	Given I have put <Title> and <Description> 
	When I click close button
	
	Examples: 
	| Title    | Description |
	| Selenium | Testing     |
