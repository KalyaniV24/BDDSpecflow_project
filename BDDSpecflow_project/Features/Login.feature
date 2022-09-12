Feature: Login

A short summary of the feature



@high @valid
Scenario: Valid Credential
	Given I have browser with OrangeHRM
	When I enter username as "Admin"
	And I enter password as "admin123"
	And I click on login
	Then I should navigate to "PIM"

@low @invalid
Scenario Outline: Invalid Credentials
	Given I have browser with OrangeHRM
	When I enter username as "<username>"
	And I enter password as "<password>"
	And I click on login
	Then I should get error message "<error_message>"
Examples: 
	| username | password | error_message       |
	| jogn    | admin123 | invalid credentisls |
	| soul    | admin123 | invalid credentisls |








