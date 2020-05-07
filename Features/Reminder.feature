Feature: Reminder
	Test the Reminder functionality of application
	will verify if the reminder are working as expected

	@Browser:Chrome
Scenario: Verify if the Reminder functionality is working (+ve case) 
    Given I have navigated to displaynote Application
	And I have click the Reminder icon
	When I have the Select date and time 
	Then I have fill the date<date>
	Then I click the save button

	Examples: 
	| date     |
	| 5/9/2020 |
