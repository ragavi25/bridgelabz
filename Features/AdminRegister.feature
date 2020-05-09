Feature: AdminRegister
	Test the AdminRegister functionality of application
	will verify if the Email and Password combination are working as expected

@Browser:Chrome
Scenario: Verify if the	AdminRegister functionality is working (+ve case) 
	Given I have navigated to AdminRegister application
	And I have fill the details
	| FirstName | LastName  | Email                 | Password |
	| Ragavi    | Rajendran | raghavimr15@gmail.com | 123456   |
	When I click AdminRegister button
	Then I should see the login page

