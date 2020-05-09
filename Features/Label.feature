Feature: Label
	Test the Label functionality of application
	will verify if the Label are working as expected

@Browser:Chrome
Scenario: Verify if the Label functionality is working (+ve case) 
    Given I have a navigate to Dashborad page
	And I have click the more icon
	When I have click Addlabel 
	Then I have create a label name <labelname>
	Then I click the done button
	#When I click close button

	Examples: 
	| labelname |
	| hii       |
