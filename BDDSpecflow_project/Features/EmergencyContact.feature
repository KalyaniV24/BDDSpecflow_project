Feature: EmergencyContact

In order to reach the employee relation on emergency 
As an admin
I should have access to add, edit, delete records
​
Scenario Outline: Add Emergency Contact
	Given I have browser with OrangeHRM
	When I enter username as "<username>"
	And I enter password as "<password>"
	And I click on login
	And I click on My Info
	And I click on Emergency Contacts 
	And I click on Add
	And I fill the add emergency contact section
		| name   | relationship   | home_telephone   | mobile   | work_telephone   | 
		| <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> | 
	And I click on save emergency contact
	Then I should see add emergency contact record under assigned emergency contacts
Examples:
      | username | password | name   | relationship | home_telephone | mobile       | work_telephone | 
      | Kalyani123 | kalyani@123 | Kalyani | Sister | 2882010234        | 243432   | 896454        | 
      | shrushti124 | shrushti@123 | Shrushti | Mother     | 28820107       | 1132432   | 32432245        | 
