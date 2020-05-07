Feature: AddNote
	Test the AddNote functionality of application
	will verify if the Title and Description combination are working as expected

@Browser:Chrome
Scenario:Verify if the AddNote functionality is working (+ve case) 
Given I have navigated to my application
	And I type the data
	| Email                 | Password |
	| raghavimr15@gmail.com | 123456   |
	When I click login button
    Given I should see the Dashborad page
	Given I have put <Title> and <Description> 
	When I click close button
	

	Examples: 
	| Title    | Description |
	| Selenium | Testing     |
