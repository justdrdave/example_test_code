@Pending
Feature: High priority scenarios

  As an automation tester
  I want to list the high priority tests I want to automate
  So that I can show what I want to automate first

  Scenario Outline: Add Items to basket
    Given I have added <number> items to my basket
    When I view my basket
    Then my basket should contain <number> items
    Examples:
    | number |
    | 1      |
    | 3      | 
    | 8      |
    | 15     | 

  Scenario: Login with Valid Email and Password
    Given I want to login to the site
    When I log in with "validEmail" and "validPassword"
    Then I should be logged in

  Scenario Outline: wrong/empty email or password
    Given I want to login to the site
    When I log in with <email> and <password>
    Then I should get a error message
    Examples:
      | email          | password          | 
      | "validEmail"   | "inValidPassword" | 
      | "inValidEmail" | "validPassword"   | 
      | "validEmail"   | "emptyPassword"   |  
      | "emptyEmail"   | "validPassword"   | 

  Scenario: Log out
    Given I have logged in
    When I  log out
    Then I should see the option to login again

  Scenario: Create account
    Given I want to create an account
    When I complete the account creation process
    Then I should be logged in

  Scenario: Checkout basket while logged in
    Given I have logged in
    And I have a basket containing items
    When I checkout
    Then I should be asked to provide address details

  Scenario: Checkout basket while not logged in
    Given I have not logged in
    And I have a basket containing items
    When when I checkout
    Then I should be asked login or create an account

  Scenario: Login during checkout
    Given I have not logged in
    And I have checked out my basket containing items
    When I log in with "validEmail" and "validPassword"
    Then I should be asked to provide address details

  Scenario: Create account during checkout
    Given I have not logged in
    And I have checked out my basket containing items
    When I complete the account creation process
    Then I should be asked to provide address details

  Scenario: Provide address details
    Given I have logged in
    And I have checked out my basket containing items
    When I provide my address details
    Then I should be asked to provide payment details

  Scenario: Provide valid payment details
    Given I have logged in
    And I have provided address details for checkout
    When I provide valid payment details
    Then checkout should be completed

  Scenario: Provide invalid payment details
    Given I have logged in
    And I have provided address details for checkout
    When I provide invalid payment details
    Then I should see an error

  Scenario: Update quantities in the basket to non zero value
    Given I have items in my basket
    When I update the quantaty of the items
    Then I should be able to check out

  Scenario: Remove all item from basket
    Given I have items in my basket
    When I update the quantaty of the items
    Then I should not be able to check out

  Scenario: Valid search
    Given I want to search for a specific item
    When I search with a valid phrase
    Then I should see results from my search

  Scenario: Invalid search
    Given I want to search for a specific item
    When I search with an invalid phrase
    Then I should see no results from my search

  Scenario: Account details
    Given I am logged in
    When I view my account section
    Then I should see options to update my details

  