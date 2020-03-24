Feature: Use Gmail Account
Scenario: Login to Gmail Account
	Given I navigate to Gmail
	When I navigate to Sign In
	And I Provide Email ID
	And I Provide Password
	Then I should login to Gmail account
