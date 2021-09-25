@Example_tests
Feature: Example Tests

  As an automation tester
  I want to provide a couple of working tests
  So that I can demonstrate the automation working

  Scenario: Login with Valid Email and Password
    Given I want to login to the site
    When I log in with "validEmail" and "validPassword"
    Then I should be logged in
