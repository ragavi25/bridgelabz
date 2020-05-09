Feature: Adminlogin
	Test the Adminlogin functionality of application
	will verify if the Email and Password combination are working as expected

@Browser:Chrome
Scenario Outline:Verify if the Adminlogin functionality is working (+ve case) 
	Given I have navigated to Adminlogin application
	And I have take data
	| Email                 | Password |
	| raghavimr15@gmail.com | 123456   |
	When I click Adminlogin button
	#Then I should see the Dashborad page

	
	
