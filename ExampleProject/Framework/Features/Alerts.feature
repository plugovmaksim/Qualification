Feature: Alerts 
	I am user 
	I want to handle a alert
	To be able to accept is

	Scenario: Alert handing
	Given I go to 'JavaScript Alerts' on the Main Page
	When I generate JS alert on the JavaScript Alert Page
	And I accept the alert
	Then Success message is displayed on JavaScript Alert Page