Feature: Updatenote
	Test the Updatenote functionality of application
	will verify if the Title and Description combination are working as expected

@Browser:Chrome
Scenario: Verify if the Updatenote functionality is working (+ve case)
Given I have navigated to my application
	And I type the data
	| Email                 | Password |
	| raghavimr15@gmail.com | 123456   |
	When I click login button
	Given I have navigated to displaynote Application
	And   I have update the <Title> and <Description> 
	When I click updateClose button

	Examples: 
	| Title      | Description |
	| bridgelabz | IT          |
	
