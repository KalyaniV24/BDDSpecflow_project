Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify employee details in dashboard

@tag1
Scenario Outline: Add Valid Employee
	Given I have browser with OrangeHRM
	When I enter username as "Admin"
	And I enter password as "admin123"
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the add employee section
		| firstname   | middlename   | lastname   | employee_id | toggle_login_detail   | username   | password   | confirm_password  | status   |
		| <firstname> | <middlename> | <lastname> | <empid>     | <toggle_login_detail> | <username> | <password> | <confirmpassword> | <status> |
	And I click on save employee
	Then I should be navigated to personal details section with added employee records
Examples: 
| firstname | middlename | lastname | empid | toggle_login_detail | username  | password   | confirmpassword | <status  |
| Kalyani   | Ashish    | Vidhate   | 101   | on                  | kalyani123 | kalyani@123 | kalyani@123      | disabled |
| Shrushti  | Ashish2    | Patil    | 102   | on                  | shrushti124 | shrushti@123 | shrushti@123      | disabled |

