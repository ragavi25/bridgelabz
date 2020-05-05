Feature: ForgotPassword
	Test the ForgotPassword functionality of application
	will verify if the Email are working as expected


@Browser:Chrome
Scenario: Verify if the ForgotPassword functionality is working (+ve case)
	Given I have navigated to ForgotPassword application
	And I type the <Email> 
	When I click Forgot button
	Then I should see the login page

	Examples: 
	| Email                 |
	| raghavimr15@gmail.com |
