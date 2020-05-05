Feature: Register
	Test the Register functionality of application
	will verify if the Email and Password combination are working as expected

@Browser:Chrome
Scenario: Verify if the login functionality is working (+ve case) 
	Given I have navigated to Register application
	And I type the <FirstName>,<LastName>,<Email> and <Password>
	When I click Register button
	Then I should see the login page

	Examples: 
	| FirstName | LastName  | Email                 | Password |
	| Ragavi    | Rajendran | raghavimr15@gmail.com | 123456   |