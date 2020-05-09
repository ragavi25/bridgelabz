Feature: DeleteNote
	Test the DeleteNote functionality of application
	will verify if the DeleteNote are working as expected

@Browser:Chrome
Scenario: Verify if the DeleteNote functionality is working (+ve case) 
	Given I have a navigate to display page
	And I have click the more icons
	When I have click DeleteNote 
