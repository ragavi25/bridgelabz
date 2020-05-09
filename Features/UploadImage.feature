Feature: UploadImage
	Test the UploadImage functionality of application
	will verify if the UploadImage are working as expected

@Browser:Chrome
Scenario: Verify if the UploadImage functionality is working (+ve case) 
    Given I have navigated to addnote Application
	And I have click the UploadImage icon
	When I have click the choose file
	Then I click the AddImg button
