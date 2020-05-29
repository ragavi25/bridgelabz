Feature: FundooApp
	Test the FundooApp functionality of application
    will verify if the Email and Password combination are working as expected
	

@Browser:Chrome
Scenario: Verify if the  FundooApp functionality is working (+ve case) 
	Given I have navigated to Register application
    And I have fill the details 
    When I click Register button
    Then I should see the login page
	Given I have navigated to my application
    And I type the <Email>and<Password>
    When I click login button
    Given I have put <Title> and <Description>
    When I click close button
     Given I have navigated to displaynote Application
     And   I have update the <Title> and <Description>
    When I click updateClose button
   #When I click the listview
   Given I have navigate a Dashborad page
   And I have click the Bin
   When I have click the Deleteall
   Then I have navigate Bin
  Then I have click the Restore
  Given I have navigated to AdminRegister application
And I have fill the details
When I click AdminRegister button
Then I should see the login page
Given I have navigated to Adminlogin application
And I have take data<Email>and<Password>
When I click Adminlogin button
#Given I have take a ScreenShot
  