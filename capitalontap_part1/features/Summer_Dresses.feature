@Example_tests
Feature: Example Tests

  As an automation tester
  I want to provide a couple of working tests
  So that I can demonstrate the automation working

  Scenario: Hover the Dresses tab and click Summer dresses
    Given I am on the test automation practice site
    When I select 'Summer Dresses' from the 'Dresses' options
    Then I should be shown all 'Summer Dresses'
