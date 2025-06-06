@allure.suite:LoginSuite
@allure.subSuite:PositiveTests
@allure.owner:maksim
@allure.severity:critical
@allure.tag:api
@allure.issue:BUG-123
@allure.tms:TMS-456
@allure.label.epic:WebInterface
Feature: Alerts 
	I am user 
	I want to handle a alert
	To be able to accept is

	@allure.label.story:CreateLabels
	Scenario: Alert handing
	Given I go to 'JavaScript Alerts' on the Main Page
	When I generate JS alert on the JavaScript Alert Page
	And I accept the alert
	Then Success message is displayed on JavaScript Alert Page