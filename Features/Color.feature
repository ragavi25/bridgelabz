Feature: Color
	Test the  Color functionality of application
	will verify if the  Colors are working as expected

@Browser:Chrome
Scenario: Verify if the Color functionality is working (+ve case) 
	 Given I have navigated to displaynote Application
	 And I have click the Color icon
	 When I have take the color <color> 

	 Examples: 
	 | color              |
	 | rgb(255, 179, 255) |
	 
