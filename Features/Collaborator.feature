Feature: Collaborator
	Test the Collaborator functionality of application
	will verify if the Collaborator are working as expected

@Browser:Chrome
Scenario: Verify if the Collaborator functionality is working (+ve case) 
	 Given I have navigated to displaynote Application
	 And I have click the Collaborator icon
	 When I have fill the <Email> 
	 Then I click the Save button

	Examples: 
	| Email                 |
	| raghavimr15@gmail.com |