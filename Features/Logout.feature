Feature: Logout
	Test the Logout functionality of application

@Browser:Chrome
Scenario:Verify if the logout functionality is working (+ve case) 
	Given I have navigated to Dashborad Application
	When I click signout button
	Then I should see the login page
